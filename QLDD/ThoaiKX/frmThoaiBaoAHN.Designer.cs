namespace KPBT.ThoaiKX
{
    partial class frmThoaiBaoAHN
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboTuan = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(46, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Tạo bảng";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(187, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboThang
            // 
            this.cboThang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(79, 41);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(70, 23);
            this.cboThang.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(20, 41);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 21);
            this.labelX2.TabIndex = 283;
            this.labelX2.Text = "Tháng:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(20, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(44, 21);
            this.labelX3.TabIndex = 289;
            this.labelX3.Text = "Tuần:";
            // 
            // cboTuan
            // 
            this.cboTuan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTuan.FormattingEnabled = true;
            this.cboTuan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboTuan.Location = new System.Drawing.Point(79, 12);
            this.cboTuan.Name = "cboTuan";
            this.cboTuan.Size = new System.Drawing.Size(204, 23);
            this.cboTuan.TabIndex = 0;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(164, 41);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(44, 21);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Năm:";
            // 
            // cboNam
            // 
            this.cboNam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cboNam.Location = new System.Drawing.Point(214, 41);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(69, 23);
            this.cboNam.TabIndex = 2;
            // 
            // frmThoaiBaoAHN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 117);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.cboTuan);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Name = "frmThoaiBaoAHN";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo ăn hàng ngày";
            this.Load += new System.EventHandler(this.frmThoaiLuuMTAn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboThang;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.ComboBox cboTuan;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox cboNam;

    }
}