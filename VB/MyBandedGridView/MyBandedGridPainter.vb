Imports System.Drawing
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.BandedGrid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace CustomGrid

    Public Class MyBandedGridPainter
        Inherits BandedGridPainter

        Public Sub New(ByVal view As BandedGridView)
            MyBase.New(view)
        End Sub

        Protected Overrides Sub DrawRows(ByVal e As GridViewDrawArgs)
            MyBase.DrawRows(e)
            DrawEmptyAreaLines(e)
        End Sub

        Protected Overridable Sub DrawEmptyAreaLines(ByVal e As GridViewDrawArgs)
            Dim rects As GridViewRects = e.ViewInfo.ViewRects
            Dim er As Rectangle = rects.EmptyRows
            If er.IsEmpty Then Return
            Dim pen As Pen = SystemPens.ControlDark
            If View.OptionsView.ShowVertLines Then
                For Each column As GridColumnInfoArgs In e.ViewInfo.ColumnsInfo
                    Dim x As Integer = column.Bounds.Right - 1
                    If column.Column IsNot Nothing AndAlso column.Column.Fixed <> DevExpress.XtraGrid.Columns.FixedStyle.None OrElse (rects.FixedLeft.IsEmpty OrElse x > rects.FixedLeft.Right) AndAlso (rects.FixedRight.IsEmpty OrElse x < rects.FixedRight.Left - 3) Then e.Graphics.DrawLine(pen, x, er.Top, x, er.Bottom)
                Next

                If Not rects.FixedRight.IsEmpty Then e.Graphics.DrawLine(pen, rects.FixedRight.Left - 1, er.Top, rects.FixedRight.Left - 1, er.Bottom)
            End If

            If View.OptionsView.ShowHorzLines Then
                Dim rowHeight As Integer = e.ViewInfo.MinRowHeight
                Dim y As Integer = er.Top + rowHeight
                While y < er.Bottom
                    e.Graphics.DrawLine(pen, er.Left, y, rects.DataRectRight - 1, y)
                    y += rowHeight
                End While
            End If
        End Sub
    End Class
End Namespace
