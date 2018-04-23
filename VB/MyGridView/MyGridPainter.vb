Imports System
Imports System.Drawing
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace CustomGrid
	Public Class MyGridPainter
		Inherits GridPainter

		Public Sub New(ByVal view As GridView)
			MyBase.New(view)
		End Sub

		Protected Overrides Sub DrawRows(ByVal e As GridViewDrawArgs)
			MyBase.DrawRows(e)
			DrawEmptyAreaLines(e)
		End Sub
		Protected Overridable Sub DrawEmptyAreaLines(ByVal e As GridViewDrawArgs)
			Dim rects As GridViewRects = e.ViewInfo.ViewRects
			Dim er As Rectangle = rects.EmptyRows
			If er.IsEmpty Then
				Return
			End If

			Dim pen As Pen = SystemPens.ControlDark
			If View.OptionsView.ShowVerticalLines <> DevExpress.Utils.DefaultBoolean.False Then
				For Each column As GridColumnInfoArgs In e.ViewInfo.ColumnsInfo
					Dim x As Integer = column.Bounds.Right - 1
					If (column.Column IsNot Nothing AndAlso column.Column.Fixed <> DevExpress.XtraGrid.Columns.FixedStyle.None) OrElse ((rects.FixedLeft.IsEmpty OrElse x > rects.FixedLeft.Right) AndAlso (rects.FixedRight.IsEmpty OrElse x < rects.FixedRight.Left - 3)) Then
						e.Cache.DrawLine(pen, New Point(x, er.Top), New Point(x, er.Bottom))
					End If

				Next column
				If Not rects.FixedRight.IsEmpty Then
					e.Cache.DrawLine(pen, New Point(rects.FixedRight.Left - 1, er.Top), New Point(rects.FixedRight.Left - 1, er.Bottom))
				End If
			End If

			If View.OptionsView.ShowHorizontalLines <> DevExpress.Utils.DefaultBoolean.False Then
				Dim rowHeight As Integer = e.ViewInfo.MinRowHeight
				For y As Integer = er.Top + rowHeight To er.Bottom - 1 Step rowHeight
					e.Cache.DrawLine(pen, New Point(er.Left, y), New Point(rects.DataRectRight.Right - 1, y))
				Next y
			End If
		End Sub
	End Class
End Namespace
