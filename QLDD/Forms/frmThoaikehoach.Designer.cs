namespace KPBT.Forms
{
    partial class frmThoaikehoach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThoaikehoach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grcTP = new DevExpress.XtraGrid.GridControl();
            this.grvTPCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grcKH = new DevExpress.XtraGrid.GridControl();
            this.grvKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtngaythang = new DevExpress.XtraEditors.TextEdit();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cboNhomTuoi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboBuaan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTPCT)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKH)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtngaythang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomTuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBuaan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grcTP);
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 362);
            this.panel1.TabIndex = 0;
            // 
            // grcTP
            // 
            this.grcTP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grcTP.Location = new System.Drawing.Point(3, 3);
            this.grcTP.MainView = this.grvTPCT;
            this.grcTP.Name = "grcTP";
            this.grcTP.Size = new System.Drawing.Size(328, 351);
            this.grcTP.TabIndex = 310;
            this.grcTP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTPCT});
            // 
            // grvTPCT
            // 
            this.grvTPCT.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvTPCT.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvTPCT.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvTPCT.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvTPCT.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvTPCT.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grvTPCT.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grvTPCT.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grvTPCT.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvTPCT.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvTPCT.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvTPCT.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvTPCT.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grvTPCT.Appearance.Empty.Options.UseBackColor = true;
            this.grvTPCT.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvTPCT.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvTPCT.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvTPCT.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvTPCT.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvTPCT.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvTPCT.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvTPCT.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grvTPCT.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grvTPCT.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvTPCT.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvTPCT.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grvTPCT.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvTPCT.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvTPCT.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvTPCT.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvTPCT.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grvTPCT.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvTPCT.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvTPCT.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvTPCT.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvTPCT.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvTPCT.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvTPCT.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvTPCT.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvTPCT.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvTPCT.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvTPCT.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvTPCT.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvTPCT.Appearance.GroupButton.Options.UseForeColor = true;
            this.grvTPCT.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvTPCT.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvTPCT.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvTPCT.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvTPCT.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvTPCT.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grvTPCT.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvTPCT.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvTPCT.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvTPCT.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvTPCT.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grvTPCT.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvTPCT.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvTPCT.Appearance.GroupRow.Options.UseFont = true;
            this.grvTPCT.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvTPCT.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvTPCT.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvTPCT.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.grvTPCT.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvTPCT.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvTPCT.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvTPCT.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvTPCT.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvTPCT.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grvTPCT.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grvTPCT.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvTPCT.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvTPCT.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grvTPCT.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvTPCT.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grvTPCT.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.OddRow.Options.UseBackColor = true;
            this.grvTPCT.Appearance.OddRow.Options.UseForeColor = true;
            this.grvTPCT.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grvTPCT.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grvTPCT.Appearance.Preview.Options.UseBackColor = true;
            this.grvTPCT.Appearance.Preview.Options.UseForeColor = true;
            this.grvTPCT.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grvTPCT.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvTPCT.Appearance.Row.Options.UseBackColor = true;
            this.grvTPCT.Appearance.Row.Options.UseForeColor = true;
            this.grvTPCT.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grvTPCT.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvTPCT.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grvTPCT.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grvTPCT.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvTPCT.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvTPCT.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grvTPCT.Appearance.VertLine.Options.UseBackColor = true;
            this.grvTPCT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMA1,
            this.colTenMA1,
            this.colChon,
            this.colMaTD1});
            this.grvTPCT.GridControl = this.grcTP;
            this.grvTPCT.Name = "grvTPCT";
            this.grvTPCT.OptionsView.EnableAppearanceEvenRow = true;
            this.grvTPCT.OptionsView.EnableAppearanceOddRow = true;
            this.grvTPCT.OptionsView.ShowGroupPanel = false;
            this.grvTPCT.OptionsView.ShowIndicator = false;
            // 
            // colMaMA1
            // 
            this.colMaMA1.FieldName = "MaMA";
            this.colMaMA1.Name = "colMaMA1";
            // 
            // colTenMA1
            // 
            this.colTenMA1.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenMA1.AppearanceCell.Options.UseFont = true;
            this.colTenMA1.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenMA1.AppearanceHeader.Options.UseFont = true;
            this.colTenMA1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenMA1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenMA1.Caption = "Tên thực đơn/món ăn";
            this.colTenMA1.FieldName = "TenMA";
            this.colTenMA1.Name = "colTenMA1";
            this.colTenMA1.OptionsColumn.ReadOnly = true;
            this.colTenMA1.Visible = true;
            this.colTenMA1.VisibleIndex = 1;
            this.colTenMA1.Width = 126;
            // 
            // colChon
            // 
            this.colChon.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colChon.AppearanceHeader.Options.UseFont = true;
            this.colChon.AppearanceHeader.Options.UseTextOptions = true;
            this.colChon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChon.Caption = "Chọn";
            this.colChon.FieldName = "Chon";
            this.colChon.MaxWidth = 40;
            this.colChon.Name = "colChon";
            this.colChon.Visible = true;
            this.colChon.VisibleIndex = 0;
            this.colChon.Width = 40;
            // 
            // colMaTD1
            // 
            this.colMaTD1.Caption = "gridColumn1";
            this.colMaTD1.FieldName = "MaTD";
            this.colMaTD1.Name = "colMaTD1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grcKH);
            this.panel2.Location = new System.Drawing.Point(379, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 362);
            this.panel2.TabIndex = 1;
            // 
            // grcKH
            // 
            this.grcKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grcKH.Location = new System.Drawing.Point(3, 6);
            this.grcKH.MainView = this.grvKH;
            this.grcKH.Name = "grcKH";
            this.grcKH.Size = new System.Drawing.Size(343, 351);
            this.grcKH.TabIndex = 311;
            this.grcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKH});
            // 
            // grvKH
            // 
            this.grvKH.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvKH.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKH.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.grvKH.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.grvKH.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.grvKH.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grvKH.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.grvKH.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grvKH.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKH.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.grvKH.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.grvKH.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.grvKH.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.grvKH.Appearance.Empty.Options.UseBackColor = true;
            this.grvKH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.EvenRow.Options.UseBackColor = true;
            this.grvKH.Appearance.EvenRow.Options.UseForeColor = true;
            this.grvKH.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvKH.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKH.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.grvKH.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.grvKH.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.grvKH.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grvKH.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.grvKH.Appearance.FilterPanel.Options.UseBackColor = true;
            this.grvKH.Appearance.FilterPanel.Options.UseForeColor = true;
            this.grvKH.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.grvKH.Appearance.FixedLine.Options.UseBackColor = true;
            this.grvKH.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.grvKH.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.FocusedCell.Options.UseBackColor = true;
            this.grvKH.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvKH.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.grvKH.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.grvKH.Appearance.FocusedRow.Options.UseBackColor = true;
            this.grvKH.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvKH.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvKH.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKH.Appearance.FooterPanel.Options.UseBackColor = true;
            this.grvKH.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.grvKH.Appearance.FooterPanel.Options.UseForeColor = true;
            this.grvKH.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKH.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKH.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.GroupButton.Options.UseBackColor = true;
            this.grvKH.Appearance.GroupButton.Options.UseBorderColor = true;
            this.grvKH.Appearance.GroupButton.Options.UseForeColor = true;
            this.grvKH.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKH.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKH.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.GroupFooter.Options.UseBackColor = true;
            this.grvKH.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.grvKH.Appearance.GroupFooter.Options.UseForeColor = true;
            this.grvKH.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.grvKH.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.GroupPanel.Options.UseBackColor = true;
            this.grvKH.Appearance.GroupPanel.Options.UseForeColor = true;
            this.grvKH.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKH.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.grvKH.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grvKH.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.GroupRow.Options.UseBackColor = true;
            this.grvKH.Appearance.GroupRow.Options.UseBorderColor = true;
            this.grvKH.Appearance.GroupRow.Options.UseFont = true;
            this.grvKH.Appearance.GroupRow.Options.UseForeColor = true;
            this.grvKH.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.grvKH.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.grvKH.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.grvKH.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.grvKH.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.grvKH.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.grvKH.Appearance.HeaderPanel.Options.UseFont = true;
            this.grvKH.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.grvKH.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.grvKH.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.grvKH.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.grvKH.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.grvKH.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grvKH.Appearance.HorzLine.Options.UseBackColor = true;
            this.grvKH.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.grvKH.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.OddRow.Options.UseBackColor = true;
            this.grvKH.Appearance.OddRow.Options.UseForeColor = true;
            this.grvKH.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.grvKH.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.grvKH.Appearance.Preview.Options.UseBackColor = true;
            this.grvKH.Appearance.Preview.Options.UseForeColor = true;
            this.grvKH.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grvKH.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.grvKH.Appearance.Row.Options.UseBackColor = true;
            this.grvKH.Appearance.Row.Options.UseForeColor = true;
            this.grvKH.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.grvKH.Appearance.RowSeparator.Options.UseBackColor = true;
            this.grvKH.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.grvKH.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.grvKH.Appearance.SelectedRow.Options.UseBackColor = true;
            this.grvKH.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvKH.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.grvKH.Appearance.VertLine.Options.UseBackColor = true;
            this.grvKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMA,
            this.colTenMA,
            this.colMaTD,
            this.colIDKH});
            this.grvKH.GridControl = this.grcKH;
            this.grvKH.Name = "grvKH";
            this.grvKH.OptionsBehavior.ReadOnly = true;
            this.grvKH.OptionsView.EnableAppearanceEvenRow = true;
            this.grvKH.OptionsView.EnableAppearanceOddRow = true;
            this.grvKH.OptionsView.ShowGroupPanel = false;
            this.grvKH.OptionsView.ShowIndicator = false;
            // 
            // colMaMA
            // 
            this.colMaMA.FieldName = "MaMA";
            this.colMaMA.Name = "colMaMA";
            // 
            // colTenMA
            // 
            this.colTenMA.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenMA.AppearanceCell.Options.UseFont = true;
            this.colTenMA.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenMA.AppearanceHeader.Options.UseFont = true;
            this.colTenMA.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenMA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenMA.Caption = "Tên thực đơn/món ăn";
            this.colTenMA.FieldName = "TenMA";
            this.colTenMA.Name = "colTenMA";
            this.colTenMA.OptionsColumn.ReadOnly = true;
            this.colTenMA.Visible = true;
            this.colTenMA.VisibleIndex = 0;
            this.colTenMA.Width = 126;
            // 
            // colMaTD
            // 
            this.colMaTD.Caption = "gridColumn1";
            this.colMaTD.FieldName = "MaTD";
            this.colMaTD.Name = "colMaTD";
            // 
            // colIDKH
            // 
            this.colIDKH.Caption = "gridColumn1";
            this.colIDKH.FieldName = "IDKH";
            this.colIDKH.Name = "colIDKH";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelX3);
            this.panel3.Controls.Add(this.labelX2);
            this.panel3.Controls.Add(this.txtngaythang);
            this.panel3.Controls.Add(this.labelX1);
            this.panel3.Controls.Add(this.cboNhomTuoi);
            this.panel3.Controls.Add(this.cboBuaan);
            this.panel3.Location = new System.Drawing.Point(3, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(725, 43);
            this.panel3.TabIndex = 2;
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(235, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(67, 22);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Nhóm tuổi:";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(516, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(52, 22);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Bữa ăn:";
            // 
            // txtngaythang
            // 
            this.txtngaythang.Location = new System.Drawing.Point(105, 12);
            this.txtngaythang.Name = "txtngaythang";
            this.txtngaythang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaythang.Properties.Appearance.Options.UseFont = true;
            this.txtngaythang.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaythang.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtngaythang.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtngaythang.Size = new System.Drawing.Size(113, 22);
            this.txtngaythang.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(9, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 22);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Kế hoạch ngày:";
            // 
            // cboNhomTuoi
            // 
            this.cboNhomTuoi.Location = new System.Drawing.Point(308, 12);
            this.cboNhomTuoi.Name = "cboNhomTuoi";
            this.cboNhomTuoi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhomTuoi.Properties.Appearance.Options.UseFont = true;
            this.cboNhomTuoi.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhomTuoi.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboNhomTuoi.Properties.Items.AddRange(new object[] {
            "Nhà trẻ",
            "Mẫu giáo"});
            this.cboNhomTuoi.Properties.PopupSizeable = true;
            this.cboNhomTuoi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.cboNhomTuoi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboNhomTuoi.Size = new System.Drawing.Size(172, 22);
            this.cboNhomTuoi.TabIndex = 5;
            // 
            // cboBuaan
            // 
            this.cboBuaan.Location = new System.Drawing.Point(574, 12);
            this.cboBuaan.Name = "cboBuaan";
            this.cboBuaan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuaan.Properties.Appearance.Options.UseFont = true;
            this.cboBuaan.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuaan.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboBuaan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBuaan.Properties.Items.AddRange(new object[] {
            "Chính sáng",
            "Chính chiều",
            "Phụ"});
            this.cboBuaan.Properties.PopupSizeable = true;
            this.cboBuaan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboBuaan.Size = new System.Drawing.Size(141, 22);
            this.cboBuaan.TabIndex = 3;
            this.cboBuaan.EditValueChanged += new System.EventHandler(this.LuBuaan_EditValueChanged);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyen.Image")));
            this.btnChuyen.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnChuyen.Location = new System.Drawing.Point(340, 266);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(36, 40);
            this.btnChuyen.TabIndex = 314;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(340, 172);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(36, 40);
            this.simpleButton1.TabIndex = 315;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(340, 218);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(36, 40);
            this.simpleButton2.TabIndex = 316;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(217, 427);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(83, 29);
            this.buttonX1.TabIndex = 317;
            this.buttonX1.Text = "Lưu";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(325, 427);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(83, 29);
            this.buttonX2.TabIndex = 318;
            this.buttonX2.Text = "Lưu Thoát";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(430, 427);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(83, 29);
            this.buttonX3.TabIndex = 319;
            this.buttonX3.Text = "Thoát";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // frmThoaikehoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(730, 468);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThoaikehoach";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kế hoạch ăn của trẻ";
            this.Load += new System.EventHandler(this.frmThoaikehoach_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTPCT)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvKH)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtngaythang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomTuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBuaan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevExpress.XtraEditors.TextEdit txtngaythang;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl grcTP;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTPCT;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMA1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMA1;
        private DevExpress.XtraGrid.Columns.GridColumn colChon;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTD1;
        private DevExpress.XtraGrid.GridControl grcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMA;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMA;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTD;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKH;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevExpress.XtraEditors.ComboBoxEdit cboNhomTuoi;
        private DevExpress.XtraEditors.ComboBoxEdit cboBuaan;


    }
}