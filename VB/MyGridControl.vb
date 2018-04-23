Imports System
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Registrator

Namespace CustomGrid
	Public Class MyGridControl
		Inherits GridControl

		Protected Overrides Function CreateDefaultView() As BaseView
			Return CreateView("MyGridView")
		End Function
		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New MyGridViewInfoRegistrator())
			collection.Add(New MyBandedGridViewInfoRegistrator())
		End Sub
	End Class
End Namespace
