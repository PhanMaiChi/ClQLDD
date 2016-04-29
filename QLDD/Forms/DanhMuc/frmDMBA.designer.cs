namespace KPBT.Forms.DanhMuc
{
    partial class frmDMBA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMBA));
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
            this.colTenBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTheodoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).BeginInit();
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
            this.toolStrip2.Size = new System.Drawing.Size(531, 25);
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
            this.toolStripSeparator2.Visible = false;
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
            this.grcKQ.Size = new System.Drawing.Size(531, 290);
            this.grcKQ.TabIndex = 6;
            this.grcKQ.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKQ});
            // 
            // grvKQ
            // 
            this.grvKQ.ColumnPanelRowHeight = 40;
            this.grvKQ.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colTenBA,
            this.colIDBA,
            this.colTT,
            this.colTheodoi});
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
            this.colSTT.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.OptionsColumn.TabStop = false;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 46;
            // 
            // colTenBA
            // 
            this.colTenBA.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colTenBA.AppearanceCell.Options.UseFont = true;
            this.colTenBA.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenBA.AppearanceHeader.Options.UseFont = true;
            this.colTenBA.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenBA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenBA.Caption = "Bữa ăn";
            this.colTenBA.FieldName = "TenBA";
            this.colTenBA.Name = "colTenBA";
            this.colTenBA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colTenBA.OptionsFilter.AllowFilter = false;
            this.colTenBA.Visible = true;
            this.colTenBA.VisibleIndex = 1;
            this.colTenBA.Width = 507;
            // 
            // colIDBA
            // 
            this.colIDBA.FieldName = "IDBA";
            this.colIDBA.Name = "colIDBA";
            // 
            // colTT
            // 
            this.colTT.Caption = "gridColumn1";
            this.colTT.FieldName = "TT";
            this.colTT.Name = "colTT";
            // 
            // colTheodoi
            // 
            this.colTheodoi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTheodoi.AppearanceCell.Options.UseFont = true;
            this.colTheodoi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTheodoi.AppearanceHeader.Options.UseFont = true;
            this.colTheodoi.AppearanceHeader.Options.UseTextOptions = true;
            this.colTheodoi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTheodoi.Caption = "Theo dõi";
            this.colTheodoi.FieldName = "Theodoi";
            this.colTheodoi.Name = "colTheodoi";
            this.colTheodoi.Visible = true;
            this.colTheodoi.VisibleIndex = 2;
            // 
            // frmDMBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 315);
            this.ControlBox = false;
            this.Controls.Add(this.grcKQ);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDMBA";
            this.ShowInTaskbar = false;
            this.Text = "Danh mục bữa ăn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDMDT_FormClosed);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colTenBA;
        private System.Windows.Forms.ToolStripButton btThem;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBA;
        private DevExpress.XtraGrid.Columns.GridColumn colTT;
        private DevExpress.XtraGrid.Columns.GridColumn colTheodoi;
    }
}