using System;

namespace CustomGrid {
	public class MyBandedGridView : DevExpress.XtraGrid.Views.BandedGrid.BandedGridView {
		public MyBandedGridView() : this(null) {}
		public MyBandedGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) {}
		protected override string ViewName { get { return "MyBandedGridView"; } }
	}
}
