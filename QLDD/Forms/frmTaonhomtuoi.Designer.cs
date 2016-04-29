namespace KPBT.Forms
{
    partial class frmTaonhomtuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaonhomtuoi));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbtLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nhómTuổiHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tấtCảCácNhómTuổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nhậpDanhMụcBữaĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtTroGiup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtThoat = new System.Windows.Forms.ToolStripButton();
            this.grcMain = new DevExpress.XtraGrid.GridControl();
            this.grvCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbuaan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnangluong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtnangluong = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colprotein = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchatbeo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcarbohydrat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldongia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSotien = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCTNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbobuaan = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.Lubuaan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Lunhomtuoi = new DevExpress.XtraEditors.LookUpEdit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnangluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSotien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbobuaan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lubuaan)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lunhomtuoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.toolStrip2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtLuu,
            this.toolStripSeparator1,
            this.tbtXoa,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.tbtIn,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator6,
            this.tbtTroGiup,
            this.toolStripSeparator4,
            this.tbtThoat});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(913, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tbtLuu
            // 
            this.tbtLuu.Image = ((System.Drawing.Image)(resources.GetObject("tbtLuu.Image")));
            this.tbtLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbtLuu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbtLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtLuu.Name = "tbtLuu";
            this.tbtLuu.Size = new System.Drawing.Size(48, 22);
            this.tbtLuu.Text = "Lưu";
            this.tbtLuu.Click += new System.EventHandler(this.tbtLuu_Click);
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
            this.tbtXoa.Visible = false;
            this.tbtXoa.Click += new System.EventHandler(this.tbtXoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhómTuổiHiệnTạiToolStripMenuItem,
            this.tấtCảCácNhómTuổiToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(105, 22);
            this.toolStripButton1.Text = "Thêm bữa ăn";
            // 
            // nhómTuổiHiệnTạiToolStripMenuItem
            // 
            this.nhómTuổiHiệnTạiToolStripMenuItem.Name = "nhómTuổiHiệnTạiToolStripMenuItem";
            this.nhómTuổiHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.nhómTuổiHiệnTạiToolStripMenuItem.Text = "Nhóm tuổi hiện tại";
            this.nhómTuổiHiệnTạiToolStripMenuItem.Click += new System.EventHandler(this.nhómTuổiHiệnTạiToolStripMenuItem_Click);
            // 
            // tấtCảCácNhómTuổiToolStripMenuItem
            // 
            this.tấtCảCácNhómTuổiToolStripMenuItem.Name = "tấtCảCácNhómTuổiToolStripMenuItem";
            this.tấtCảCácNhómTuổiToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.tấtCảCácNhómTuổiToolStripMenuItem.Text = "Tất cả các nhóm tuổi";
            this.tấtCảCácNhómTuổiToolStripMenuItem.Click += new System.EventHandler(this.tấtCảCácNhómTuổiToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDanhMụcBữaĂnToolStripMenuItem});
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton2.Text = "Tiện ích";
            // 
            // nhậpDanhMụcBữaĂnToolStripMenuItem
            // 
            this.nhậpDanhMụcBữaĂnToolStripMenuItem.Name = "nhậpDanhMụcBữaĂnToolStripMenuItem";
            this.nhậpDanhMụcBữaĂnToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.nhậpDanhMụcBữaĂnToolStripMenuItem.Text = "Nhập danh mục bữa ăn";
            this.nhậpDanhMụcBữaĂnToolStripMenuItem.Click += new System.EventHandler(this.nhậpDanhMụcBữaĂnToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
            // grcMain
            // 
            this.grcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grcMain.Location = new System.Drawing.Point(0, 99);
            this.grcMain.MainView = this.grvCT;
            this.grcMain.Name = "grcMain";
            this.grcMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbobuaan,
            this.txtnangluong,
            this.txtSotien,
            this.Lubuaan});
            this.grcMain.Size = new System.Drawing.Size(913, 347);
            this.grcMain.TabIndex = 9;
            this.grcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCT});
            // 
            // grvCT
            // 
            this.grvCT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvCT.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvCT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMaNT,
            this.colbuaan,
            this.colnangluong,
            this.colprotein,
            this.colchatbeo,
            this.colcarbohydrat,
            this.coldongia,
            this.colTT,
            this.colIDCTNT});
            this.grvCT.GridControl = this.grcMain;
            this.grvCT.Name = "grvCT";
            this.grvCT.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvCT.OptionsView.ShowGroupPanel = false;
            // 
            // colSTT
            // 
            this.colSTT.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colSTT.AppearanceCell.Options.UseFont = true;
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.MaxWidth = 40;
            this.colSTT.Name = "colSTT";
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 38;
            // 
            // colMaNT
            // 
            this.colMaNT.Caption = "Mã nhóm tuổi";
            this.colMaNT.FieldName = "MaNT";
            this.colMaNT.Name = "colMaNT";
            // 
            // colbuaan
            // 
            this.colbuaan.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbuaan.AppearanceCell.Options.UseFont = true;
            this.colbuaan.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colbuaan.AppearanceHeader.Options.UseFont = true;
            this.colbuaan.AppearanceHeader.Options.UseTextOptions = true;
            this.colbuaan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbuaan.Caption = "Bữa ăn";
            this.colbuaan.FieldName = "buaan";
            this.colbuaan.Name = "colbuaan";
            this.colbuaan.OptionsColumn.AllowEdit = false;
            this.colbuaan.OptionsColumn.ReadOnly = true;
            this.colbuaan.Visible = true;
            this.colbuaan.VisibleIndex = 1;
            this.colbuaan.Width = 165;
            // 
            // colnangluong
            // 
            this.colnangluong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colnangluong.AppearanceCell.Options.UseFont = true;
            this.colnangluong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colnangluong.AppearanceHeader.Options.UseFont = true;
            this.colnangluong.AppearanceHeader.Options.UseTextOptions = true;
            this.colnangluong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colnangluong.Caption = "Năng lượng (Calo)";
            this.colnangluong.ColumnEdit = this.txtnangluong;
            this.colnangluong.FieldName = "nangluong";
            this.colnangluong.MaxWidth = 120;
            this.colnangluong.Name = "colnangluong";
            this.colnangluong.Visible = true;
            this.colnangluong.VisibleIndex = 2;
            this.colnangluong.Width = 120;
            // 
            // txtnangluong
            // 
            this.txtnangluong.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txtnangluong.Appearance.Options.UseFont = true;
            this.txtnangluong.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txtnangluong.AppearanceFocused.Options.UseFont = true;
            this.txtnangluong.AutoHeight = false;
            this.txtnangluong.Mask.EditMask = "n";
            this.txtnangluong.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtnangluong.Mask.UseMaskAsDisplayFormat = true;
            this.txtnangluong.Name = "txtnangluong";
            // 
            // colprotein
            // 
            this.colprotein.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colprotein.AppearanceCell.Options.UseFont = true;
            this.colprotein.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colprotein.AppearanceHeader.Options.UseFont = true;
            this.colprotein.AppearanceHeader.Options.UseTextOptions = true;
            this.colprotein.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprotein.Caption = "Đạm (P)";
            this.colprotein.ColumnEdit = this.txtnangluong;
            this.colprotein.FieldName = "protein";
            this.colprotein.MaxWidth = 100;
            this.colprotein.Name = "colprotein";
            this.colprotein.Visible = true;
            this.colprotein.VisibleIndex = 3;
            this.colprotein.Width = 100;
            // 
            // colchatbeo
            // 
            this.colchatbeo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colchatbeo.AppearanceCell.Options.UseFont = true;
            this.colchatbeo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colchatbeo.AppearanceHeader.Options.UseFont = true;
            this.colchatbeo.AppearanceHeader.Options.UseTextOptions = true;
            this.colchatbeo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colchatbeo.Caption = "Chất béo (L)";
            this.colchatbeo.ColumnEdit = this.txtnangluong;
            this.colchatbeo.FieldName = "chatbeo";
            this.colchatbeo.MaxWidth = 100;
            this.colchatbeo.Name = "colchatbeo";
            this.colchatbeo.Visible = true;
            this.colchatbeo.VisibleIndex = 4;
            this.colchatbeo.Width = 100;
            // 
            // colcarbohydrat
            // 
            this.colcarbohydrat.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcarbohydrat.AppearanceCell.Options.UseFont = true;
            this.colcarbohydrat.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcarbohydrat.AppearanceHeader.Options.UseFont = true;
            this.colcarbohydrat.AppearanceHeader.Options.UseTextOptions = true;
            this.colcarbohydrat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcarbohydrat.Caption = "Đường (G)";
            this.colcarbohydrat.ColumnEdit = this.txtnangluong;
            this.colcarbohydrat.FieldName = "carbohydrat";
            this.colcarbohydrat.MaxWidth = 100;
            this.colcarbohydrat.Name = "colcarbohydrat";
            this.colcarbohydrat.Visible = true;
            this.colcarbohydrat.VisibleIndex = 5;
            this.colcarbohydrat.Width = 100;
            // 
            // coldongia
            // 
            this.coldongia.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldongia.AppearanceCell.Options.UseFont = true;
            this.coldongia.AppearanceCell.Options.UseTextOptions = true;
            this.coldongia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coldongia.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldongia.AppearanceHeader.Options.UseFont = true;
            this.coldongia.AppearanceHeader.Options.UseTextOptions = true;
            this.coldongia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldongia.Caption = "Đơn giá";
            this.coldongia.ColumnEdit = this.txtSotien;
            this.coldongia.FieldName = "dongia";
            this.coldongia.MaxWidth = 150;
            this.coldongia.Name = "coldongia";
            this.coldongia.Visible = true;
            this.coldongia.VisibleIndex = 6;
            this.coldongia.Width = 150;
            // 
            // txtSotien
            // 
            this.txtSotien.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txtSotien.Appearance.Options.UseFont = true;
            this.txtSotien.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.txtSotien.AppearanceFocused.Options.UseFont = true;
            this.txtSotien.AutoHeight = false;
            this.txtSotien.Mask.EditMask = "n0";
            this.txtSotien.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSotien.Mask.UseMaskAsDisplayFormat = true;
            this.txtSotien.Name = "txtSotien";
            // 
            // colTT
            // 
            this.colTT.Caption = "TT";
            this.colTT.FieldName = "TT";
            this.colTT.Name = "colTT";
            this.colTT.Width = 122;
            // 
            // colIDCTNT
            // 
            this.colIDCTNT.Caption = "gridColumn1";
            this.colIDCTNT.FieldName = "IDCTNT";
            this.colIDCTNT.Name = "colIDCTNT";
            // 
            // cbobuaan
            // 
            this.cbobuaan.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuaan.Appearance.Options.UseFont = true;
            this.cbobuaan.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuaan.AppearanceDropDown.Options.UseFont = true;
            this.cbobuaan.AutoHeight = false;
            this.cbobuaan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbobuaan.Items.AddRange(new object[] {
            "Chính sáng",
            "Chính chiều",
            "Phụ"});
            this.cbobuaan.Name = "cbobuaan";
            // 
            // Lubuaan
            // 
            this.Lubuaan.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lubuaan.Appearance.Options.UseFont = true;
            this.Lubuaan.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Lubuaan.AppearanceDropDown.Options.UseFont = true;
            this.Lubuaan.AutoHeight = false;
            this.Lubuaan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lubuaan.Name = "Lubuaan";
            this.Lubuaan.NullText = "";
            this.Lubuaan.ShowFooter = false;
            this.Lubuaan.ShowHeader = false;
            this.Lubuaan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.Lunhomtuoi);
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 28);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(889, 65);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 10;
            this.groupPanel1.Text = "Nhóm tuổi";
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(223, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 17);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Lựa chọn nhóm tuổi:";
            // 
            // Lunhomtuoi
            // 
            this.Lunhomtuoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lunhomtuoi.Location = new System.Drawing.Point(352, 11);
            this.Lunhomtuoi.Name = "Lunhomtuoi";
            this.Lunhomtuoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunhomtuoi.Properties.Appearance.Options.UseFont = true;
            this.Lunhomtuoi.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunhomtuoi.Properties.AppearanceDropDown.Options.UseFont = true;
            this.Lunhomtuoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("Lunhomtuoi.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.Lunhomtuoi.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenNT", "Name1")});
            this.Lunhomtuoi.Properties.NullText = "";
            this.Lunhomtuoi.Properties.PopupSizeable = false;
            this.Lunhomtuoi.Properties.ShowFooter = false;
            this.Lunhomtuoi.Properties.ShowHeader = false;
            this.Lunhomtuoi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Lunhomtuoi.Size = new System.Drawing.Size(310, 22);
            this.Lunhomtuoi.TabIndex = 0;
            this.Lunhomtuoi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Lunhomtuoi_ButtonClick);
            this.Lunhomtuoi.EditValueChanged += new System.EventHandler(this.Lunhomtuoi_EditValueChanged);
            // 
            // frmTaonhomtuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 458);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.grcMain);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaonhomtuoi";
            this.Text = "Tạo các nhóm tuổi tại nhà trường";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaonhomtuoi_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTaonhomtuoi_FormClosed);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnangluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSotien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbobuaan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lubuaan)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lunhomtuoi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbtLuu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtTroGiup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbtThoat;
        private DevExpress.XtraGrid.GridControl grcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNT;
        private DevExpress.XtraGrid.Columns.GridColumn colbuaan;
        private DevExpress.XtraGrid.Columns.GridColumn colnangluong;
        private DevExpress.XtraGrid.Columns.GridColumn colprotein;
        private DevExpress.XtraGrid.Columns.GridColumn colchatbeo;
        private DevExpress.XtraGrid.Columns.GridColumn colcarbohydrat;
        private DevExpress.XtraGrid.Columns.GridColumn coldongia;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbobuaan;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtnangluong;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtSotien;
        private DevExpress.XtraEditors.LookUpEdit Lunhomtuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCTNT;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem nhómTuổiHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tấtCảCácNhómTuổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Lubuaan;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem nhậpDanhMụcBữaĂnToolStripMenuItem;
    }
}