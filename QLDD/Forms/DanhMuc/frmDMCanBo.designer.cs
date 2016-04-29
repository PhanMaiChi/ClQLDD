namespace KPBT.Forms.DanhMuc
{
    partial class frmDMCanBo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMCanBo));
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
            this.colmacb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltencb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldccb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphongban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Luphong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colidcanbo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luphong)).BeginInit();
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
            this.Luphong});
            this.grcKQ.Size = new System.Drawing.Size(866, 415);
            this.grcKQ.TabIndex = 6;
            this.grcKQ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKQ});
            // 
            // grvKQ
            // 
            this.grvKQ.ColumnPanelRowHeight = 40;
            this.grvKQ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colmacb,
            this.coltencb,
            this.coldccb,
            this.colphongban,
            this.colidcanbo,
            this.colTT});
            this.grvKQ.GridControl = this.grcKQ;
            this.grvKQ.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaChuong", null, "")});
            this.grvKQ.Name = "grvKQ";
            this.grvKQ.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
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
            // colmacb
            // 
            this.colmacb.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmacb.AppearanceCell.Options.UseFont = true;
            this.colmacb.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmacb.AppearanceHeader.Options.UseFont = true;
            this.colmacb.AppearanceHeader.Options.UseTextOptions = true;
            this.colmacb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmacb.Caption = "Mã số";
            this.colmacb.FieldName = "macb";
            this.colmacb.MaxWidth = 80;
            this.colmacb.Name = "colmacb";
            this.colmacb.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colmacb.OptionsFilter.AllowFilter = false;
            this.colmacb.Width = 60;
            // 
            // coltencb
            // 
            this.coltencb.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltencb.AppearanceCell.Options.UseFont = true;
            this.coltencb.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltencb.AppearanceHeader.Options.UseFont = true;
            this.coltencb.AppearanceHeader.Options.UseTextOptions = true;
            this.coltencb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltencb.Caption = "Tên cán bộ";
            this.coltencb.FieldName = "tencb";
            this.coltencb.MaxWidth = 200;
            this.coltencb.Name = "coltencb";
            this.coltencb.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coltencb.OptionsFilter.AllowFilter = false;
            this.coltencb.Visible = true;
            this.coltencb.VisibleIndex = 2;
            this.coltencb.Width = 150;
            // 
            // coldccb
            // 
            this.coldccb.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldccb.AppearanceCell.Options.UseFont = true;
            this.coldccb.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldccb.AppearanceHeader.Options.UseFont = true;
            this.coldccb.AppearanceHeader.Options.UseTextOptions = true;
            this.coldccb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldccb.Caption = "Địa chỉ";
            this.coldccb.FieldName = "dccb";
            this.coldccb.Name = "coldccb";
            this.coldccb.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldccb.OptionsFilter.AllowFilter = false;
            this.coldccb.Visible = true;
            this.coldccb.VisibleIndex = 3;
            this.coldccb.Width = 318;
            // 
            // colphongban
            // 
            this.colphongban.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colphongban.AppearanceCell.Options.UseFont = true;
            this.colphongban.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colphongban.AppearanceHeader.Options.UseFont = true;
            this.colphongban.AppearanceHeader.Options.UseTextOptions = true;
            this.colphongban.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colphongban.Caption = "Phòng ban";
            this.colphongban.ColumnEdit = this.Luphong;
            this.colphongban.FieldName = "phongban";
            this.colphongban.MaxWidth = 200;
            this.colphongban.Name = "colphongban";
            this.colphongban.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colphongban.OptionsFilter.AllowFilter = false;
            this.colphongban.Visible = true;
            this.colphongban.VisibleIndex = 1;
            this.colphongban.Width = 120;
            // 
            // Luphong
            // 
            this.Luphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luphong.Appearance.Options.UseFont = true;
            this.Luphong.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luphong.AppearanceDropDown.Options.UseFont = true;
            this.Luphong.AutoHeight = false;
            this.Luphong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Luphong.Name = "Luphong";
            this.Luphong.NullText = "";
            this.Luphong.ShowFooter = false;
            this.Luphong.ShowHeader = false;
            this.Luphong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // colidcanbo
            // 
            this.colidcanbo.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colidcanbo.AppearanceCell.Options.UseFont = true;
            this.colidcanbo.AppearanceCell.Options.UseTextOptions = true;
            this.colidcanbo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidcanbo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colidcanbo.AppearanceHeader.Options.UseFont = true;
            this.colidcanbo.AppearanceHeader.Options.UseTextOptions = true;
            this.colidcanbo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidcanbo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colidcanbo.Caption = "Số kho";
            this.colidcanbo.FieldName = "idcanbo";
            this.colidcanbo.MaxWidth = 100;
            this.colidcanbo.Name = "colidcanbo";
            this.colidcanbo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colidcanbo.OptionsFilter.AllowFilter = false;
            this.colidcanbo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaChuong", "Số bản ghi: {0:n0}")});
            this.colidcanbo.Width = 92;
            // 
            // colTT
            // 
            this.colTT.Caption = "gridColumn1";
            this.colTT.FieldName = "TT";
            this.colTT.Name = "colTT";
            // 
            // frmDMCanBo
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
            this.Name = "frmDMCanBo";
            this.ShowInTaskbar = false;
            this.Text = "DANH MỤC CÁN BỘ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDMCanBo_FormClosed);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luphong)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colidcanbo;
        private DevExpress.XtraGrid.Columns.GridColumn coltencb;
        private System.Windows.Forms.ToolStripButton btThem;
        private DevExpress.XtraGrid.Columns.GridColumn coldccb;
        private DevExpress.XtraGrid.Columns.GridColumn colmacb;
        private DevExpress.XtraGrid.Columns.GridColumn colphongban;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Luphong;
    }
}