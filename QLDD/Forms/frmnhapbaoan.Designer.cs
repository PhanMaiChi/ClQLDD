namespace KPBT.Forms
{
    partial class frmnhapbaoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnhapbaoan));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tbtXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tbtIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtTroGiup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtThoat = new System.Windows.Forms.ToolStripButton();
            this.grpdshs = new System.Windows.Forms.GroupBox();
            this.lbmucan = new DevComponents.DotNetBar.LabelX();
            this.cbtenphongb = new System.Windows.Forms.ComboBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtntanb = new System.Windows.Forms.MaskedTextBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.grcKQ = new DevExpress.XtraGrid.GridControl();
            this.grvKQ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmshs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colntan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltuanthu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colGC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidbaoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2.SuspendLayout();
            this.grpdshs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.toolStrip2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton5,
            this.toolStripButton2,
            this.toolStripButton3,
            this.tbtXoa,
            this.toolStripSeparator2,
            this.toolStripButton4,
            this.tbtIn,
            this.toolStripSeparator3,
            this.tbtTroGiup,
            this.toolStripSeparator4,
            this.tbtThoat});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(944, 25);
            this.toolStrip2.TabIndex = 8;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton1.Text = "Tạo tất cả";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton5.Text = "Tạo bữa sáng";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton2.Text = "Tạo bữa trưa";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton3.Text = "Tạo bữa tối";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tbtXoa
            // 
            this.tbtXoa.Image = ((System.Drawing.Image)(resources.GetObject("tbtXoa.Image")));
            this.tbtXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtXoa.Name = "tbtXoa";
            this.tbtXoa.Size = new System.Drawing.Size(62, 22);
            this.tbtXoa.Text = "Xóa ct";
            this.tbtXoa.Click += new System.EventHandler(this.tbtXoa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton4.Text = "Xóa";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
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
            this.tbtTroGiup.Click += new System.EventHandler(this.tbtTroGiup_Click);
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
            // grpdshs
            // 
            this.grpdshs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpdshs.Controls.Add(this.lbmucan);
            this.grpdshs.Controls.Add(this.cbtenphongb);
            this.grpdshs.Controls.Add(this.labelX7);
            this.grpdshs.Controls.Add(this.txtntanb);
            this.grpdshs.Controls.Add(this.labelX3);
            this.grpdshs.Location = new System.Drawing.Point(0, 25);
            this.grpdshs.Name = "grpdshs";
            this.grpdshs.Size = new System.Drawing.Size(944, 61);
            this.grpdshs.TabIndex = 10;
            this.grpdshs.TabStop = false;
            // 
            // lbmucan
            // 
            this.lbmucan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmucan.BackColor = System.Drawing.Color.Transparent;
            this.lbmucan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmucan.Location = new System.Drawing.Point(570, 23);
            this.lbmucan.Name = "lbmucan";
            this.lbmucan.Size = new System.Drawing.Size(362, 21);
            this.lbmucan.TabIndex = 286;
            this.lbmucan.Text = "Mức ăn một bữa (Sáng/Trưa/Chiều) là: 9.500 đồng";
            // 
            // cbtenphongb
            // 
            this.cbtenphongb.FormattingEnabled = true;
            this.cbtenphongb.Location = new System.Drawing.Point(336, 24);
            this.cbtenphongb.Name = "cbtenphongb";
            this.cbtenphongb.Size = new System.Drawing.Size(146, 21);
            this.cbtenphongb.TabIndex = 283;
            this.cbtenphongb.TextChanged += new System.EventHandler(this.cbtenphongb_TextChanged);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(222, 23);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(113, 21);
            this.labelX7.TabIndex = 282;
            this.labelX7.Text = "Phòng ở học sinh:";
            // 
            // txtntanb
            // 
            this.txtntanb.Location = new System.Drawing.Point(116, 23);
            this.txtntanb.Mask = "##/##/####";
            this.txtntanb.Name = "txtntanb";
            this.txtntanb.Size = new System.Drawing.Size(87, 20);
            this.txtntanb.TabIndex = 277;
            this.txtntanb.Leave += new System.EventHandler(this.txtntanb_Leave);
            this.txtntanb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtntanb_KeyPress);
            this.txtntanb.TextChanged += new System.EventHandler(this.txtntanb_TextChanged);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(23, 21);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(87, 21);
            this.labelX3.TabIndex = 276;
            this.labelX3.Text = "Ngày báo ăn:";
            // 
            // grcKQ
            // 
            this.grcKQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grcKQ.Location = new System.Drawing.Point(0, 92);
            this.grcKQ.MainView = this.grvKQ;
            this.grcKQ.Name = "grcKQ";
            this.grcKQ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.grcKQ.Size = new System.Drawing.Size(944, 412);
            this.grcKQ.TabIndex = 11;
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
            this.colmshs,
            this.coltenhs,
            this.coltenphong,
            this.colntan,
            this.colthu,
            this.coltuanthu,
            this.colBS1,
            this.colBC1,
            this.colBT1,
            this.colGC,
            this.colidbaoan,
            this.colMA});
            this.grvKQ.GridControl = this.grcKQ;
            this.grvKQ.Name = "grvKQ";
            this.grvKQ.OptionsView.EnableAppearanceEvenRow = true;
            this.grvKQ.OptionsView.EnableAppearanceOddRow = true;
            this.grvKQ.OptionsView.ShowGroupPanel = false;
            this.grvKQ.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvKQ_CellValueChanged);
            this.grvKQ.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvKQ_CellValueChanging);
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
            this.colSTT.OptionsColumn.ReadOnly = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 0;
            this.colSTT.Width = 45;
            // 
            // colmshs
            // 
            this.colmshs.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmshs.AppearanceCell.Options.UseFont = true;
            this.colmshs.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colmshs.AppearanceHeader.Options.UseFont = true;
            this.colmshs.AppearanceHeader.Options.UseTextOptions = true;
            this.colmshs.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colmshs.Caption = "Mã số học sinh";
            this.colmshs.FieldName = "mshs";
            this.colmshs.MaxWidth = 90;
            this.colmshs.MinWidth = 90;
            this.colmshs.Name = "colmshs";
            this.colmshs.OptionsColumn.ReadOnly = true;
            this.colmshs.Visible = true;
            this.colmshs.VisibleIndex = 1;
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
            this.coltenhs.MaxWidth = 150;
            this.coltenhs.Name = "coltenhs";
            this.coltenhs.OptionsColumn.ReadOnly = true;
            this.coltenhs.Visible = true;
            this.coltenhs.VisibleIndex = 2;
            this.coltenhs.Width = 150;
            // 
            // coltenphong
            // 
            this.coltenphong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltenphong.AppearanceCell.Options.UseFont = true;
            this.coltenphong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltenphong.AppearanceHeader.Options.UseFont = true;
            this.coltenphong.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenphong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenphong.Caption = "Lớp học sinh";
            this.coltenphong.FieldName = "tenphong";
            this.coltenphong.MaxWidth = 110;
            this.coltenphong.Name = "coltenphong";
            this.coltenphong.OptionsColumn.ReadOnly = true;
            this.coltenphong.Visible = true;
            this.coltenphong.VisibleIndex = 3;
            // 
            // colntan
            // 
            this.colntan.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colntan.AppearanceCell.Options.UseFont = true;
            this.colntan.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colntan.AppearanceHeader.Options.UseFont = true;
            this.colntan.AppearanceHeader.Options.UseTextOptions = true;
            this.colntan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colntan.Caption = "Ngày báo ăn";
            this.colntan.FieldName = "ntan";
            this.colntan.MaxWidth = 90;
            this.colntan.Name = "colntan";
            this.colntan.OptionsColumn.ReadOnly = true;
            this.colntan.Visible = true;
            this.colntan.VisibleIndex = 4;
            this.colntan.Width = 90;
            // 
            // colthu
            // 
            this.colthu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colthu.AppearanceCell.Options.UseFont = true;
            this.colthu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colthu.AppearanceHeader.Options.UseFont = true;
            this.colthu.AppearanceHeader.Options.UseTextOptions = true;
            this.colthu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colthu.Caption = "Thứ";
            this.colthu.FieldName = "thu";
            this.colthu.MaxWidth = 70;
            this.colthu.Name = "colthu";
            this.colthu.OptionsColumn.ReadOnly = true;
            this.colthu.Visible = true;
            this.colthu.VisibleIndex = 5;
            this.colthu.Width = 70;
            // 
            // coltuanthu
            // 
            this.coltuanthu.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltuanthu.AppearanceCell.Options.UseFont = true;
            this.coltuanthu.AppearanceCell.Options.UseTextOptions = true;
            this.coltuanthu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltuanthu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coltuanthu.AppearanceHeader.Options.UseFont = true;
            this.coltuanthu.AppearanceHeader.Options.UseTextOptions = true;
            this.coltuanthu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltuanthu.Caption = "Tuần thứ";
            this.coltuanthu.FieldName = "tuanthu";
            this.coltuanthu.MaxWidth = 80;
            this.coltuanthu.Name = "coltuanthu";
            this.coltuanthu.OptionsColumn.ReadOnly = true;
            this.coltuanthu.Visible = true;
            this.coltuanthu.VisibleIndex = 6;
            // 
            // colBS1
            // 
            this.colBS1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colBS1.AppearanceCell.Options.UseFont = true;
            this.colBS1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colBS1.AppearanceHeader.Options.UseFont = true;
            this.colBS1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBS1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBS1.Caption = "Bữa sáng";
            this.colBS1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colBS1.FieldName = "BS1";
            this.colBS1.MaxWidth = 70;
            this.colBS1.Name = "colBS1";
            this.colBS1.Visible = true;
            this.colBS1.VisibleIndex = 7;
            this.colBS1.Width = 70;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colBC1
            // 
            this.colBC1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colBC1.AppearanceCell.Options.UseFont = true;
            this.colBC1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colBC1.AppearanceHeader.Options.UseFont = true;
            this.colBC1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBC1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBC1.Caption = "Bữa trưa";
            this.colBC1.ColumnEdit = this.repositoryItemCheckEdit2;
            this.colBC1.FieldName = "BC1";
            this.colBC1.MaxWidth = 70;
            this.colBC1.Name = "colBC1";
            this.colBC1.Visible = true;
            this.colBC1.VisibleIndex = 8;
            this.colBC1.Width = 70;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // colBT1
            // 
            this.colBT1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBT1.AppearanceCell.Options.UseFont = true;
            this.colBT1.AppearanceCell.Options.UseTextOptions = true;
            this.colBT1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBT1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colBT1.AppearanceHeader.Options.UseFont = true;
            this.colBT1.AppearanceHeader.Options.UseTextOptions = true;
            this.colBT1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBT1.Caption = "Bữa tối";
            this.colBT1.ColumnEdit = this.repositoryItemCheckEdit3;
            this.colBT1.FieldName = "BT1";
            this.colBT1.MaxWidth = 70;
            this.colBT1.Name = "colBT1";
            this.colBT1.Visible = true;
            this.colBT1.VisibleIndex = 9;
            this.colBT1.Width = 70;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // colGC
            // 
            this.colGC.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGC.AppearanceCell.Options.UseFont = true;
            this.colGC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colGC.AppearanceHeader.Options.UseFont = true;
            this.colGC.AppearanceHeader.Options.UseTextOptions = true;
            this.colGC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGC.Caption = "Ghi chú";
            this.colGC.FieldName = "GC";
            this.colGC.Name = "colGC";
            this.colGC.Visible = true;
            this.colGC.VisibleIndex = 10;
            // 
            // colidbaoan
            // 
            this.colidbaoan.Caption = "idbaoan";
            this.colidbaoan.FieldName = "idbaoan";
            this.colidbaoan.Name = "colidbaoan";
            // 
            // colMA
            // 
            this.colMA.Caption = "MA";
            this.colMA.FieldName = "MA";
            this.colMA.Name = "colMA";
            // 
            // frmnhapbaoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 504);
            this.Controls.Add(this.grcKQ);
            this.Controls.Add(this.grpdshs);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmnhapbaoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life - Nhập báo ăn hàng ngày cho học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmnhapbaoan_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmnhapbaoan_FormClosed);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.grpdshs.ResumeLayout(false);
            this.grpdshs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbtXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtTroGiup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbtThoat;
        private System.Windows.Forms.GroupBox grpdshs;
        private System.Windows.Forms.MaskedTextBox txtntanb;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox cbtenphongb;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevExpress.XtraGrid.GridControl grcKQ;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colmshs;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhs;
        private DevExpress.XtraGrid.Columns.GridColumn coltenphong;
        private DevExpress.XtraGrid.Columns.GridColumn colntan;
        private DevExpress.XtraGrid.Columns.GridColumn colthu;
        private DevExpress.XtraGrid.Columns.GridColumn colBS1;
        private DevExpress.XtraGrid.Columns.GridColumn colBC1;
        private DevExpress.XtraGrid.Columns.GridColumn colBT1;
        private DevExpress.XtraGrid.Columns.GridColumn colGC;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevComponents.DotNetBar.LabelX lbmucan;
        private DevExpress.XtraGrid.Columns.GridColumn coltuanthu;
        private DevExpress.XtraGrid.Columns.GridColumn colidbaoan;
        private DevExpress.XtraGrid.Columns.GridColumn colMA;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}