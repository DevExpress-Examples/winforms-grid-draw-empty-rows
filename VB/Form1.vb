Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports CustomGrid

Namespace EmptyAreaGridLines

    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1
        Inherits Form

        Private myGridControl1 As MyGridControl

        Private dataSet1 As DataSet

        Private dataTable1 As DataTable

        Private dataColumn1 As DataColumn

        Private dataColumn2 As DataColumn

        Private dataColumn3 As DataColumn

        Private dataColumn4 As DataColumn

        Private myGridView1 As MyGridView

        Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private colColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private colColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            myGridControl1 = New MyGridControl()
            dataTable1 = New DataTable()
            dataColumn1 = New DataColumn()
            dataColumn2 = New DataColumn()
            dataColumn3 = New DataColumn()
            dataColumn4 = New DataColumn()
            myGridView1 = New MyGridView()
            colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            colColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            colColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            colColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            dataSet1 = New DataSet()
            CType(myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myGridControl1
            ' 
            myGridControl1.DataSource = dataTable1
            myGridControl1.Dock = DockStyle.Fill
            myGridControl1.EmbeddedNavigator.Name = ""
            myGridControl1.Location = New System.Drawing.Point(0, 0)
            myGridControl1.MainView = myGridView1
            myGridControl1.Name = "myGridControl1"
            myGridControl1.Size = New System.Drawing.Size(536, 336)
            myGridControl1.TabIndex = 0
            myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {myGridView1})
            ' 
            ' dataTable1
            ' 
            dataTable1.Columns.AddRange(New DataColumn() {dataColumn1, dataColumn2, dataColumn3, dataColumn4})
            dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            dataColumn1.ColumnName = "Column1"
            ' 
            ' dataColumn2
            ' 
            dataColumn2.ColumnName = "Column2"
            ' 
            ' dataColumn3
            ' 
            dataColumn3.ColumnName = "Column3"
            ' 
            ' dataColumn4
            ' 
            dataColumn4.ColumnName = "Column4"
            ' 
            ' myGridView1
            ' 
            myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {colColumn1, colColumn2, colColumn3, colColumn4})
            myGridView1.GridControl = myGridControl1
            myGridView1.Name = "myGridView1"
            myGridView1.OptionsView.ShowFooter = True
            ' 
            ' colColumn1
            ' 
            colColumn1.Caption = "Column1"
            colColumn1.FieldName = "Column1"
            colColumn1.Name = "colColumn1"
            colColumn1.Visible = True
            colColumn1.VisibleIndex = 0
            ' 
            ' colColumn2
            ' 
            colColumn2.Caption = "Column2"
            colColumn2.FieldName = "Column2"
            colColumn2.Name = "colColumn2"
            colColumn2.Visible = True
            colColumn2.VisibleIndex = 1
            ' 
            ' colColumn3
            ' 
            colColumn3.Caption = "Column3"
            colColumn3.FieldName = "Column3"
            colColumn3.Name = "colColumn3"
            colColumn3.Visible = True
            colColumn3.VisibleIndex = 2
            colColumn3.Width = 206
            ' 
            ' colColumn4
            ' 
            colColumn4.Caption = "Column4"
            colColumn4.FieldName = "Column4"
            colColumn4.Name = "colColumn4"
            colColumn4.Visible = True
            colColumn4.VisibleIndex = 3
            colColumn4.Width = 206
            ' 
            ' dataSet1
            ' 
            dataSet1.DataSetName = "NewDataSet"
            dataSet1.Locale = New Globalization.CultureInfo("en-US")
            dataSet1.Tables.AddRange(New DataTable() {dataTable1})
            ' 
            ' Form1
            ' 
            AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            ClientSize = New System.Drawing.Size(536, 336)
            Me.Controls.Add(myGridControl1)
            Name = "Form1"
            Text = "Form1"
            AddHandler Load, New EventHandler(AddressOf Form1_Load)
            CType(myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            Call Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            dataTable1.Rows.Add(New Object() {1, 2, 3, 4})
        End Sub
    End Class
End Namespace
