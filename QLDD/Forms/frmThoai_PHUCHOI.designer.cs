namespace KPBT.Forms
{
    partial class frmThoai_PHUCHOI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThoai_PHUCHOI));
            this.txtSAOLUU = new System.Windows.Forms.TextBox();
            this.txtVUNGLV = new System.Windows.Forms.TextBox();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_chonnam = new System.Windows.Forms.Button();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // txtSAOLUU
            // 
            this.txtSAOLUU.Enabled = false;
            this.txtSAOLUU.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAOLUU.Location = new System.Drawing.Point(98, 41);
            this.txtSAOLUU.Name = "txtSAOLUU";
            this.txtSAOLUU.Size = new System.Drawing.Size(259, 22);
            this.txtSAOLUU.TabIndex = 30;
            // 
            // txtVUNGLV
            // 
            this.txtVUNGLV.Enabled = false;
            this.txtVUNGLV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVUNGLV.Location = new System.Drawing.Point(98, 67);
            this.txtVUNGLV.Name = "txtVUNGLV";
            this.txtVUNGLV.Size = new System.Drawing.Size(259, 22);
            this.txtVUNGLV.TabIndex = 32;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("bt_Thoat.Image")));
            this.bt_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Thoat.Location = new System.Drawing.Point(249, 118);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(75, 29);
            this.bt_Thoat.TabIndex = 35;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_chonnam
            // 
            this.bt_chonnam.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chonnam.Image = ((System.Drawing.Image)(resources.GetObject("bt_chonnam.Image")));
            this.bt_chonnam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chonnam.Location = new System.Drawing.Point(56, 118);
            this.bt_chonnam.Name = "bt_chonnam";
            this.bt_chonnam.Size = new System.Drawing.Size(81, 29);
            this.bt_chonnam.TabIndex = 34;
            this.bt_chonnam.Text = "Phục hồi";
            this.bt_chonnam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_chonnam.UseVisualStyleBackColor = true;
            this.bt_chonnam.Click += new System.EventHandler(this.bt_chonnam_Click);
            // 
            // labelX5
            // 
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(10, 42);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(82, 17);
            this.labelX5.TabIndex = 259;
            this.labelX5.Text = "Vùng sao lưu:";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(10, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(82, 17);
            this.labelX1.TabIndex = 260;
            this.labelX1.Text = "Vùng làm việc:";
            // 
            // frmThoai_PHUCHOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 170);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_chonnam);
            this.Controls.Add(this.txtVUNGLV);
            this.Controls.Add(this.txtSAOLUU);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThoai_PHUCHOI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phục hồi dữ liệu từ vùng sao lưu";
            this.Load += new System.EventHandler(this.Thoai_PHUCHOI_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThoai_PHUCHOI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSAOLUU;
        private System.Windows.Forms.TextBox txtVUNGLV;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_chonnam;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}