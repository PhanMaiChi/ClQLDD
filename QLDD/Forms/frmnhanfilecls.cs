using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevComponents.DotNetBar;
using KPBT.Modules;
using System.Threading;

namespace KPBT.Forms
{
    public partial class frmnhanfilecls : Office2007Form
    {
        public frmnhanfilecls()
        {
            InitializeComponent();
        }

        private void frmnhanfilecls_Load(object sender, EventArgs e)
        {
            grDD.Visible = false;
        }

        private void tbtLuu_Click(object sender, EventArgs e)
        {
            grDD.Visible = true; ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grDD.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHT.Text = txtHT.Text.ToUpper();
            txtGT.Text = txtGT.Text.ToUpper();
            txtNS.Text = txtNS.Text.ToUpper();
            txtPH.Text = txtPH.Text.ToUpper();
            txtDT.Text = txtDT.Text.ToUpper();
            txtDC.Text = txtDC.Text.ToUpper();
            txtHT.Text = txtHT.Text.ToUpper();            
            grDD.Visible = false;
        }

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            ConvertFont.Convertfont cvt = new ConvertFont.Convertfont();
            int j = 0;
            string hoten = "";
            string tenfile = "";
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (fd.FileName.ToString().IndexOf(".xls") == -1)
                    MessageBox.Show("Không tồn tại file dữ liệu!", "Thông báo");
                else
                    tenfile = fd.FileName.ToString();
                try
                {
                    Microsoft.Office.Interop.Excel.Application oXL;
                    Microsoft.Office.Interop.Excel._Workbook oWB;
                    Microsoft.Office.Interop.Excel._Worksheet oSheet;
                    oXL = new Microsoft.Office.Interop.Excel.Application();
                    oXL.Visible = false;
                    System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                    oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Open(tenfile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing));
                    oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.Sheets[txtsheet.Text];
                    //string a = oSheet.Name;
                    for (int i = Convert.ToInt32(txtBDD.Text); i <= Convert.ToInt32(txtSD.Text); i++)
                    {
                        try
                        {
                            hoten = classdc.dungchung.xuly(Class1.CvrtUni(oSheet.get_Range(txtHT.Text + i.ToString(), txtHT.Text + i.ToString()).Text.ToString()));
                        }
                        catch
                        {
                            hoten = "";
                        }
                        if (hoten != "")
                        {
                            j = j + 1;
                            ListViewItem lv = new ListViewItem();
                            lv.Text = j.ToString();
                            lv.SubItems.Add(hoten);
                            try
                            {
                                lv.SubItems.Add(Class1.CvrtUni(oSheet.get_Range(txtGT.Text + i.ToString(), txtGT.Text + i.ToString()).Text.ToString()));
                            }
                            catch
                            {
                                lv.SubItems.Add("");
                            }
                            try
                            {
                                lv.SubItems.Add(Class1.CvrtUni(oSheet.get_Range(txtNS.Text + i.ToString(), txtNS.Text + i.ToString()).Text.ToString()));
                            }
                            catch
                            {
                                lv.SubItems.Add("");
                            }
                            try
                            {
                                lv.SubItems.Add(Class1.CvrtUni(oSheet.get_Range(txtDT.Text + i.ToString(), txtDT.Text + i.ToString()).Text.ToString()));
                            }
                            catch
                            {
                                lv.SubItems.Add("");
                            }
                            try
                            {
                                lv.SubItems.Add(Class1.CvrtUni(oSheet.get_Range(txtDC.Text + i.ToString(), txtDC.Text + i.ToString()).Text.ToString()));
                            }
                            catch
                            {
                                lv.SubItems.Add("");
                            }
                            try
                            {
                                lv.SubItems.Add(Class1.CvrtUni(oSheet.get_Range(txtPH.Text + i.ToString(), txtPH.Text + i.ToString()).Text.ToString()));
                            }
                            catch
                            {
                                lv.SubItems.Add("");
                            }
                            try
                            {
                                lv.SubItems.Add(Class1.CvrtUni(oSheet.get_Range(txtHTR.Text + i.ToString(), txtHTR.Text + i.ToString()).Text.ToString()));
                            }
                            catch
                            {
                                lv.SubItems.Add("");
                            }
                            lvDSDT.Items.Add(lv);
                        }
                        hoten = "";
                    }
                    MessageBox.Show("Hãy kiểm tra sự trùng lặp dữ liêu trước khi nhân về!", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Có lỗi, hay kiểm tra lại các thông tin đầu vào!", "Thông báo");
                    tenfile = "";
                }
            }
        }

        private void tbtIn_Click(object sender, EventArgs e)
        {            
            for (int i = 0; i < lvDSDT.Items.Count; i++)
            {
                try
                {
                    string sql = "Insert into hocsinh(mshs,tenhs,ntns,datoc,dchs,tenphong,gths,ht) values(@mshs,@tenhs,@ntns,@datoc,@dchs,@tenphong,@gths,@ht)";
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = Connect.TaoMSHS();
                    cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = lvDSDT.Items[i].SubItems[1].Text;
                    cmd.Parameters.Add("@ntns", OleDbType.VarChar).Value = lvDSDT.Items[i].SubItems[3].Text;
                    cmd.Parameters.Add("@datoc", OleDbType.VarChar).Value = lvDSDT.Items[i].SubItems[4].Text;
                    cmd.Parameters.Add("@dchs", OleDbType.VarChar).Value = lvDSDT.Items[i].SubItems[5].Text;
                    cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = lvDSDT.Items[i].SubItems[6].Text;
                    cmd.Parameters.Add("@gths", OleDbType.VarChar).Value = lvDSDT.Items[i].SubItems[2].Text;
                    cmd.Parameters.Add("@ht", OleDbType.VarChar).Value = "Đi học";
                    Connect.LuuDL(cmd);
                }
                catch
                {
                }
            }
            MessageBox.Show("Đã nhận xong dữ liệu!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmnhanfilecls_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                lvDSDT.SelectedItems[0].Remove();
            }
            catch
            {
            }
        }
    }
}
