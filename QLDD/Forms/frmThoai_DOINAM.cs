using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KPBT.Modules;
using DevComponents.DotNetBar;
using System.Data.OleDb;

namespace KPBT.Forms
{
    public partial class frmThoai_DOINAM : Office2007Form
    {        
        public string dl = "";
        public frmThoai_DOINAM()
        {
            InitializeComponent();            
        }      

        private void Thoai_DOINAM_Load(object sender, EventArgs e)
        {
            lbfilemau.Text = "Đường dẫn thư muc: " + Settings1.Default.thumucdoi.ToString();
            lbtm.Text = "Dữ liệu làm việc: " + Settings1.Default.namdoi.ToString();
        }

        private void labelX3_Click(object sender, EventArgs e)
        {
            if (dl.IndexOf("QLDD") == -1)
            {
                MessageBox.Show("Đây không phải là csdl, bạn chọn lại", "Thông báo");
            }
            else
            {
                if (dl.IndexOf("QLDD.mdb") > 1)
                    MessageBox.Show("Đây là dữ liệu mẫu. Bạn hãy chọn lại dữ liệu làm việc!", "Thông báo");
                else
                {
                    Settings1.Default.namlv = dl;
                    Settings1.Default.Save();
                    DC1.namdllv = dl;
                    Connect.Reconnect();
                    if (Program.openfrm == "Cài đặt")
                    {
                        caidat();
                        luuTTDV();
                    }
                    else
                    {
                        luuTTDV();
                        MessageBox.Show("Bạn đã thay đổi thành công", "Thông báo");
                    }
                    this.Close();
                }
            }
        }

        private void caidat()
        {
            if (kt() == false)
            {
                this.Visible = false;
                Form frm = new KPBT.Forms.frmXNBQ();
                frm.ShowDialog();
            }
            else
            {
                Settings1.Default.dc = "Dc";
                Settings1.Default.Save();
                this.Visible = false;
                Form frm = new frmmain();
                frm.ShowDialog();
            }
        }

        private Boolean kt()
        {
            string kq = Connect.LayGT("Select * From ttdv where idttdv = 1", "tendv");
            if (kq == "")
                return false;
            else
                return true;
        }

        private void luuTTDV()
        {
            string sql = "Select * From ttdv";
            OleDbDataReader dr =  Connect.TruyVandr(sql);
            while (dr.Read())
            {
                thongtinketxuat.Default.diadanh = dr["diadanh"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.nlb = dr["nlb"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.ttdv = dr["ttdv"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.ptkt = dr["ketoan"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.NTT = dr["nkxtu"].ToString();
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.NTD = dr["nkxden"].ToString();
                thongtinketxuat.Default.Save();                
            }
            dr.Close();            
        }

        private void labelX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX7_Click(object sender, EventArgs e)
        {
            try
            {
                string vung = "", namdl = "";
                OpenFileDialog fd = new OpenFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    dl = fd.FileName.ToString();
                    if (dl.IndexOf(".mdb") == -1)
                    {
                        MessageBox.Show("Không tồn tại file dữ liệu", "Thông báo");
                    }
                    else
                    {
                        vung = dl.Substring(0, dl.Length - 12);
                        namdl = dl.Substring(dl.Length - 12, 12);
                    }
                    lbfilemau.Text = "Đường dẫn thư muc: " + vung;
                    lbtm.Text = "Dữ liệu làm việc: " + namdl;                    
                    Settings1.Default.thumucdoi = vung;
                    Settings1.Default.Save();
                    Settings1.Default.namdoi = namdl;
                    Settings1.Default.Save();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, bạn hãy chọn lại năm dữ liệu", "Thông báo");
            }
        }

        private void frmThoai_DOINAM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }        
    }
}