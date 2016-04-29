namespace KPBT.Forms.ThoaiKX
{
    partial class frmThoaiLuuMTAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThoaiLuuMTAn));
            this.MtbNgayTT = new System.Windows.Forms.MaskedTextBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.MtbNgayTD = new System.Windows.Forms.MaskedTextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MtbNgayTT
            // 
            this.MtbNgayTT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbNgayTT.Location = new System.Drawing.Point(125, 13);
            this.MtbNgayTT.Mask = "##/##/####";
            this.MtbNgayTT.Name = "MtbNgayTT";
            this.MtbNgayTT.Size = new System.Drawing.Size(150, 22);
            this.MtbNgayTT.TabIndex = 277;
            this.MtbNgayTT.Leave += new System.EventHandler(this.MktNgayTT_Leave);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(12, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(96, 21);
            this.labelX3.TabIndex = 276;
            this.labelX3.Text = "Ngày tháng từ:";
            // 
            // MtbNgayTD
            // 
            this.MtbNgayTD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbNgayTD.Location = new System.Drawing.Point(125, 40);
            this.MtbNgayTD.Mask = "##/##/####";
            this.MtbNgayTD.Name = "MtbNgayTD";
            this.MtbNgayTD.Size = new System.Drawing.Size(150, 22);
            this.MtbNgayTD.TabIndex = 279;
            this.MtbNgayTD.Leave += new System.EventHandler(this.MtbNgayTD_Leave);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 39);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 21);
            this.labelX1.TabIndex = 278;
            this.labelX1.Text = "Ngày tháng đến:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(39, 83);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 28);
            this.btnOK.TabIndex = 280;
            this.btnOK.Text = "Tạo bảng";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(180, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 281;
            this.btnClose.Text = "Thoát";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmThoaiLuuMTAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 128);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.MtbNgayTD);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.MtbNgayTT);
            this.Controls.Add(this.labelX3);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThoaiLuuMTAn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lưu mẫu thức ăn";
            this.Load += new System.EventHandler(this.frmThoaiLuuMTAn_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThoaiLuuMTAn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MtbNgayTT;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.MaskedTextBox MtbNgayTD;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;

    }
}