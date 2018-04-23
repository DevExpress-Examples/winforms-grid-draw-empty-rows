using System;

namespace CustomGrid {
	public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {
		public MyGridView() : this(null) {}
		public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) {}
		protected override string ViewName { get { return "MyGridView"; } }
	}
}
