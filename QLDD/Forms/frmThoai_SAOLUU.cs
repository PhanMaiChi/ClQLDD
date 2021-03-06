using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KPBT.Modules;
using DevComponents.DotNetBar;

namespace KPBT.Forms
{
    public partial class frmThoai_SAOLUU : Office2007Form
    {
        public string dl = "";
        public frmThoai_SAOLUU()
        {
            InitializeComponent();
        }
       
        private void Thoai_SAOLUU_Load(object sender, EventArgs e)
        {
            lbfilemau.Text = "Đường dẫn file: " + Settings1.Default.thumucgoc.ToString() + Settings1.Default.namgoc.ToString();
            lbtm.Text = "Đường dẫn thư mục: " + Settings1.Default.thumucdich.ToString();
        }

        private void labelX8_Click(object sender, EventArgs e)
        {
            string vung = "", namdl = "";
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dl = fd.FileName.ToString();
                if (dl.IndexOf(".mdb") == -1)
                {
                    MessageBox.Show("Không tồn tại năm dữ liệu", "Thông báo");
                }
                else
                {
                    if (dl.IndexOf("QLDD.mdb") != -1)
                    {
                        MessageBox.Show("Đây là năm dữ liệu mẫu bạn không thể chọn đựơc!", "Thông báo");
                    }
                    else
                    {
                        vung = dl.Substring(0, dl.Length - 12);
                        namdl = dl.Substring(dl.Length - 12, 12);                        
                    }
                }
                lbfilemau.Text = "Đường dẫn file: " + dl;
                Settings1.Default.thumucgoc = vung;
                Settings1.Default.Save();
                Settings1.Default.namgoc = namdl;
                Settings1.Default.Save();
            }
        }

        private void labelX7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog tm = new FolderBrowserDialog();
            if (tm.ShowDialog() == DialogResult.OK)
            {
                lbtm.Text = "Đường dẫn thư mục: " + tm.SelectedPath.ToString();
            }
            Settings1.Default.thumucdich = tm.SelectedPath.ToString();
            Settings1.Default.Save();
        }

        private void labelX4_Click(object sender, EventArgs e)
        {
            try
            {
                string pathlv = "";
                pathlv = Settings1.Default.thumucdich.ToString() + @"/QLDDbackup.mdb";
                System.IO.File.Copy(dl, pathlv, true);
                MessageBox.Show("Năm dữ liệu đã được sao lưu vào " + Settings1.Default.thumucdich.ToString(), "Thông báo");
            }
            catch
            {
                MessageBox.Show("Hãy kiểm tra lại các thông tin!","Thông báo");
            }
        }

        private void labelX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThoai_SAOLUU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }        
    }
}