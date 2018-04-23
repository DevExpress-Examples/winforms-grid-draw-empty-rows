using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Registrator;

namespace CustomGrid {
	public class MyGridViewInfoRegistrator : GridInfoRegistrator {
		public override string ViewName { get { return "MyGridView"; } }
		public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
		public override BaseViewPainter CreatePainter(BaseView view) { return new MyGridPainter(view as MyGridView); }
	}
	public class MyBandedGridViewInfoRegistrator : BandedGridInfoRegistrator {
		public override string ViewName { get { return "MyBandedGridView"; } }
		public override BaseView CreateView(GridControl grid) { return new MyBandedGridView(grid as GridControl); }
		public override BaseViewPainter CreatePainter(BaseView view) { return new MyBandedGridPainter(view as MyBandedGridView); }
	}
}
