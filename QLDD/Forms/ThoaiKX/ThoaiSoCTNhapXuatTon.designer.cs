namespace KPBT.Forms.ThoaiKX
{
    partial class ThoaiSoCTNhapXuatTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThoaiSoCTNhapXuatTon));
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNTDen = new DevExpress.XtraEditors.DateEdit();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtpNTTu = new DevExpress.XtraEditors.DateEdit();
            this.lumatp = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTDen.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTTu.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumatp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(184, 141);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(68, 31);
            this.button15.TabIndex = 2;
            this.button15.Text = "Hủy bỏ";
            this.button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.Location = new System.Drawing.Point(63, 141);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 31);
            this.button16.TabIndex = 1;
            this.button16.Text = "Tạo sổ";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // labelX15
            // 
            this.labelX15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX15.Location = new System.Drawing.Point(13, 77);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(92, 17);
            this.labelX15.TabIndex = 306;
            this.labelX15.Text = "Mặt hàng:";
            // 
            // labelX22
            // 
            this.labelX22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX22.Location = new System.Drawing.Point(13, 23);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(106, 17);
            this.labelX22.TabIndex = 318;
            this.labelX22.Text = "Từ ngày:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNTDen);
            this.groupBox3.Controls.Add(this.labelX1);
            this.groupBox3.Controls.Add(this.dtpNTTu);
            this.groupBox3.Controls.Add(this.labelX22);
            this.groupBox3.Controls.Add(this.lumatp);
            this.groupBox3.Controls.Add(this.labelX15);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 113);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // dtpNTDen
            // 
            this.dtpNTDen.EditValue = null;
            this.dtpNTDen.Location = new System.Drawing.Point(74, 49);
            this.dtpNTDen.Name = "dtpNTDen";
            this.dtpNTDen.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dtpNTDen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNTDen.Properties.Appearance.Options.UseFont = true;
            this.dtpNTDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNTDen.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpNTDen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNTDen.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpNTDen.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNTDen.Properties.Mask.EditMask = "";
            this.dtpNTDen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpNTDen.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpNTDen.Size = new System.Drawing.Size(181, 22);
            this.dtpNTDen.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(13, 51);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 17);
            this.labelX1.TabIndex = 322;
            this.labelX1.Text = "Đến ngày:";
            // 
            // dtpNTTu
            // 
            this.dtpNTTu.EditValue = null;
            this.dtpNTTu.Location = new System.Drawing.Point(74, 21);
            this.dtpNTTu.Name = "dtpNTTu";
            this.dtpNTTu.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dtpNTTu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNTTu.Properties.Appearance.Options.UseFont = true;
            this.dtpNTTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNTTu.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpNTTu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNTTu.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpNTTu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNTTu.Properties.Mask.EditMask = "";
            this.dtpNTTu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpNTTu.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpNTTu.Size = new System.Drawing.Size(181, 22);
            this.dtpNTTu.TabIndex = 0;
            // 
            // lumatp
            // 
            this.lumatp.Location = new System.Drawing.Point(74, 74);
            this.lumatp.Name = "lumatp";
            this.lumatp.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lumatp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumatp.Properties.Appearance.Options.UseFont = true;
            this.lumatp.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumatp.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lumatp.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lumatp.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lumatp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lumatp.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("matp", "matp", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tentp", "Tên thực phẩm")});
            this.lumatp.Properties.DropDownRows = 10;
            this.lumatp.Properties.NullText = "";
            this.lumatp.Properties.PopupWidth = 200;
            this.lumatp.Properties.ShowFooter = false;
            this.lumatp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lumatp.Size = new System.Drawing.Size(181, 22);
            this.lumatp.TabIndex = 2;
            this.lumatp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lumatp_KeyDown);
            // 
            // ThoaiSoCTNhapXuatTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 193);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThoaiSoCTNhapXuatTon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sổ chi tiết nhập xuất tồn theo mặt hàng";
            this.Load += new System.EventHandler(this.ThoaiSoQTM_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThoaiSoCTNhapXuatTon_FormClosed);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTDen.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTTu.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lumatp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX22;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.DateEdit dtpNTTu;
        private DevExpress.XtraEditors.DateEdit dtpNTDen;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraEditors.LookUpEdit lumatp;
    }
}