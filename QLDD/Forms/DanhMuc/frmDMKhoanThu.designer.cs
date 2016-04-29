namespace KPBT.Forms.DanhMuc
{
    partial class frmDMKhoanThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMKhoanThu));
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grcKQ = new DevExpress.XtraGrid.GridControl();
            this.grvKQ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coliddmthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenkhoanthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txteSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colmakhthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsotien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtesotien = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.grBDMPB = new System.Windows.Forms.GroupBox();
            this.txtsotien = new DevExpress.XtraEditors.TextEdit();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtiddmthu = new DevExpress.XtraEditors.TextEdit();
            this.txttenkhoanthu = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtmakhthu = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtesotien)).BeginInit();
            this.grBDMPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsotien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtiddmthu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhoanthu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakhthu.Properties)).BeginInit();
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
            this.grcKQ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txteSoLuong,
            this.txtesotien});
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
            this.coliddmthu,
            this.coltenkhoanthu,
            this.colsoluong,
            this.colmakhthu,
            this.colsotien});
            this.grvKQ.GridControl = this.grcKQ;
            this.grvKQ.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaChuong", null, "")});
            this.grvKQ.Name = "grvKQ";
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
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.OptionsColumn.TabStop = false;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 60;
            // 
            // coliddmthu
            // 
            this.coliddmthu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coliddmthu.AppearanceCell.Options.UseFont = true;
            this.coliddmthu.AppearanceCell.Options.UseTextOptions = true;
            this.coliddmthu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coliddmthu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coliddmthu.AppearanceHeader.Options.UseFont = true;
            this.coliddmthu.AppearanceHeader.Options.UseTextOptions = true;
            this.coliddmthu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coliddmthu.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.coliddmthu.Caption = "ID";
            this.coliddmthu.FieldName = "iddmthu";
            this.coliddmthu.MaxWidth = 100;
            this.coliddmthu.Name = "coliddmthu";
            this.coliddmthu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coliddmthu.OptionsFilter.AllowFilter = false;
            this.coliddmthu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaChuong", "Số bản ghi: {0:n0}")});
            this.coliddmthu.Width = 92;
            // 
            // coltenkhoanthu
            // 
            this.coltenkhoanthu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coltenkhoanthu.AppearanceCell.Options.UseFont = true;
            this.coltenkhoanthu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltenkhoanthu.AppearanceHeader.Options.UseFont = true;
            this.coltenkhoanthu.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenkhoanthu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenkhoanthu.Caption = "Tên khoản thu";
            this.coltenkhoanthu.FieldName = "tenkhoanthu";
            this.coltenkhoanthu.MaxWidth = 500;
            this.coltenkhoanthu.Name = "coltenkhoanthu";
            this.coltenkhoanthu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coltenkhoanthu.OptionsFilter.AllowFilter = false;
            this.coltenkhoanthu.Visible = true;
            this.coltenkhoanthu.VisibleIndex = 2;
            this.coltenkhoanthu.Width = 395;
            // 
            // colsoluong
            // 
            this.colsoluong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colsoluong.AppearanceCell.Options.UseFont = true;
            this.colsoluong.AppearanceCell.Options.UseTextOptions = true;
            this.colsoluong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colsoluong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colsoluong.AppearanceHeader.Options.UseFont = true;
            this.colsoluong.AppearanceHeader.Options.UseTextOptions = true;
            this.colsoluong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsoluong.Caption = "Số lượng";
            this.colsoluong.ColumnEdit = this.txteSoLuong;
            this.colsoluong.FieldName = "soluong";
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colsoluong.Visible = true;
            this.colsoluong.VisibleIndex = 3;
            this.colsoluong.Width = 148;
            // 
            // txteSoLuong
            // 
            this.txteSoLuong.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txteSoLuong.AutoHeight = false;
            this.txteSoLuong.DisplayFormat.FormatString = "n0";
            this.txteSoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txteSoLuong.EditFormat.FormatString = "n0";
            this.txteSoLuong.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txteSoLuong.Name = "txteSoLuong";
            // 
            // colmakhthu
            // 
            this.colmakhthu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colmakhthu.AppearanceCell.Options.UseFont = true;
            this.colmakhthu.AppearanceCell.Options.UseTextOptions = true;
            this.colmakhthu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colmakhthu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colmakhthu.AppearanceHeader.Options.UseFont = true;
            this.colmakhthu.AppearanceHeader.Options.UseTextOptions = true;
            this.colmakhthu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmakhthu.Caption = "Mã khoản thu";
            this.colmakhthu.FieldName = "makhthu";
            this.colmakhthu.Name = "colmakhthu";
            this.colmakhthu.Visible = true;
            this.colmakhthu.VisibleIndex = 1;
            this.colmakhthu.Width = 105;
            // 
            // colsotien
            // 
            this.colsotien.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colsotien.AppearanceCell.Options.UseFont = true;
            this.colsotien.AppearanceCell.Options.UseTextOptions = true;
            this.colsotien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colsotien.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colsotien.AppearanceHeader.Options.UseFont = true;
            this.colsotien.AppearanceHeader.Options.UseTextOptions = true;
            this.colsotien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsotien.Caption = "Số tiền";
            this.colsotien.ColumnEdit = this.txtesotien;
            this.colsotien.FieldName = "sotien";
            this.colsotien.Name = "colsotien";
            this.colsotien.Visible = true;
            this.colsotien.VisibleIndex = 4;
            this.colsotien.Width = 140;
            // 
            // txtesotien
            // 
            this.txtesotien.AutoHeight = false;
            this.txtesotien.DisplayFormat.FormatString = "n0";
            this.txtesotien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtesotien.EditFormat.FormatString = "n0";
            this.txtesotien.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtesotien.Name = "txtesotien";
            // 
            // grBDMPB
            // 
            this.grBDMPB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grBDMPB.CausesValidation = false;
            this.grBDMPB.Controls.Add(this.txtsotien);
            this.grBDMPB.Controls.Add(this.txtsoluong);
            this.grBDMPB.Controls.Add(this.labelX1);
            this.grBDMPB.Controls.Add(this.labelX3);
            this.grBDMPB.Controls.Add(this.txtiddmthu);
            this.grBDMPB.Controls.Add(this.txttenkhoanthu);
            this.grBDMPB.Controls.Add(this.txtmakhthu);
            this.grBDMPB.Controls.Add(this.button2);
            this.grBDMPB.Controls.Add(this.button1);
            this.grBDMPB.Controls.Add(this.labelX4);
            this.grBDMPB.Controls.Add(this.labelX2);
            this.grBDMPB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBDMPB.Location = new System.Drawing.Point(176, 140);
            this.grBDMPB.Name = "grBDMPB";
            this.grBDMPB.Size = new System.Drawing.Size(515, 186);
            this.grBDMPB.TabIndex = 240;
            this.grBDMPB.TabStop = false;
            this.grBDMPB.Visible = false;
            // 
            // txtsotien
            // 
            this.txtsotien.Location = new System.Drawing.Point(118, 97);
            this.txtsotien.Name = "txtsotien";
            this.txtsotien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsotien.Properties.Appearance.Options.UseFont = true;
            this.txtsotien.Properties.DisplayFormat.FormatString = "N0";
            this.txtsotien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsotien.Properties.EditFormat.FormatString = "N0";
            this.txtsotien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsotien.Properties.Mask.EditMask = "n0";
            this.txtsotien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtsotien.Size = new System.Drawing.Size(378, 22);
            this.txtsotien.TabIndex = 256;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(118, 72);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Properties.Appearance.Options.UseFont = true;
            this.txtsoluong.Properties.DisplayFormat.FormatString = "N0";
            this.txtsoluong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsoluong.Properties.EditFormat.FormatString = "N0";
            this.txtsoluong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtsoluong.Properties.Mask.EditMask = "n0";
            this.txtsoluong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtsoluong.Size = new System.Drawing.Size(378, 22);
            this.txtsoluong.TabIndex = 255;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(24, 97);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 20);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX1.TabIndex = 254;
            this.labelX1.Text = "Số tiền:";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(24, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(88, 20);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX3.TabIndex = 253;
            this.labelX3.Text = "Số lượng:";
            // 
            // txtiddmthu
            // 
            this.txtiddmthu.Location = new System.Drawing.Point(238, 141);
            this.txtiddmthu.Name = "txtiddmthu";
            this.txtiddmthu.Size = new System.Drawing.Size(22, 20);
            this.txtiddmthu.TabIndex = 252;
            this.txtiddmthu.Visible = false;
            // 
            // txttenkhoanthu
            // 
            this.txttenkhoanthu.Location = new System.Drawing.Point(118, 46);
            this.txttenkhoanthu.Name = "txttenkhoanthu";
            this.txttenkhoanthu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkhoanthu.Properties.Appearance.Options.UseFont = true;
            this.txttenkhoanthu.Size = new System.Drawing.Size(378, 22);
            this.txttenkhoanthu.TabIndex = 251;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(291, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 27);
            this.button2.TabIndex = 4;
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
            this.button1.Location = new System.Drawing.Point(133, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 3;
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
            this.labelX4.Size = new System.Drawing.Size(88, 20);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX4.TabIndex = 248;
            this.labelX4.Text = "Tên khoản thu:";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(24, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(88, 20);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX2.TabIndex = 244;
            this.labelX2.Text = "Mã khoản thu:";
            // 
            // txtmakhthu
            // 
            this.txtmakhthu.Location = new System.Drawing.Point(118, 21);
            this.txtmakhthu.Name = "txtmakhthu";
            this.txtmakhthu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakhthu.Properties.Appearance.Options.UseFont = true;
            this.txtmakhthu.Size = new System.Drawing.Size(378, 22);
            this.txtmakhthu.TabIndex = 250;
            // 
            // frmDMKhoanThu
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
            this.Name = "frmDMKhoanThu";
            this.ShowInTaskbar = false;
            this.Text = "Danh mục khoản thu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDMKho_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtesotien)).EndInit();
            this.grBDMPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtsotien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtiddmthu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttenkhoanthu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmakhthu.Properties)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn coliddmthu;
        private DevExpress.XtraGrid.Columns.GridColumn coltenkhoanthu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btThem;
        private DevExpress.XtraGrid.Columns.GridColumn colsoluong;
        private System.Windows.Forms.GroupBox grBDMPB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevExpress.XtraEditors.TextEdit txtiddmthu;
        private DevExpress.XtraEditors.TextEdit txttenkhoanthu;
        private DevExpress.XtraGrid.Columns.GridColumn colmakhthu;
        private DevExpress.XtraGrid.Columns.GridColumn colsotien;
        private DevExpress.XtraEditors.TextEdit txtsotien;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txteSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtesotien;
        private DevExpress.XtraEditors.TextEdit txtmakhthu;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}