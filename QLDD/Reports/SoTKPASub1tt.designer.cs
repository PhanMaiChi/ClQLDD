namespace KPBT.Reports
{
    partial class SoTKPASub1tt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.SL24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Thangnam = new DevExpress.XtraReports.Parameters.Parameter();
            this.TenDV = new DevExpress.XtraReports.Parameters.Parameter();
            this.Namhoc = new DevExpress.XtraReports.Parameters.Parameter();
            this.DiaDanh = new DevExpress.XtraReports.Parameters.Parameter();
            this.NTN = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.HTTP = new DevExpress.XtraReports.Parameters.Parameter();
            this.HTGVND = new DevExpress.XtraReports.Parameters.Parameter();
            this.LoaiTP = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsTblDC1 = new KPBT.Dataset.dsTblDC();
            this.LTP = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTblDC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
            this.Detail.HeightF = 19.45F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTable4.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable4.SizeF = new System.Drawing.SizeF(755F, 19.45F);
            this.xrTable4.StylePriority.UseBorders = false;
            this.xrTable4.StylePriority.UseFont = false;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell31,
            this.SL13,
            this.SL14,
            this.SL15,
            this.SL16,
            this.SL17,
            this.xrTableCell37,
            this.xrTableCell38,
            this.SL20,
            this.SL21,
            this.SL22,
            this.SL23,
            this.SL24});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.StylePriority.UseTextAlignment = false;
            this.xrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow9.Weight = 1.0416663719358548;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TblDC.SL11", "{0:#,#}")});
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBorders = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell19.Weight = 0.2479838402040544;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TblDC.SL12", "{0:#,#}")});
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseTextAlignment = false;
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell31.Weight = 0.34879041487170814;
            // 
            // SL13
            // 
            this.SL13.Name = "SL13";
            this.SL13.StylePriority.UseTextAlignment = false;
            this.SL13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SL13.Weight = 0.18749993847262481;
            // 
            // SL14
            // 
            this.SL14.Name = "SL14";
            this.SL14.Weight = 0.18749993847262472;
            // 
            // SL15
            // 
            this.SL15.Name = "SL15";
            this.SL15.Weight = 0.18750006152737531;
            // 
            // SL16
            // 
            this.SL16.Name = "SL16";
            this.SL16.Weight = 0.18346774193548382;
            // 
            // SL17
            // 
            this.SL17.Name = "SL17";
            this.SL17.Weight = 0.18749987694524967;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TblDC.SL18", "{0:#,#}")});
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Weight = 0.24798424013199344;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "TblDC.SL19", "{0:#,#}")});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseTextAlignment = false;
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell38.Weight = 0.34879007647114396;
            // 
            // SL20
            // 
            this.SL20.Name = "SL20";
            this.SL20.StylePriority.UseTextAlignment = false;
            this.SL20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SL20.Weight = 0.187500246109501;
            // 
            // SL21
            // 
            this.SL21.Name = "SL21";
            this.SL21.StylePriority.UseTextAlignment = false;
            this.SL21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SL21.Weight = 0.187499753890499;
            // 
            // SL22
            // 
            this.SL22.Name = "SL22";
            this.SL22.StylePriority.UseTextAlignment = false;
            this.SL22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SL22.Weight = 0.18750000000000003;
            // 
            // SL23
            // 
            this.SL23.Name = "SL23";
            this.SL23.StylePriority.UseTextAlignment = false;
            this.SL23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SL23.Weight = 0.18749975389049903;
            // 
            // SL24
            // 
            this.SL24.Name = "SL24";
            this.SL24.StylePriority.UseTextAlignment = false;
            this.SL24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.SL24.Weight = 0.185484363186744;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 27F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 26.99998F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Thangnam
            // 
            this.Thangnam.Name = "Thangnam";
            this.Thangnam.Visible = false;
            // 
            // TenDV
            // 
            this.TenDV.Name = "TenDV";
            this.TenDV.Visible = false;
            // 
            // Namhoc
            // 
            this.Namhoc.Name = "Namhoc";
            this.Namhoc.Visible = false;
            // 
            // DiaDanh
            // 
            this.DiaDanh.Name = "DiaDanh";
            this.DiaDanh.Visible = false;
            // 
            // NTN
            // 
            this.NTN.Name = "NTN";
            this.NTN.Visible = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // HTTP
            // 
            this.HTTP.Name = "HTTP";
            this.HTTP.Visible = false;
            // 
            // HTGVND
            // 
            this.HTGVND.Name = "HTGVND";
            this.HTGVND.Visible = false;
            // 
            // LoaiTP
            // 
            this.LoaiTP.Name = "LoaiTP";
            this.LoaiTP.Visible = false;
            // 
            // dsTblDC1
            // 
            this.dsTblDC1.DataSetName = "dsTblDC";
            this.dsTblDC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LTP
            // 
            this.LTP.DataMember = "TblDC";
            this.LTP.Expression = "[ID].Count()";
            this.LTP.Name = "LTP";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("NTGS", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // SoTKPASub1tt
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter,
            this.GroupHeader1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.LTP});
            this.DataMember = "TblDC";
            this.DataSource = this.dsTblDC1;
            this.Margins = new System.Drawing.Printing.Margins(58, 8, 27, 27);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.TenDV,
            this.NTN,
            this.LoaiTP,
            this.HTTP,
            this.HTGVND,
            this.DiaDanh,
            this.Namhoc,
            this.Thangnam});
            this.Version = "12.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTblDC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        public DevExpress.XtraReports.Parameters.Parameter TenDV;
        public DevExpress.XtraReports.Parameters.Parameter NTN;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        public DevExpress.XtraReports.Parameters.Parameter LoaiTP;
        public DevExpress.XtraReports.Parameters.Parameter HTTP;
        public DevExpress.XtraReports.Parameters.Parameter HTGVND;
        private KPBT.Dataset.dsTblDC dsTblDC1;
        private DevExpress.XtraReports.UI.CalculatedField LTP;
        public DevExpress.XtraReports.Parameters.Parameter DiaDanh;
        public DevExpress.XtraReports.Parameters.Parameter Namhoc;
        public DevExpress.XtraReports.Parameters.Parameter Thangnam;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell31;
        private DevExpress.XtraReports.UI.XRTableCell SL13;
        private DevExpress.XtraReports.UI.XRTableCell SL14;
        private DevExpress.XtraReports.UI.XRTableCell SL15;
        private DevExpress.XtraReports.UI.XRTableCell SL16;
        private DevExpress.XtraReports.UI.XRTableCell SL17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell37;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell38;
        private DevExpress.XtraReports.UI.XRTableCell SL20;
        private DevExpress.XtraReports.UI.XRTableCell SL24;
        private DevExpress.XtraReports.UI.XRTableCell SL21;
        private DevExpress.XtraReports.UI.XRTableCell SL22;
        private DevExpress.XtraReports.UI.XRTableCell SL23;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;        
    }
}
