namespace KPBT.Forms
{
    partial class frmTDSKHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTDSKHS));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtIn = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtTroGiup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtThoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ckbHS = new System.Windows.Forms.CheckBox();
            this.cbtenphongb = new System.Windows.Forms.ComboBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.MtbNTDG = new System.Windows.Forms.MaskedTextBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.grcKQ = new DevExpress.XtraGrid.GridControl();
            this.grvKQ = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmshs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenhs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgths = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colntns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colsothangtuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidhs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchieucao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcannang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldanhgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.toolStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.toolStrip2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
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
            this.toolStrip2.Size = new System.Drawing.Size(834, 25);
            this.toolStrip2.TabIndex = 9;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(87, 22);
            this.toolStripButton2.Text = "Lưu dữ liệu";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.tbtIn.Size = new System.Drawing.Size(50, 22);
            this.tbtIn.Text = "In";
            this.tbtIn.Visible = false;
            this.tbtIn.ButtonClick += new System.EventHandler(this.tbtIn_ButtonClick);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.ckbHS);
            this.groupBox1.Controls.Add(this.cbtenphongb);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.MtbNTDG);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 46);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(619, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(121, 21);
            this.labelX1.TabIndex = 287;
            this.labelX1.Text = "Toàn bộ học sinh";
            this.labelX1.Visible = false;
            // 
            // ckbHS
            // 
            this.ckbHS.AutoSize = true;
            this.ckbHS.Location = new System.Drawing.Point(598, 16);
            this.ckbHS.Name = "ckbHS";
            this.ckbHS.Size = new System.Drawing.Size(15, 14);
            this.ckbHS.TabIndex = 2;
            this.ckbHS.UseVisualStyleBackColor = true;
            this.ckbHS.Visible = false;
            // 
            // cbtenphongb
            // 
            this.cbtenphongb.FormattingEnabled = true;
            this.cbtenphongb.Location = new System.Drawing.Point(419, 12);
            this.cbtenphongb.Name = "cbtenphongb";
            this.cbtenphongb.Size = new System.Drawing.Size(146, 23);
            this.cbtenphongb.TabIndex = 1;
            this.cbtenphongb.SelectedIndexChanged += new System.EventHandler(this.cbtenphongb_SelectedIndexChanged);
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(373, 11);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(40, 21);
            this.labelX7.TabIndex = 284;
            this.labelX7.Text = "Lớp:";
            // 
            // MtbNTDG
            // 
            this.MtbNTDG.Location = new System.Drawing.Point(191, 12);
            this.MtbNTDG.Mask = "##/##/####";
            this.MtbNTDG.Name = "MtbNTDG";
            this.MtbNTDG.Size = new System.Drawing.Size(134, 22);
            this.MtbNTDG.TabIndex = 0;
            this.MtbNTDG.Leave += new System.EventHandler(this.MtbNTDG_Leave);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(82, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(122, 21);
            this.labelX3.TabIndex = 278;
            this.labelX3.Text = "Ngày đánh giá:";
            // 
            // grcKQ
            // 
            this.grcKQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grcKQ.Location = new System.Drawing.Point(8, 80);
            this.grcKQ.MainView = this.grvKQ;
            this.grcKQ.Name = "grcKQ";
            this.grcKQ.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemDateEdit1});
            this.grcKQ.Size = new System.Drawing.Size(822, 328);
            this.grcKQ.TabIndex = 12;
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
            this.coltenphong,
            this.coltenhs,
            this.colgths,
            this.colntns,
            this.colsothangtuoi,
            this.colidhs,
            this.colchieucao,
            this.colcannang,
            this.coldanhgia,
            this.colid});
            this.grvKQ.GridControl = this.grcKQ;
            this.grvKQ.Name = "grvKQ";
            this.grvKQ.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.grvKQ.OptionsView.ColumnAutoWidth = false;
            this.grvKQ.OptionsView.EnableAppearanceEvenRow = true;
            this.grvKQ.OptionsView.EnableAppearanceOddRow = true;
            this.grvKQ.OptionsView.ShowGroupPanel = false;
            this.grvKQ.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.grvKQ_FocusedColumnChanged);
            this.grvKQ.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvKQ_CellValueChanged);
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
            this.colSTT.OptionsColumn.TabStop = false;
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
            this.colmshs.Caption = "Mã số HS";
            this.colmshs.FieldName = "TEN1";
            this.colmshs.MaxWidth = 90;
            this.colmshs.MinWidth = 90;
            this.colmshs.Name = "colmshs";
            this.colmshs.OptionsColumn.AllowEdit = false;
            this.colmshs.OptionsColumn.ReadOnly = true;
            this.colmshs.OptionsColumn.TabStop = false;
            this.colmshs.Width = 90;
            // 
            // coltenphong
            // 
            this.coltenphong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coltenphong.AppearanceCell.Options.UseFont = true;
            this.coltenphong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coltenphong.AppearanceHeader.Options.UseFont = true;
            this.coltenphong.AppearanceHeader.Options.UseTextOptions = true;
            this.coltenphong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coltenphong.Caption = "Lớp";
            this.coltenphong.FieldName = "TEN2";
            this.coltenphong.Name = "coltenphong";
            this.coltenphong.OptionsColumn.AllowEdit = false;
            this.coltenphong.OptionsColumn.ReadOnly = true;
            this.coltenphong.OptionsColumn.TabStop = false;
            this.coltenphong.Visible = true;
            this.coltenphong.VisibleIndex = 2;
            this.coltenphong.Width = 100;
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
            this.coltenhs.FieldName = "TEN3";
            this.coltenhs.MaxWidth = 150;
            this.coltenhs.Name = "coltenhs";
            this.coltenhs.OptionsColumn.AllowEdit = false;
            this.coltenhs.OptionsColumn.TabStop = false;
            this.coltenhs.Visible = true;
            this.coltenhs.VisibleIndex = 1;
            this.coltenhs.Width = 150;
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
            this.colgths.FieldName = "TEN4";
            this.colgths.MaxWidth = 50;
            this.colgths.Name = "colgths";
            this.colgths.OptionsColumn.AllowEdit = false;
            this.colgths.OptionsColumn.ReadOnly = true;
            this.colgths.OptionsColumn.TabStop = false;
            this.colgths.Visible = true;
            this.colgths.VisibleIndex = 3;
            this.colgths.Width = 50;
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
            this.colntns.ColumnEdit = this.repositoryItemDateEdit1;
            this.colntns.FieldName = "NTCT";
            this.colntns.MaxWidth = 90;
            this.colntns.Name = "colntns";
            this.colntns.OptionsColumn.AllowEdit = false;
            this.colntns.OptionsColumn.ReadOnly = true;
            this.colntns.OptionsColumn.TabStop = false;
            this.colntns.Visible = true;
            this.colntns.VisibleIndex = 4;
            this.colntns.Width = 90;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // colsothangtuoi
            // 
            this.colsothangtuoi.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colsothangtuoi.AppearanceCell.Options.UseFont = true;
            this.colsothangtuoi.AppearanceCell.Options.UseTextOptions = true;
            this.colsothangtuoi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsothangtuoi.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colsothangtuoi.AppearanceHeader.Options.UseFont = true;
            this.colsothangtuoi.Caption = "Số tháng tuổi";
            this.colsothangtuoi.FieldName = "TEN6";
            this.colsothangtuoi.Name = "colsothangtuoi";
            this.colsothangtuoi.OptionsColumn.AllowEdit = false;
            this.colsothangtuoi.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colsothangtuoi.OptionsColumn.ReadOnly = true;
            this.colsothangtuoi.OptionsColumn.TabStop = false;
            this.colsothangtuoi.OptionsFilter.AllowFilter = false;
            this.colsothangtuoi.Visible = true;
            this.colsothangtuoi.VisibleIndex = 5;
            this.colsothangtuoi.Width = 80;
            // 
            // colidhs
            // 
            this.colidhs.Caption = "idhs";
            this.colidhs.FieldName = "idhs";
            this.colidhs.Name = "colidhs";
            // 
            // colchieucao
            // 
            this.colchieucao.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colchieucao.AppearanceCell.Options.UseFont = true;
            this.colchieucao.AppearanceCell.Options.UseTextOptions = true;
            this.colchieucao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colchieucao.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colchieucao.AppearanceHeader.Options.UseFont = true;
            this.colchieucao.AppearanceHeader.Options.UseTextOptions = true;
            this.colchieucao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colchieucao.Caption = "Chiều cao";
            this.colchieucao.FieldName = "SL1";
            this.colchieucao.Name = "colchieucao";
            this.colchieucao.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colchieucao.OptionsFilter.AllowFilter = false;
            this.colchieucao.Visible = true;
            this.colchieucao.VisibleIndex = 6;
            this.colchieucao.Width = 80;
            // 
            // colcannang
            // 
            this.colcannang.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannang.AppearanceCell.Options.UseFont = true;
            this.colcannang.AppearanceCell.Options.UseTextOptions = true;
            this.colcannang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colcannang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.colcannang.AppearanceHeader.Options.UseFont = true;
            this.colcannang.AppearanceHeader.Options.UseTextOptions = true;
            this.colcannang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcannang.Caption = "Cân nặng";
            this.colcannang.FieldName = "SL2";
            this.colcannang.Name = "colcannang";
            this.colcannang.Visible = true;
            this.colcannang.VisibleIndex = 7;
            this.colcannang.Width = 80;
            // 
            // coldanhgia
            // 
            this.coldanhgia.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coldanhgia.AppearanceCell.Options.UseFont = true;
            this.coldanhgia.AppearanceCell.Options.UseTextOptions = true;
            this.coldanhgia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coldanhgia.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.coldanhgia.AppearanceHeader.Options.UseFont = true;
            this.coldanhgia.AppearanceHeader.Options.UseTextOptions = true;
            this.coldanhgia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldanhgia.Caption = "Đánh giá";
            this.coldanhgia.FieldName = "TEN7";
            this.coldanhgia.Name = "coldanhgia";
            this.coldanhgia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldanhgia.OptionsColumn.ReadOnly = true;
            this.coldanhgia.OptionsColumn.TabStop = false;
            this.coldanhgia.OptionsFilter.AllowFilter = false;
            this.coldanhgia.Visible = true;
            this.coldanhgia.VisibleIndex = 8;
            this.coldanhgia.Width = 250;
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "TEN8";
            this.colid.Name = "colid";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemTextEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemTextEdit1.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemTextEdit1.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "d";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTextEdit1.EditFormat.FormatString = "d";
            this.repositoryItemTextEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // frmTDSKHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 420);
            this.Controls.Add(this.grcKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTDSKHS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi sức khỏe của học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTDSKHS_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTDSKHS_FormClosed);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbtXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton tbtIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtTroGiup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbtThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MtbNTDG;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox cbtenphongb;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevExpress.XtraGrid.GridControl grcKQ;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKQ;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colmshs;
        private DevExpress.XtraGrid.Columns.GridColumn coltenphong;
        private DevExpress.XtraGrid.Columns.GridColumn coltenhs;
        private DevExpress.XtraGrid.Columns.GridColumn colgths;
        private DevExpress.XtraGrid.Columns.GridColumn colntns;
        private DevExpress.XtraGrid.Columns.GridColumn colsothangtuoi;
        private DevExpress.XtraGrid.Columns.GridColumn colidhs;
        private DevExpress.XtraGrid.Columns.GridColumn colchieucao;
        private DevExpress.XtraGrid.Columns.GridColumn colcannang;
        private DevExpress.XtraGrid.Columns.GridColumn coldanhgia;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.CheckBox ckbHS;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}