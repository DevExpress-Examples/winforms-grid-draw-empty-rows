Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Registrator

Namespace CustomGrid
	Public Class MyGridViewInfoRegistrator
		Inherits GridInfoRegistrator

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyGridView(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreatePainter(ByVal view As BaseView) As BaseViewPainter
			Return New MyGridPainter(TryCast(view, MyGridView))
		End Function
	End Class
	Public Class MyBandedGridViewInfoRegistrator
		Inherits BandedGridInfoRegistrator

		Public Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyBandedGridView"
			End Get
		End Property
		Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
			Return New MyBandedGridView(TryCast(grid, GridControl))
		End Function
		Public Overrides Function CreatePainter(ByVal view As BaseView) As BaseViewPainter
			Return New MyBandedGridPainter(TryCast(view, MyBandedGridView))
		End Function
	End Class
End Namespace
