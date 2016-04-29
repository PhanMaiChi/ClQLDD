namespace KPBT.Forms.DanhMuc
{
    partial class frmDMTCSK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMTCSK));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtTroGiup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtThoat = new System.Windows.Forms.ToolStripButton();
            this.grcKQ = new DevExpress.XtraGrid.GridControl();
            this.grvKQ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colplgt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboGioiTinh = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colthangtuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannangsdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliddmtcsk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannangnguycosddtu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannangnguycosddden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannangbinhthuongtu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannangbinhthuongden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannangnguycobptu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannangnguycobpden = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannangbeophi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh)).BeginInit();
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
            this.tbtTroGiup,
            this.toolStripSeparator4,
            this.tbtThoat});
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
            this.btThem.Size = new System.Drawing.Size(48, 22);
            this.btThem.Text = "Lưu";
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
            this.tbtIn.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
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
            // grcKQ
            // 
            this.grcKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcKQ.Location = new System.Drawing.Point(0, 25);
            this.grcKQ.MainView = this.grvKQ;
            this.grcKQ.Name = "grcKQ";
            this.grcKQ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboGioiTinh});
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
            this.colplgt,
            this.colthangtuoi,
            this.colcannangsdd,
            this.coliddmtcsk,
            this.colcannangnguycosddtu,
            this.colcannangnguycosddden,
            this.colcannangbinhthuongtu,
            this.colcannangbinhthuongden,
            this.colcannangnguycobptu,
            this.colcannangnguycobpden,
            this.colcannangbeophi,
            this.colTT});
            this.grvKQ.GridControl = this.grcKQ;
            this.grvKQ.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaChuong", null, "")});
            this.grvKQ.Name = "grvKQ";
            this.grvKQ.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.grvKQ.OptionsView.ColumnAutoWidth = false;
            this.grvKQ.OptionsView.EnableAppearanceEvenRow = true;
            this.grvKQ.OptionsView.EnableAppearanceOddRow = true;
            this.grvKQ.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvKQ.OptionsView.ShowFooter = true;
            this.grvKQ.OptionsView.ShowGroupPanel = false;
            this.grvKQ.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvKQ_InitNewRow);
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
            this.colSTT.MaxWidth = 60;
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.OptionsColumn.TabStop = false;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 55;
            // 
            // colplgt
            // 
            this.colplgt.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colplgt.AppearanceCell.Options.UseFont = true;
            this.colplgt.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colplgt.AppearanceHeader.Options.UseFont = true;
            this.colplgt.AppearanceHeader.Options.UseTextOptions = true;
            this.colplgt.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colplgt.Caption = "Giới tính";
            this.colplgt.ColumnEdit = this.cboGioiTinh;
            this.colplgt.FieldName = "plgt";
            this.colplgt.MaxWidth = 80;
            this.colplgt.Name = "colplgt";
            this.colplgt.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colplgt.OptionsFilter.AllowFilter = false;
            this.colplgt.Visible = true;
            this.colplgt.VisibleIndex = 1;
            this.colplgt.Width = 60;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.AutoHeight = false;
            this.cboGioiTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Name = "cboGioiTinh";
            // 
            // colthangtuoi
            // 
            this.colthangtuoi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colthangtuoi.AppearanceCell.Options.UseFont = true;
            this.colthangtuoi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colthangtuoi.AppearanceHeader.Options.UseFont = true;
            this.colthangtuoi.AppearanceHeader.Options.UseTextOptions = true;
            this.colthangtuoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthangtuoi.Caption = "Tháng tuổi";
            this.colthangtuoi.FieldName = "thangtuoi";
            this.colthangtuoi.Name = "colthangtuoi";
            this.colthangtuoi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colthangtuoi.OptionsFilter.AllowFilter = false;
            this.colthangtuoi.Visible = true;
            this.colthangtuoi.VisibleIndex = 2;
            // 
            // colcannangsdd
            // 
            this.colcannangsdd.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcannangsdd.AppearanceCell.Options.UseFont = true;
            this.colcannangsdd.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcannangsdd.AppearanceHeader.Options.UseFont = true;
            this.colcannangsdd.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannangsdd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannangsdd.Caption = "Cân nặng suy DD";
            this.colcannangsdd.FieldName = "cannangsdd";
            this.colcannangsdd.MaxWidth = 200;
            this.colcannangsdd.Name = "colcannangsdd";
            this.colcannangsdd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colcannangsdd.OptionsFilter.AllowFilter = false;
            this.colcannangsdd.Visible = true;
            this.colcannangsdd.VisibleIndex = 3;
            this.colcannangsdd.Width = 120;
            // 
            // coliddmtcsk
            // 
            this.coliddmtcsk.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coliddmtcsk.AppearanceCell.Options.UseFont = true;
            this.coliddmtcsk.AppearanceCell.Options.UseTextOptions = true;
            this.coliddmtcsk.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coliddmtcsk.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coliddmtcsk.AppearanceHeader.Options.UseFont = true;
            this.coliddmtcsk.AppearanceHeader.Options.UseTextOptions = true;
            this.coliddmtcsk.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coliddmtcsk.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coliddmtcsk.Caption = "ID";
            this.coliddmtcsk.FieldName = "iddmtcsk";
            this.coliddmtcsk.MaxWidth = 100;
            this.coliddmtcsk.Name = "coliddmtcsk";
            this.coliddmtcsk.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coliddmtcsk.OptionsFilter.AllowFilter = false;
            this.coliddmtcsk.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaChuong", "Số bản ghi: {0:n0}")});
            this.coliddmtcsk.Width = 92;
            // 
            // colcannangnguycosddtu
            // 
            this.colcannangnguycosddtu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangnguycosddtu.AppearanceCell.Options.UseFont = true;
            this.colcannangnguycosddtu.AppearanceCell.Options.UseTextOptions = true;
            this.colcannangnguycosddtu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colcannangnguycosddtu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangnguycosddtu.AppearanceHeader.Options.UseFont = true;
            this.colcannangnguycosddtu.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannangnguycosddtu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannangnguycosddtu.Caption = "Cân nặng suy DD từ";
            this.colcannangnguycosddtu.FieldName = "cannangnguycosddtu";
            this.colcannangnguycosddtu.Name = "colcannangnguycosddtu";
            this.colcannangnguycosddtu.Visible = true;
            this.colcannangnguycosddtu.VisibleIndex = 4;
            this.colcannangnguycosddtu.Width = 120;
            // 
            // colcannangnguycosddden
            // 
            this.colcannangnguycosddden.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangnguycosddden.AppearanceCell.Options.UseFont = true;
            this.colcannangnguycosddden.AppearanceCell.Options.UseTextOptions = true;
            this.colcannangnguycosddden.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colcannangnguycosddden.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangnguycosddden.AppearanceHeader.Options.UseFont = true;
            this.colcannangnguycosddden.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannangnguycosddden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannangnguycosddden.Caption = "Cân nặng suy DD đến";
            this.colcannangnguycosddden.FieldName = "cannangnguycosddden";
            this.colcannangnguycosddden.Name = "colcannangnguycosddden";
            this.colcannangnguycosddden.Visible = true;
            this.colcannangnguycosddden.VisibleIndex = 5;
            this.colcannangnguycosddden.Width = 125;
            // 
            // colcannangbinhthuongtu
            // 
            this.colcannangbinhthuongtu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangbinhthuongtu.AppearanceCell.Options.UseFont = true;
            this.colcannangbinhthuongtu.AppearanceCell.Options.UseTextOptions = true;
            this.colcannangbinhthuongtu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colcannangbinhthuongtu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangbinhthuongtu.AppearanceHeader.Options.UseFont = true;
            this.colcannangbinhthuongtu.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannangbinhthuongtu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannangbinhthuongtu.Caption = "Cân nặng BT từ";
            this.colcannangbinhthuongtu.FieldName = "cannangbinhthuongtu";
            this.colcannangbinhthuongtu.Name = "colcannangbinhthuongtu";
            this.colcannangbinhthuongtu.Visible = true;
            this.colcannangbinhthuongtu.VisibleIndex = 6;
            this.colcannangbinhthuongtu.Width = 120;
            // 
            // colcannangbinhthuongden
            // 
            this.colcannangbinhthuongden.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangbinhthuongden.AppearanceCell.Options.UseFont = true;
            this.colcannangbinhthuongden.AppearanceCell.Options.UseTextOptions = true;
            this.colcannangbinhthuongden.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colcannangbinhthuongden.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangbinhthuongden.AppearanceHeader.Options.UseFont = true;
            this.colcannangbinhthuongden.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannangbinhthuongden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannangbinhthuongden.Caption = "Cân nặng BT đến";
            this.colcannangbinhthuongden.FieldName = "cannangbinhthuongden";
            this.colcannangbinhthuongden.Name = "colcannangbinhthuongden";
            this.colcannangbinhthuongden.Visible = true;
            this.colcannangbinhthuongden.VisibleIndex = 7;
            this.colcannangbinhthuongden.Width = 110;
            // 
            // colcannangnguycobptu
            // 
            this.colcannangnguycobptu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangnguycobptu.AppearanceCell.Options.UseFont = true;
            this.colcannangnguycobptu.AppearanceCell.Options.UseTextOptions = true;
            this.colcannangnguycobptu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colcannangnguycobptu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangnguycobptu.AppearanceHeader.Options.UseFont = true;
            this.colcannangnguycobptu.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannangnguycobptu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannangnguycobptu.Caption = "Cân nặng BP từ";
            this.colcannangnguycobptu.FieldName = "cannangnguycobptu";
            this.colcannangnguycobptu.Name = "colcannangnguycobptu";
            this.colcannangnguycobptu.Visible = true;
            this.colcannangnguycobptu.VisibleIndex = 8;
            this.colcannangnguycobptu.Width = 120;
            // 
            // colcannangnguycobpden
            // 
            this.colcannangnguycobpden.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangnguycobpden.AppearanceCell.Options.UseFont = true;
            this.colcannangnguycobpden.AppearanceCell.Options.UseTextOptions = true;
            this.colcannangnguycobpden.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colcannangnguycobpden.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangnguycobpden.AppearanceHeader.Options.UseFont = true;
            this.colcannangnguycobpden.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannangnguycobpden.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannangnguycobpden.Caption = "Cân nặng BP đến";
            this.colcannangnguycobpden.FieldName = "cannangnguycobpden";
            this.colcannangnguycobpden.Name = "colcannangnguycobpden";
            this.colcannangnguycobpden.Visible = true;
            this.colcannangnguycobpden.VisibleIndex = 9;
            this.colcannangnguycobpden.Width = 125;
            // 
            // colcannangbeophi
            // 
            this.colcannangbeophi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangbeophi.AppearanceCell.Options.UseFont = true;
            this.colcannangbeophi.AppearanceCell.Options.UseTextOptions = true;
            this.colcannangbeophi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colcannangbeophi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannangbeophi.AppearanceHeader.Options.UseFont = true;
            this.colcannangbeophi.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannangbeophi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannangbeophi.Caption = "Cân nặng BP";
            this.colcannangbeophi.FieldName = "cannangbeophi";
            this.colcannangbeophi.Name = "colcannangbeophi";
            this.colcannangbeophi.Visible = true;
            this.colcannangbeophi.VisibleIndex = 10;
            this.colcannangbeophi.Width = 120;
            // 
            // colTT
            // 
            this.colTT.Caption = "gridColumn1";
            this.colTT.FieldName = "TT";
            this.colTT.Name = "colTT";
            // 
            // frmDMTCSK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 440);
            this.ControlBox = false;
            this.Controls.Add(this.grcKQ);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDMTCSK";
            this.ShowInTaskbar = false;
            this.Text = "DANH MỤC TIÊU CHUẨN SỨC KHỎE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDMCanBo_FormClosed);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh)).EndInit();
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
        private System.Windows.Forms.ToolStripButton tbtTroGiup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbtThoat;
        private DevExpress.XtraGrid.GridControl grcKQ;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn coliddmtcsk;
        private System.Windows.Forms.ToolStripButton btThem;
        private DevExpress.XtraGrid.Columns.GridColumn colthangtuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colplgt;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colcannangnguycosddtu;
        private DevExpress.XtraGrid.Columns.GridColumn colcannangnguycosddden;
        private DevExpress.XtraGrid.Columns.GridColumn colcannangbinhthuongtu;
        private DevExpress.XtraGrid.Columns.GridColumn colcannangbinhthuongden;
        private DevExpress.XtraGrid.Columns.GridColumn colcannangnguycobptu;
        private DevExpress.XtraGrid.Columns.GridColumn colcannangnguycobpden;
        private DevExpress.XtraGrid.Columns.GridColumn colcannangbeophi;
        private DevExpress.XtraGrid.Columns.GridColumn colcannangsdd;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
    }
}