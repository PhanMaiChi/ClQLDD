﻿namespace KPBT.Forms.ThoaiKX
{
    partial class ThoaiTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThoaiTest));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dtpNTTu = new DevExpress.XtraEditors.DateEdit();
            this.dtpNTDen = new DevExpress.XtraEditors.DateEdit();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.Luhocsinh = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTTu.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTDen.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luhocsinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(16, 82);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 20);
            this.labelX1.TabIndex = 338;
            this.labelX1.Text = "Đến ngày:";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(16, 54);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(66, 20);
            this.labelX3.TabIndex = 337;
            this.labelX3.Text = "Từ ngày:";
            // 
            // dtpNTTu
            // 
            this.dtpNTTu.EditValue = null;
            this.dtpNTTu.Location = new System.Drawing.Point(88, 53);
            this.dtpNTTu.Name = "dtpNTTu";
            this.dtpNTTu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNTTu.Properties.Appearance.Options.UseFont = true;
            this.dtpNTTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNTTu.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpNTTu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNTTu.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpNTTu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNTTu.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpNTTu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpNTTu.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpNTTu.Properties.VistaTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpNTTu.Properties.VistaTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNTTu.Properties.VistaTimeProperties.EditFormat.FormatString = "d";
            this.dtpNTTu.Properties.VistaTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpNTTu.Size = new System.Drawing.Size(206, 22);
            this.dtpNTTu.TabIndex = 0;
            // 
            // dtpNTDen
            // 
            this.dtpNTDen.EditValue = null;
            this.dtpNTDen.Location = new System.Drawing.Point(88, 81);
            this.dtpNTDen.Name = "dtpNTDen";
            this.dtpNTDen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNTDen.Properties.Appearance.Options.UseFont = true;
            this.dtpNTDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNTDen.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpNTDen.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtpNTDen.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpNTDen.Size = new System.Drawing.Size(206, 22);
            this.dtpNTDen.TabIndex = 1;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button15.Location = new System.Drawing.Point(172, 121);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(69, 28);
            this.button15.TabIndex = 4;
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
            this.button16.Location = new System.Drawing.Point(56, 121);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(69, 28);
            this.button16.TabIndex = 3;
            this.button16.Text = "Tạo Sổ";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(19, 25);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(66, 20);
            this.labelX2.TabIndex = 339;
            this.labelX2.Text = "Học sinh:";
            // 
            // Luhocsinh
            // 
            this.Luhocsinh.Location = new System.Drawing.Point(88, 25);
            this.Luhocsinh.Name = "Luhocsinh";
            this.Luhocsinh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luhocsinh.Properties.Appearance.Options.UseFont = true;
            this.Luhocsinh.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Luhocsinh.Properties.AppearanceDropDown.Options.UseFont = true;
            this.Luhocsinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Luhocsinh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenhs", 120, "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenphong", 100, "Name2"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ntns", "Name3", 60, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Default)});
            this.Luhocsinh.Properties.NullText = "";
            this.Luhocsinh.Properties.PopupWidth = 350;
            this.Luhocsinh.Properties.ShowFooter = false;
            this.Luhocsinh.Properties.ShowHeader = false;
            this.Luhocsinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.Luhocsinh.Size = new System.Drawing.Size(206, 22);
            this.Luhocsinh.TabIndex = 340;
            // 
            // ThoaiTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 172);
            this.ControlBox = false;
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dtpNTDen);
            this.Controls.Add(this.dtpNTTu);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.Luhocsinh);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThoaiTest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sổ tính khẩu phần ăn";
            this.Load += new System.EventHandler(this.ThoaiSoQTM_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThoaiSoQTM_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTTu.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTDen.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNTDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luhocsinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private DevExpress.XtraEditors.DateEdit dtpNTTu;
        public DevExpress.XtraEditors.DateEdit dtpNTDen;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevExpress.XtraEditors.LookUpEdit Luhocsinh;
    }
}