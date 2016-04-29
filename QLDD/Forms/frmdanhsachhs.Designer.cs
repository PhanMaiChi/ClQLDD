namespace KPBT.Forms
{
    partial class frmdanhsachhs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdanhsachhs));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbtLuu = new System.Windows.Forms.ToolStripButton();
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
            this.colmshs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgths = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboGioiTinh = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colntns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dteNS = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.coldatoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LuDanToc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.coldchs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LuPhong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidhs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colht = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboHienTrang = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtTenHS = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.taoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNS.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuDanToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHienTrang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHS)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.tbtIn,
            this.toolStripSeparator3,
            this.tbtTroGiup,
            this.toolStripSeparator4,
            this.tbtThoat});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(822, 25);
            this.toolStrip2.TabIndex = 7;
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
            this.tbtIn.Click += new System.EventHandler(this.tbtIn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.cboGioiTinh,
            this.dteNS,
            this.cboHienTrang,
            this.LuDanToc,
            this.LuPhong,
            this.txtTenHS});
            this.grcKQ.Size = new System.Drawing.Size(822, 466);
            this.grcKQ.TabIndex = 8;
            this.grcKQ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKQ});
            // 
            // grvKQ
            // 
            this.grvKQ.ColumnPanelRowHeight = 40;
            this.grvKQ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colmshs,
            this.coltenhs,
            this.colgths,
            this.colntns,
            this.coldatoc,
            this.coldchs,
            this.coltenphong,
            this.colidhs,
            this.colht,
            this.colTT});
            this.grvKQ.GridControl = this.grcKQ;
            this.grvKQ.Name = "grvKQ";
            this.grvKQ.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.grvKQ.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grvKQ.OptionsView.ShowGroupPanel = false;
            this.grvKQ.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.grvKQ_InitNewRow);
            this.grvKQ.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.grvKQ_InvalidRowException);
            this.grvKQ.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grvKQ_ValidateRow);
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
            this.colSTT.Caption = "STT";
            this.colSTT.FieldName = "STT";
            this.colSTT.MaxWidth = 45;
            this.colSTT.MinWidth = 45;
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.AllowEdit = false;
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 45;
            // 
            // colmshs
            // 
            this.colmshs.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmshs.AppearanceCell.Options.UseFont = true;
            this.colmshs.AppearanceCell.Options.UseTextOptions = true;
            this.colmshs.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmshs.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmshs.AppearanceHeader.Options.UseFont = true;
            this.colmshs.AppearanceHeader.Options.UseTextOptions = true;
            this.colmshs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmshs.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colmshs.Caption = "Mã số học sinh";
            this.colmshs.FieldName = "mshs";
            this.colmshs.MaxWidth = 90;
            this.colmshs.MinWidth = 90;
            this.colmshs.Name = "colmshs";
            this.colmshs.OptionsColumn.AllowEdit = false;
            this.colmshs.OptionsColumn.ReadOnly = true;
            this.colmshs.Width = 90;
            // 
            // coltenhs
            // 
            this.coltenhs.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltenhs.AppearanceCell.Options.UseFont = true;
            this.coltenhs.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltenhs.AppearanceHeader.Options.UseFont = true;
            this.coltenhs.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenhs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenhs.Caption = "Tên gọi học sinh";
            this.coltenhs.FieldName = "tenhs";
            this.coltenhs.MaxWidth = 200;
            this.coltenhs.Name = "coltenhs";
            this.coltenhs.Visible = true;
            this.coltenhs.VisibleIndex = 1;
            this.coltenhs.Width = 182;
            // 
            // colgths
            // 
            this.colgths.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colgths.AppearanceCell.Options.UseFont = true;
            this.colgths.AppearanceCell.Options.UseTextOptions = true;
            this.colgths.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgths.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colgths.AppearanceHeader.Options.UseFont = true;
            this.colgths.AppearanceHeader.Options.UseTextOptions = true;
            this.colgths.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colgths.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colgths.Caption = "Giới tính";
            this.colgths.ColumnEdit = this.cboGioiTinh;
            this.colgths.FieldName = "gths";
            this.colgths.MaxWidth = 50;
            this.colgths.Name = "colgths";
            this.colgths.Visible = true;
            this.colgths.VisibleIndex = 2;
            this.colgths.Width = 40;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.Appearance.Options.UseFont = true;
            this.cboGioiTinh.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.AppearanceDropDown.Options.UseFont = true;
            this.cboGioiTinh.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.cboGioiTinh.AppearanceFocused.Options.UseFont = true;
            this.cboGioiTinh.AutoHeight = false;
            this.cboGioiTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Name = "cboGioiTinh";
            // 
            // colntns
            // 
            this.colntns.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colntns.AppearanceCell.Options.UseFont = true;
            this.colntns.AppearanceCell.Options.UseTextOptions = true;
            this.colntns.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colntns.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colntns.AppearanceHeader.Options.UseFont = true;
            this.colntns.AppearanceHeader.Options.UseTextOptions = true;
            this.colntns.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colntns.Caption = "Ngày sinh";
            this.colntns.ColumnEdit = this.dteNS;
            this.colntns.FieldName = "ntns";
            this.colntns.MaxWidth = 90;
            this.colntns.Name = "colntns";
            this.colntns.Visible = true;
            this.colntns.VisibleIndex = 3;
            this.colntns.Width = 63;
            // 
            // dteNS
            // 
            this.dteNS.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.dteNS.Appearance.Options.UseFont = true;
            this.dteNS.AutoHeight = false;
            this.dteNS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNS.Name = "dteNS";
            this.dteNS.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // coldatoc
            // 
            this.coldatoc.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coldatoc.AppearanceCell.Options.UseFont = true;
            this.coldatoc.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coldatoc.AppearanceHeader.Options.UseFont = true;
            this.coldatoc.AppearanceHeader.Options.UseTextOptions = true;
            this.coldatoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldatoc.Caption = "Dân tộc";
            this.coldatoc.ColumnEdit = this.LuDanToc;
            this.coldatoc.FieldName = "datoc";
            this.coldatoc.MaxWidth = 90;
            this.coldatoc.Name = "coldatoc";
            this.coldatoc.Visible = true;
            this.coldatoc.VisibleIndex = 4;
            this.coldatoc.Width = 63;
            // 
            // LuDanToc
            // 
            this.LuDanToc.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LuDanToc.Appearance.Options.UseFont = true;
            this.LuDanToc.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.LuDanToc.AppearanceDropDown.Options.UseFont = true;
            this.LuDanToc.AutoHeight = false;
            this.LuDanToc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuDanToc.Name = "LuDanToc";
            this.LuDanToc.NullText = "";
            this.LuDanToc.ShowFooter = false;
            this.LuDanToc.ShowHeader = false;
            this.LuDanToc.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // coldchs
            // 
            this.coldchs.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coldchs.AppearanceCell.Options.UseFont = true;
            this.coldchs.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coldchs.AppearanceHeader.Options.UseFont = true;
            this.coldchs.AppearanceHeader.Options.UseTextOptions = true;
            this.coldchs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldchs.Caption = "Địa chỉ học sinh";
            this.coldchs.FieldName = "dchs";
            this.coldchs.Name = "coldchs";
            this.coldchs.Visible = true;
            this.coldchs.VisibleIndex = 5;
            this.coldchs.Width = 165;
            // 
            // coltenphong
            // 
            this.coltenphong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coltenphong.AppearanceCell.Options.UseFont = true;
            this.coltenphong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coltenphong.AppearanceHeader.Options.UseFont = true;
            this.coltenphong.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenphong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenphong.Caption = "Phòng ở";
            this.coltenphong.ColumnEdit = this.LuPhong;
            this.coltenphong.FieldName = "tenphong";
            this.coltenphong.MaxWidth = 100;
            this.coltenphong.Name = "coltenphong";
            this.coltenphong.Visible = true;
            this.coltenphong.VisibleIndex = 6;
            this.coltenphong.Width = 58;
            // 
            // LuPhong
            // 
            this.LuPhong.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.LuPhong.Appearance.Options.UseFont = true;
            this.LuPhong.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.LuPhong.AppearanceDropDown.Options.UseFont = true;
            this.LuPhong.AutoHeight = false;
            this.LuPhong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LuPhong.Name = "LuPhong";
            this.LuPhong.NullText = "";
            this.LuPhong.ShowFooter = false;
            this.LuPhong.ShowHeader = false;
            this.LuPhong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // colidhs
            // 
            this.colidhs.Caption = "idhs";
            this.colidhs.FieldName = "idhs";
            this.colidhs.Name = "colidhs";
            // 
            // colht
            // 
            this.colht.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colht.AppearanceCell.Options.UseFont = true;
            this.colht.AppearanceCell.Options.UseTextOptions = true;
            this.colht.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colht.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colht.AppearanceHeader.Options.UseFont = true;
            this.colht.AppearanceHeader.Options.UseTextOptions = true;
            this.colht.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colht.Caption = "Hiện trạng";
            this.colht.ColumnEdit = this.cboHienTrang;
            this.colht.FieldName = "ht";
            this.colht.MaxWidth = 70;
            this.colht.Name = "colht";
            this.colht.Visible = true;
            this.colht.VisibleIndex = 7;
            this.colht.Width = 35;
            // 
            // cboHienTrang
            // 
            this.cboHienTrang.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.cboHienTrang.Appearance.Options.UseFont = true;
            this.cboHienTrang.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.cboHienTrang.AppearanceDropDown.Options.UseFont = true;
            this.cboHienTrang.AutoHeight = false;
            this.cboHienTrang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHienTrang.Items.AddRange(new object[] {
            "Đi học",
            "Thôi học"});
            this.cboHienTrang.Name = "cboHienTrang";
            // 
            // colTT
            // 
            this.colTT.FieldName = "TT";
            this.colTT.Name = "colTT";
            this.colTT.Width = 63;
            // 
            // txtTenHS
            // 
            this.txtTenHS.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHS.Appearance.Options.UseFont = true;
            this.txtTenHS.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHS.AppearanceFocused.Options.UseFont = true;
            this.txtTenHS.AutoHeight = false;
            this.txtTenHS.Name = "txtTenHS";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(220, 26);
            // 
            // taoToolStripMenuItem
            // 
            this.taoToolStripMenuItem.Name = "taoToolStripMenuItem";
            this.taoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.taoToolStripMenuItem.Text = "Biểu đồ tăng trưởng của trẻ";
            this.taoToolStripMenuItem.Click += new System.EventHandler(this.taoToolStripMenuItem_Click);
            // 
            // frmdanhsachhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 491);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.grcKQ);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmdanhsachhs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập danh sách học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmdanhsachhs_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmdanhsachhs_FormClosed);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNS.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuDanToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHienTrang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHS)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.GridControl grcKQ;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colmshs;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhs;
        private DevExpress.XtraGrid.Columns.GridColumn colntns;
        private DevExpress.XtraGrid.Columns.GridColumn coldatoc;
        private DevExpress.XtraGrid.Columns.GridColumn coldchs;
        private DevExpress.XtraGrid.Columns.GridColumn coltenphong;
        private DevExpress.XtraGrid.Columns.GridColumn colgths;
        private DevExpress.XtraGrid.Columns.GridColumn colidhs;
        private DevExpress.XtraGrid.Columns.GridColumn colht;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboGioiTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dteNS;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cboHienTrang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LuDanToc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LuPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtTenHS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taoToolStripMenuItem;

    }
}