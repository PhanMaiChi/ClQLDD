namespace KPBT.Forms.DanhMuc
{
    partial class frmDMPhongBan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMPhongBan));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtTroGiup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtThoat = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grcKQ = new DevExpress.XtraGrid.GridControl();
            this.grvKQ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidsophong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colttkhac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnhatre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoptren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grBDMPB = new System.Windows.Forms.GroupBox();
            this.txttenlopcu = new DevExpress.XtraEditors.TextEdit();
            this.cboLoptren = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbonhatre = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtidsophong = new DevExpress.XtraEditors.TextEdit();
            this.txtttkhac = new DevExpress.XtraEditors.TextEdit();
            this.txttenphong = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).BeginInit();
            this.grBDMPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttenlopcu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoptren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbonhatre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtidsophong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtttkhac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenphong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.toolStrip2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btThem,
            this.toolStripSeparator1,
            this.tbtXoa,
            this.toolStripSeparator2,
            this.tbtIn,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.tbtTroGiup,
            this.toolStripSeparator4,
            this.tbtThoat,
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(866, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(79, 22);
            this.btThem.Text = "Thêm mới";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtXoa
            // 
            this.tbtXoa.Image = ((System.Drawing.Image)(resources.GetObject("tbtXoa.Image")));
            this.tbtXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtXoa.Name = "tbtXoa";
            this.tbtXoa.Size = new System.Drawing.Size(49, 22);
            this.tbtXoa.Text = "Xóa";
            this.tbtXoa.Click += new System.EventHandler(this.tbtXoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtIn
            // 
            this.tbtIn.Image = ((System.Drawing.Image)(resources.GetObject("tbtIn.Image")));
            this.tbtIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtIn.Name = "tbtIn";
            this.tbtIn.Size = new System.Drawing.Size(38, 22);
            this.tbtIn.Text = "In";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(118, 22);
            this.toolStripButton1.Text = "Chuyển học sinh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtTroGiup
            // 
            this.tbtTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("tbtTroGiup.Image")));
            this.tbtTroGiup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtTroGiup.Name = "tbtTroGiup";
            this.tbtTroGiup.Size = new System.Drawing.Size(69, 22);
            this.tbtTroGiup.Text = "Giúp đỡ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtThoat
            // 
            this.tbtThoat.Image = ((System.Drawing.Image)(resources.GetObject("tbtThoat.Image")));
            this.tbtThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtThoat.Name = "tbtThoat";
            this.tbtThoat.Size = new System.Drawing.Size(59, 22);
            this.tbtThoat.Text = "Thoát";
            this.tbtThoat.Click += new System.EventHandler(this.tbtThoat_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(134, 22);
            this.toolStripLabel1.Text = "         {Ấn F1 để thêm mới}";
            // 
            // grcKQ
            // 
            this.grcKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKQ.Location = new System.Drawing.Point(0, 25);
            this.grcKQ.MainView = this.grvKQ;
            this.grcKQ.Name = "grcKQ";
            this.grcKQ.Size = new System.Drawing.Size(866, 415);
            this.grcKQ.TabIndex = 6;
            this.grcKQ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKQ});
            // 
            // grvKQ
            // 
            this.grvKQ.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvKQ.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKQ.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvKQ.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvKQ.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvKQ.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grvKQ.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grvKQ.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grvKQ.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKQ.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvKQ.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvKQ.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvKQ.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grvKQ.Appearance.Empty.Options.UseBackColor = true;
            this.grvKQ.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvKQ.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvKQ.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvKQ.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKQ.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvKQ.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvKQ.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvKQ.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grvKQ.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grvKQ.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvKQ.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvKQ.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grvKQ.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvKQ.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvKQ.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvKQ.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvKQ.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grvKQ.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvKQ.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvKQ.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvKQ.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvKQ.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKQ.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvKQ.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvKQ.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvKQ.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKQ.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKQ.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvKQ.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvKQ.Appearance.GroupButton.Options.UseForeColor = true;
            this.grvKQ.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKQ.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKQ.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvKQ.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvKQ.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvKQ.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grvKQ.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvKQ.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvKQ.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKQ.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKQ.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grvKQ.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvKQ.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvKQ.Appearance.GroupRow.Options.UseFont = true;
            this.grvKQ.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvKQ.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvKQ.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKQ.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKQ.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvKQ.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvKQ.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvKQ.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grvKQ.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grvKQ.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvKQ.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvKQ.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grvKQ.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvKQ.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grvKQ.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.OddRow.Options.UseBackColor = true;
            this.grvKQ.Appearance.OddRow.Options.UseForeColor = true;
            this.grvKQ.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grvKQ.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grvKQ.Appearance.Preview.Options.UseBackColor = true;
            this.grvKQ.Appearance.Preview.Options.UseForeColor = true;
            this.grvKQ.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grvKQ.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvKQ.Appearance.Row.Options.UseBackColor = true;
            this.grvKQ.Appearance.Row.Options.UseForeColor = true;
            this.grvKQ.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grvKQ.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvKQ.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grvKQ.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grvKQ.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvKQ.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvKQ.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grvKQ.Appearance.VertLine.Options.UseBackColor = true;
            this.grvKQ.ColumnPanelRowHeight = 40;
            this.grvKQ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colidsophong,
            this.coltenphong,
            this.colttkhac,
            this.colTT,
            this.colnhatre,
            this.colLoptren});
            this.grvKQ.GridControl = this.grcKQ;
            this.grvKQ.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaChuong", null, "")});
            this.grvKQ.Name = "grvKQ";
            this.grvKQ.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvKQ.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.grvKQ.OptionsBehavior.ReadOnly = true;
            this.grvKQ.OptionsView.EnableAppearanceEvenRow = true;
            this.grvKQ.OptionsView.EnableAppearanceOddRow = true;
            this.grvKQ.OptionsView.ShowFooter = true;
            this.grvKQ.OptionsView.ShowGroupPanel = false;
            this.grvKQ.DoubleClick += new System.EventHandler(this.grvKQ_DoubleClick);
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.AppearanceCell.Options.UseTextOptions = true;
            this.colSTT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSTT.AppearanceHeader.Options.UseFont = true;
            this.colSTT.AppearanceHeader.Options.UseTextOptions = true;
            this.colSTT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSTT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.AllowEdit = false;
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.OptionsColumn.TabStop = false;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 40;
            // 
            // colidsophong
            // 
            this.colidsophong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colidsophong.AppearanceCell.Options.UseFont = true;
            this.colidsophong.AppearanceCell.Options.UseTextOptions = true;
            this.colidsophong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidsophong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colidsophong.AppearanceHeader.Options.UseFont = true;
            this.colidsophong.AppearanceHeader.Options.UseTextOptions = true;
            this.colidsophong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidsophong.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colidsophong.Caption = "Số lớp";
            this.colidsophong.FieldName = "idsophong";
            this.colidsophong.MaxWidth = 100;
            this.colidsophong.Name = "colidsophong";
            this.colidsophong.OptionsColumn.AllowEdit = false;
            this.colidsophong.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colidsophong.OptionsColumn.ReadOnly = true;
            this.colidsophong.OptionsFilter.AllowFilter = false;
            this.colidsophong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaChuong", "Số bản ghi: {0:n0}")});
            this.colidsophong.Width = 81;
            // 
            // coltenphong
            // 
            this.coltenphong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coltenphong.AppearanceCell.Options.UseFont = true;
            this.coltenphong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltenphong.AppearanceHeader.Options.UseFont = true;
            this.coltenphong.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenphong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenphong.Caption = "Tên lớp";
            this.coltenphong.FieldName = "tenphong";
            this.coltenphong.Name = "coltenphong";
            this.coltenphong.OptionsColumn.AllowEdit = false;
            this.coltenphong.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coltenphong.OptionsColumn.ReadOnly = true;
            this.coltenphong.OptionsFilter.AllowFilter = false;
            this.coltenphong.Visible = true;
            this.coltenphong.VisibleIndex = 1;
            this.coltenphong.Width = 449;
            // 
            // colttkhac
            // 
            this.colttkhac.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colttkhac.AppearanceCell.Options.UseFont = true;
            this.colttkhac.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colttkhac.AppearanceHeader.Options.UseFont = true;
            this.colttkhac.AppearanceHeader.Options.UseTextOptions = true;
            this.colttkhac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colttkhac.Caption = "Ghi chú";
            this.colttkhac.FieldName = "ttkhac";
            this.colttkhac.Name = "colttkhac";
            this.colttkhac.OptionsColumn.AllowEdit = false;
            this.colttkhac.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colttkhac.OptionsColumn.ReadOnly = true;
            this.colttkhac.OptionsFilter.AllowFilter = false;
            this.colttkhac.Visible = true;
            this.colttkhac.VisibleIndex = 3;
            this.colttkhac.Width = 158;
            // 
            // colTT
            // 
            this.colTT.FieldName = "TT";
            this.colTT.Name = "colTT";
            // 
            // colnhatre
            // 
            this.colnhatre.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colnhatre.AppearanceCell.Options.UseFont = true;
            this.colnhatre.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colnhatre.AppearanceHeader.Options.UseFont = true;
            this.colnhatre.AppearanceHeader.Options.UseTextOptions = true;
            this.colnhatre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnhatre.Caption = "Nhà trẻ/ Mẫu giáo";
            this.colnhatre.FieldName = "nhatre";
            this.colnhatre.Name = "colnhatre";
            this.colnhatre.OptionsColumn.AllowEdit = false;
            this.colnhatre.Visible = true;
            this.colnhatre.VisibleIndex = 2;
            this.colnhatre.Width = 120;
            // 
            // colLoptren
            // 
            this.colLoptren.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLoptren.AppearanceCell.Options.UseFont = true;
            this.colLoptren.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLoptren.AppearanceHeader.Options.UseFont = true;
            this.colLoptren.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoptren.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoptren.Caption = "Lớp trên";
            this.colLoptren.FieldName = "loptren";
            this.colLoptren.Name = "colLoptren";
            this.colLoptren.OptionsColumn.AllowEdit = false;
            this.colLoptren.Visible = true;
            this.colLoptren.VisibleIndex = 4;
            // 
            // grBDMPB
            // 
            this.grBDMPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grBDMPB.CausesValidation = false;
            this.grBDMPB.Controls.Add(this.txttenlopcu);
            this.grBDMPB.Controls.Add(this.cboLoptren);
            this.grBDMPB.Controls.Add(this.labelX3);
            this.grBDMPB.Controls.Add(this.cbonhatre);
            this.grBDMPB.Controls.Add(this.labelX1);
            this.grBDMPB.Controls.Add(this.txtidsophong);
            this.grBDMPB.Controls.Add(this.txtttkhac);
            this.grBDMPB.Controls.Add(this.txttenphong);
            this.grBDMPB.Controls.Add(this.button2);
            this.grBDMPB.Controls.Add(this.button1);
            this.grBDMPB.Controls.Add(this.labelX4);
            this.grBDMPB.Controls.Add(this.labelX2);
            this.grBDMPB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBDMPB.Location = new System.Drawing.Point(176, 140);
            this.grBDMPB.Name = "grBDMPB";
            this.grBDMPB.Size = new System.Drawing.Size(515, 181);
            this.grBDMPB.TabIndex = 240;
            this.grBDMPB.TabStop = false;
            this.grBDMPB.Visible = false;
            // 
            // txttenlopcu
            // 
            this.txttenlopcu.Location = new System.Drawing.Point(423, 141);
            this.txttenlopcu.Name = "txttenlopcu";
            this.txttenlopcu.Size = new System.Drawing.Size(22, 20);
            this.txttenlopcu.TabIndex = 256;
            this.txttenlopcu.Visible = false;
            // 
            // cboLoptren
            // 
            this.cboLoptren.Location = new System.Drawing.Point(130, 98);
            this.cboLoptren.Name = "cboLoptren";
            this.cboLoptren.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoptren.Properties.Appearance.Options.UseFont = true;
            this.cboLoptren.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoptren.Size = new System.Drawing.Size(366, 22);
            this.cboLoptren.TabIndex = 3;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(24, 98);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 20);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX3.TabIndex = 255;
            this.labelX3.Text = "Lớp trên:";
            // 
            // cbonhatre
            // 
            this.cbonhatre.Location = new System.Drawing.Point(130, 46);
            this.cbonhatre.Name = "cbonhatre";
            this.cbonhatre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbonhatre.Properties.Appearance.Options.UseFont = true;
            this.cbonhatre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbonhatre.Properties.Items.AddRange(new object[] {
            "Nhà trẻ",
            "Mẫu giáo"});
            this.cbonhatre.Size = new System.Drawing.Size(366, 22);
            this.cbonhatre.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(24, 72);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 20);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX1.TabIndex = 253;
            this.labelX1.Text = "Ghi chú:";
            // 
            // txtidsophong
            // 
            this.txtidsophong.Location = new System.Drawing.Point(233, 138);
            this.txtidsophong.Name = "txtidsophong";
            this.txtidsophong.Size = new System.Drawing.Size(22, 20);
            this.txtidsophong.TabIndex = 252;
            this.txtidsophong.Visible = false;
            // 
            // txtttkhac
            // 
            this.txtttkhac.Location = new System.Drawing.Point(130, 71);
            this.txtttkhac.Name = "txtttkhac";
            this.txtttkhac.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtttkhac.Properties.Appearance.Options.UseFont = true;
            this.txtttkhac.Size = new System.Drawing.Size(366, 22);
            this.txtttkhac.TabIndex = 2;
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(130, 21);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenphong.Properties.Appearance.Options.UseFont = true;
            this.txttenphong.Size = new System.Drawing.Size(366, 22);
            this.txttenphong.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(304, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Không lưu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(124, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Cập nhật";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(24, 46);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 20);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX4.TabIndex = 248;
            this.labelX4.Text = "Nhà trẻ/ Mẫu giáo:";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(24, 19);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 20);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX2.TabIndex = 244;
            this.labelX2.Text = "Tên lớp:";
            // 
            // frmDMPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 440);
            this.ControlBox = false;
            this.Controls.Add(this.grBDMPB);
            this.Controls.Add(this.grcKQ);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDMPhongBan";
            this.ShowInTaskbar = false;
            this.Text = "Danh mục lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDMPhongBan_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).EndInit();
            this.grBDMPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txttenlopcu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoptren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbonhatre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtidsophong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtttkhac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenphong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbtThoat;
        private DevExpress.XtraGrid.GridControl grcKQ;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colidsophong;
        private DevExpress.XtraGrid.Columns.GridColumn coltenphong;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btThem;
        private DevExpress.XtraGrid.Columns.GridColumn colttkhac;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
        private System.Windows.Forms.GroupBox grBDMPB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevExpress.XtraEditors.TextEdit txtidsophong;
        private DevExpress.XtraEditors.TextEdit txtttkhac;
        private DevExpress.XtraEditors.TextEdit txttenphong;
        private DevExpress.XtraEditors.ComboBoxEdit cbonhatre;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraGrid.Columns.GridColumn colnhatre;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoptren;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevExpress.XtraGrid.Columns.GridColumn colLoptren;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tbtTroGiup;
        private DevExpress.XtraEditors.TextEdit txttenlopcu;
    }
}