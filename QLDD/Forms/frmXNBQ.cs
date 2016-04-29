using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using KPBT.Modules;

namespace KPBT.Forms
{
    public partial class frmXNBQ : Office2007Form
    {
        DataTable dt = new DataTable();        
        public frmXNBQ()
        {
            InitializeComponent();            
        }

        private void frmXNBQ_Load(object sender, EventArgs e)
        {
            Modules.DC1.TaoBQ(dt);            
            Modules.DC1.capbanquyen(dt);            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
            //Modules.clk.i = 0;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string kq = "";
            if (txtUsername.Text == txtPassword.Text)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (clsbqkpbt.banquyen.macanlay(i, dt) == txtPassword.Text)
                    {
                        kq = "C";
                        if (MessageBox.Show("Tên đơn vị: " + clsbqkpbt.banquyen.tencanlay(i, dt) + ". Bạn có đồng ý hay không!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            string sql = "Update ttdv Set tenct=@tenct,mqhns=@mqhns";
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = sql;
                            cmd.Parameters.Add("@tenct", OleDbType.VarChar).Value = clsbqkpbt.banquyen.tencoquancanlay(i, dt);
                            cmd.Parameters.Add("@mqhns", OleDbType.VarChar).Value = clsbqkpbt.banquyen.maqhns(i, dt);
                            Connect.LuuDL(cmd);
                            thongtinketxuat.Default.tendv = clsbqkpbt.banquyen.tencanlay(i, dt);
                            thongtinketxuat.Default.Save();
                            thongtinketxuat.Default.tenct = clsbqkpbt.banquyen.tencoquancanlay(i, dt);
                            thongtinketxuat.Default.Save();
                            thongtinketxuat.Default.madvqhns = clsbqkpbt.banquyen.maqhns(i, dt);
                            thongtinketxuat.Default.Save();
                            this.Visible = false;
                            Form frm = new KPBT.Forms.NhapTTDV();
                            frm.ShowDialog();
                            this.Close();
                            //MessageBox.Show("Quá trình đăng ký đã thành công. Bạn hãy khởi động lại chương trình để vào nhập dữ liệu!", "Thông báo");
                            //this.Close();
                            break;
                        }
                    }
                    else
                    {
                        kq = "";
                    }
                }
                if (kq == "")
                    MessageBox.Show("Mã bản quyền không hợp lệ!","Thông báo");
            }
            else
            {
                MessageBox.Show("Bạn cần gõ chính xác mã bản quyền của đơn vị!","Thông báo");
            }            
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                OpenFileDialog fd = new OpenFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamReader myFile = new System.IO.StreamReader(fd.FileName.ToString());
                    string myString = myFile.ReadToEnd();
                    txtUsername.Text = myString;
                }
            }
        }

        private void frmXNBQ_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog fd = new OpenFileDialog();
        //    if (fd.ShowDialog() == DialogResult.OK)
        //    {
        //        System.IO.StreamReader myFile = new System.IO.StreamReader(fd.FileName.ToString());
        //        string myString = myFile.ReadToEnd();
        //        MessageBox.Show("a: " + myString);
        //    }
        //}
    }
}
