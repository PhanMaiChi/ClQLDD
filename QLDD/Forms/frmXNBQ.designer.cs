namespace KPBT.Forms
{
    partial class frmXNBQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXNBQ));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gPanelDangNhap = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblPassError = new System.Windows.Forms.Label();
            this.lblUserError = new System.Windows.Forms.Label();
            this.rImageDangNhap = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.gPanelDangNhap.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gPanelDangNhap
            // 
            this.gPanelDangNhap.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPanelDangNhap.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gPanelDangNhap.Controls.Add(this.lblPassError);
            this.gPanelDangNhap.Controls.Add(this.lblUserError);
            this.gPanelDangNhap.Controls.Add(this.rImageDangNhap);
            this.gPanelDangNhap.Controls.Add(this.buttonX1);
            this.gPanelDangNhap.Controls.Add(this.buttonX2);
            this.gPanelDangNhap.Controls.Add(this.labelX1);
            this.gPanelDangNhap.Controls.Add(this.labelX2);
            this.gPanelDangNhap.Controls.Add(this.txtPassword);
            this.gPanelDangNhap.Controls.Add(this.txtUsername);
            this.gPanelDangNhap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPanelDangNhap.Location = new System.Drawing.Point(12, 47);
            this.gPanelDangNhap.Name = "gPanelDangNhap";
            this.gPanelDangNhap.Size = new System.Drawing.Size(399, 154);
            // 
            // 
            // 
            this.gPanelDangNhap.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPanelDangNhap.Style.BackColorGradientAngle = 90;
            this.gPanelDangNhap.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPanelDangNhap.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelDangNhap.Style.BorderBottomWidth = 1;
            this.gPanelDangNhap.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPanelDangNhap.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelDangNhap.Style.BorderLeftWidth = 1;
            this.gPanelDangNhap.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelDangNhap.Style.BorderRightWidth = 1;
            this.gPanelDangNhap.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanelDangNhap.Style.BorderTopWidth = 1;
            this.gPanelDangNhap.Style.CornerDiameter = 4;
            this.gPanelDangNhap.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPanelDangNhap.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gPanelDangNhap.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPanelDangNhap.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gPanelDangNhap.TabIndex = 228;
            this.gPanelDangNhap.Text = "Thông tin bản quyền phần mềm";
            // 
            // lblPassError
            // 
            this.lblPassError.AutoSize = true;
            this.lblPassError.BackColor = System.Drawing.Color.Transparent;
            this.lblPassError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassError.ForeColor = System.Drawing.Color.Red;
            this.lblPassError.Location = new System.Drawing.Point(167, 80);
            this.lblPassError.Name = "lblPassError";
            this.lblPassError.Size = new System.Drawing.Size(0, 13);
            this.lblPassError.TabIndex = 5;
            // 
            // lblUserError
            // 
            this.lblUserError.AutoSize = true;
            this.lblUserError.BackColor = System.Drawing.Color.Transparent;
            this.lblUserError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserError.ForeColor = System.Drawing.Color.Red;
            this.lblUserError.Location = new System.Drawing.Point(167, 40);
            this.lblUserError.Name = "lblUserError";
            this.lblUserError.Size = new System.Drawing.Size(0, 13);
            this.lblUserError.TabIndex = 5;
            // 
            // rImageDangNhap
            // 
            this.rImageDangNhap.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.rImageDangNhap.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.rImageDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("rImageDangNhap.Image")));
            this.rImageDangNhap.Location = new System.Drawing.Point(5, 15);
            this.rImageDangNhap.Name = "rImageDangNhap";
            this.rImageDangNhap.Size = new System.Drawing.Size(65, 78);
            this.rImageDangNhap.TabIndex = 0;
            this.rImageDangNhap.Tag = ".";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonX1.ForeColor = System.Drawing.Color.Yellow;
            this.buttonX1.Location = new System.Drawing.Point(232, 92);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Hủy bỏ";
            this.buttonX1.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonX2.ForeColor = System.Drawing.Color.Yellow;
            this.buttonX2.Location = new System.Drawing.Point(136, 92);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "Đăng ký";
            this.buttonX2.UseWaitCursor = true;
            this.buttonX2.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(76, 55);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Xác nhận:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(76, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(98, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã bản quyền:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Location = new System.Drawing.Point(189, 55);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(187, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.WatermarkText = "XXX-XXX-XXX";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtUsername.Border.Class = "TextBoxBorder";
            this.txtUsername.Location = new System.Drawing.Point(189, 15);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 23);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.WatermarkText = "XXX-XXX-XXX";
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(12, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(399, 34);
            this.labelX3.TabIndex = 229;
            this.labelX3.Text = "XÁC NHẬN BẢN QUYỀN PHẦN MỀM";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 204);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(399, 33);
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
            this.groupPanel1.TabIndex = 230;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(5, 1);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(385, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Chọn ô mã bản quyền - Nhấn phím F8 để chọn file bản quyền";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmXNBQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 243);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.gPanelDangNhap);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmXNBQ";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận bản quyền phần mềm";
            this.Load += new System.EventHandler(this.frmXNBQ_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmXNBQ_FormClosed);
            this.gPanelDangNhap.ResumeLayout(false);
            this.gPanelDangNhap.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.Controls.GroupPanel gPanelDangNhap;
        public System.Windows.Forms.Label lblPassError;
        public System.Windows.Forms.Label lblUserError;
        private DevComponents.DotNetBar.Controls.ReflectionImage rImageDangNhap;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        public DevComponents.DotNetBar.Controls.TextBoxX txtUsername;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}