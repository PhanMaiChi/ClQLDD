using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace KPBT.Forms
{
    public partial class frmThoai_PHUCHOI : Office2007Form
    {
        public frmThoai_PHUCHOI()
        {
            InitializeComponent();
        }

        private void Thoai_PHUCHOI_Load(object sender, EventArgs e)
        {
            txtSAOLUU.Text = Settings1.Default.thumucdich.ToString() + "QLDDbackup.mdb";
            txtVUNGLV.Text = Settings1.Default.thumucgoc.ToString();
        }

        private void bt_chonnam_Click(object sender, EventArgs e)
        {
            try
            {                
                System.IO.File.Copy(txtSAOLUU.Text, txtVUNGLV.Text, true);
                MessageBox.Show("Dữ liệu đã được phục hồi vào " + txtVUNGLV.Text, "Thông báo");
            }
            catch
            {
                MessageBox.Show("Phục hồi bị lỗi, hãy kiểm trả dữ liệu phục hồi!","Thông báo");
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThoai_PHUCHOI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}
