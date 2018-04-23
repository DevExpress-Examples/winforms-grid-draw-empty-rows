using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CustomGrid;

namespace EmptyAreaGridLines
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private MyGridControl myGridControl1;
		private System.Data.DataSet dataSet1;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
        private CustomGrid.MyGridView myGridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colColumn4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.myGridControl1 = new CustomGrid.MyGridControl();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.myGridView1 = new CustomGrid.MyGridView();
            this.colColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridControl1
            // 
            this.myGridControl1.DataSource = this.dataTable1;
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.EmbeddedNavigator.Name = "";
            this.myGridControl1.Location = new System.Drawing.Point(0, 0);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(536, 336);
            this.myGridControl1.TabIndex = 0;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Column2";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Column3";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Column4";
            // 
            // myGridView1
            // 
            this.myGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colColumn1,
            this.colColumn2,
            this.colColumn3,
            this.colColumn4});
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.OptionsView.ShowFooter = true;
            // 
            // colColumn1
            // 
            this.colColumn1.Caption = "Column1";
            this.colColumn1.FieldName = "Column1";
            this.colColumn1.Name = "colColumn1";
            this.colColumn1.Visible = true;
            this.colColumn1.VisibleIndex = 0;
            // 
            // colColumn2
            // 
            this.colColumn2.Caption = "Column2";
            this.colColumn2.FieldName = "Column2";
            this.colColumn2.Name = "colColumn2";
            this.colColumn2.Visible = true;
            this.colColumn2.VisibleIndex = 1;
            // 
            // colColumn3
            // 
            this.colColumn3.Caption = "Column3";
            this.colColumn3.FieldName = "Column3";
            this.colColumn3.Name = "colColumn3";
            this.colColumn3.Visible = true;
            this.colColumn3.VisibleIndex = 2;
            this.colColumn3.Width = 206;
            // 
            // colColumn4
            // 
            this.colColumn4.Caption = "Column4";
            this.colColumn4.FieldName = "Column4";
            this.colColumn4.Name = "colColumn4";
            this.colColumn4.Visible = true;
            this.colColumn4.VisibleIndex = 3;
            this.colColumn4.Width = 206;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(536, 336);
            this.Controls.Add(this.myGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e) {
            dataTable1.Rows.Add(new object[] { 1, 2, 3, 4 });
		}
	}
}
