Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports CustomGrid
Imports DevExpress.XtraEditors

Namespace EmptyAreaGridLines
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form

		Private myGridControl1 As MyGridControl
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private myGridView1 As CustomGrid.MyGridView
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
			Me.myGridControl1 = New CustomGrid.MyGridControl()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.myGridView1 = New CustomGrid.MyGridView()
			Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.dataSet1 = New System.Data.DataSet()
			DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myGridControl1
			' 
			Me.myGridControl1.DataSource = Me.dataTable1
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myGridControl1.MainView = Me.myGridView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(536, 336)
			Me.myGridControl1.TabIndex = 0
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Column2"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Column3"
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "Column4"
			' 
			' myGridView1
			' 
			Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colColumn1, Me.colColumn2, Me.colColumn3, Me.colColumn4})
			Me.myGridView1.GridControl = Me.myGridControl1
			Me.myGridView1.Name = "myGridView1"
			Me.myGridView1.OptionsView.ShowFooter = True
			' 
			' colColumn1
			' 
			Me.colColumn1.Caption = "Column1"
			Me.colColumn1.FieldName = "Column1"
			Me.colColumn1.Name = "colColumn1"
			Me.colColumn1.Visible = True
			Me.colColumn1.VisibleIndex = 0
			' 
			' colColumn2
			' 
			Me.colColumn2.Caption = "Column2"
			Me.colColumn2.FieldName = "Column2"
			Me.colColumn2.Name = "colColumn2"
			Me.colColumn2.Visible = True
			Me.colColumn2.VisibleIndex = 1
			' 
			' colColumn3
			' 
			Me.colColumn3.Caption = "Column3"
			Me.colColumn3.FieldName = "Column3"
			Me.colColumn3.Name = "colColumn3"
			Me.colColumn3.Visible = True
			Me.colColumn3.VisibleIndex = 2
			Me.colColumn3.Width = 206
			' 
			' colColumn4
			' 
			Me.colColumn4.Caption = "Column4"
			Me.colColumn4.FieldName = "Column4"
			Me.colColumn4.Name = "colColumn4"
			Me.colColumn4.Visible = True
			Me.colColumn4.VisibleIndex = 3
			Me.colColumn4.Width = 206
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(536, 336)
			Me.Controls.Add(Me.myGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
			dataTable1.Rows.Add(New Object() { 1, 2, 3, 4 })
		End Sub
	End Class
End Namespace
