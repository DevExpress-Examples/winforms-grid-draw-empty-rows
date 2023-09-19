Namespace CustomGrid

    Public Class MyBandedGridView
        Inherits DevExpress.XtraGrid.Views.BandedGrid.BandedGridView

        Public Sub New()
            Me.New(Nothing)
        End Sub

        Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
            MyBase.New(grid)
        End Sub

        Protected Overrides ReadOnly Property ViewName As String
            Get
                Return "MyBandedGridView"
            End Get
        End Property
    End Class
End Namespace
