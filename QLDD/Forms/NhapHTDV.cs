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
using System.Threading;

namespace KPBT.Forms
{
    public partial class NhapHTDV : Office2007Form
    {  
        public string decimalChar = "";        
        public NhapHTDV()
        {
            InitializeComponent();           
        }

        private void NhapHTDV_Load(object sender, EventArgs e)
        {
            decimalChar = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (decimalChar == ".")
                decimalChar = ","; 
            txttendv.Text = thongtinketxuat.Default.tendv.ToString();
            txttenct.Text = thongtinketxuat.Default.tenct.ToString();           
            loadtt();
        }        
        private void loadtt()
        {
            string sql = "Select * From ttdv";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                txtdcdv.Text = dr["dcdv"].ToString();
                txtttdv.Text = dr["ttdv"].ToString();
                txtnlb.Text = dr["nlb"].ToString();
                txtketoan.Text = dr["ketoan"].ToString();                
                txtkttruong.Text = dr["kttruong"].ToString();
                txtthukho.Text = dr["thukho"].ToString();
                txtnnhanhang.Text = dr["nnhanhang"].ToString();
                Mtbnkxden.Text = dr["nkxden"].ToString();
                Mtbnkxtu.Text = dr["nkxtu"].ToString();
                txtmqhns.Text = dr["mqhns"].ToString();
                txtMA.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(dr["MA"].ToString()));
                txtthuquy.Text = dr["thuquy"].ToString();
                txtdiadanh.Text = dr["diadanh"].ToString();
                txtMASANG.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(dr["MASANG"].ToString()));
                txtMATOI.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(dr["MATOI"].ToString()));
                txtMUCHT.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(dr["MUCHT"].ToString()));
                cboNamhoc.Text = dr["Namhoc"].ToString();
            }
            dr.Close();
        }       

        private void labelX21_Click(object sender, EventArgs e)
        {
            this.Close();
        }           

        private void txtMaDVSDNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        private void txtTENCQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTENCT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }        

        private void labelX20_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Update ttdv Set dcdv=@dcdv,nlb=@nlb,nnhanhang=@nnhanhang,thukho=@thukho,"+
                    " ketoan=@ketoan,kttruong=@kttruong,ttdv=@ttdv,thuquy=@thuquy,MA=@MA,nkxtu=@nkxtu,nkxden=@nkxden,"+
                    " mqhns=@mqhns,diadanh=@diadanh,MASANG=@MASANG,MATOI=@MATOI,MUCHT=@MUCHT,Namhoc=@Namhoc";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@dcdv", OleDbType.VarChar).Value = txtdcdv.Text;
                cmd.Parameters.Add("@nlb", OleDbType.VarChar).Value = txtnlb.Text;
                cmd.Parameters.Add("@nnhanhang", OleDbType.VarChar).Value = txtnnhanhang.Text;
                cmd.Parameters.Add("@thukho", OleDbType.VarChar).Value = txtthukho.Text;
                cmd.Parameters.Add("@ketoan", OleDbType.VarChar).Value = txtketoan.Text;
                cmd.Parameters.Add("@kttruong", OleDbType.VarChar).Value = txtkttruong.Text;
                cmd.Parameters.Add("@ttdv", OleDbType.VarChar).Value = txtttdv.Text;
                cmd.Parameters.Add("@thuquy", OleDbType.VarChar).Value = txtthuquy.Text;
                cmd.Parameters.Add("@MA", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtMA.Text);
                cmd.Parameters.Add("@nkxtu", OleDbType.Date).Value = classdc.dungchung.thaydoi(Mtbnkxtu.Text);
                cmd.Parameters.Add("@nkxden", OleDbType.Date).Value = classdc.dungchung.thaydoi(Mtbnkxden.Text);
                cmd.Parameters.Add("@mqhns", OleDbType.VarChar).Value = txtmqhns.Text;
                cmd.Parameters.Add("@diadanh", OleDbType.VarChar).Value = txtdiadanh.Text;
                cmd.Parameters.Add("@MASANG", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtMASANG.Text);
                cmd.Parameters.Add("@MATOI", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtMATOI.Text);
                cmd.Parameters.Add("@MUCHT", OleDbType.Double).Value = classdc.dungchung.kieudouble(txtMUCHT.Text);
                cmd.Parameters.Add("@Namhoc", OleDbType.VarChar).Value = cboNamhoc.Text;
                Connect.LuuDL(cmd);                
                thongtinketxuat.Default.diadanh = txtdiadanh.Text;
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.nlb = txtnlb.Text;
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.ttdv = txtttdv.Text;
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.ptkt = txtketoan.Text;
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.NTT = Mtbnkxtu.Text;
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.NTD = Mtbnkxden.Text;
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.thukho = txtthukho.Text;
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.thuquy = txtthuquy.Text;
                thongtinketxuat.Default.Save();
                thongtinketxuat.Default.namhoc = cboNamhoc.Text;
                thongtinketxuat.Default.Save();
                Settings1.Default.mucan = txtMA.Text;
                Settings1.Default.Save();
                Settings1.Default.mucansang = txtMASANG.Text;
                Settings1.Default.Save();
                Settings1.Default.mucantoi = txtMATOI.Text;
                Settings1.Default.Save();
                Settings1.Default.mucanht = txtMUCHT.Text;
                Settings1.Default.Save();
                MessageBox.Show("Bạn đã cập nhật thành công", "Thông báo");                
            }
            catch
            {
                MessageBox.Show("Lấy lại bảng hệ thống!", "Thống báo");
            }
        }

        private void txtMHTT_TextChanged(object sender, EventArgs e)
        {
            //txtMHTT.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(txtMHTT.Text));
            //SendKeys.Send("{End}");
        }

        private void txtMA_TextChanged(object sender, EventArgs e)
        {
            txtMA.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(txtMA.Text));
            SendKeys.Send("{End}");
        }

        private void Mtbnkxtu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar < 48) || (e.KeyChar > 57))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }

        private void Mtbnkxtu_Leave(object sender, EventArgs e)
        {
            try
            {
                Mtbnkxtu.Text = clsbqkpbt.banquyen.dtngaysinh(Mtbnkxtu.Text);
            }
            catch
            {
                Mtbnkxtu.Text = "";
            }
        }

        private void Mtbnkxden_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                if ((e.KeyChar < 48) || (e.KeyChar > 57))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }

        private void Mtbnkxden_Leave(object sender, EventArgs e)
        {
            try
            {
                Mtbnkxden.Text = clsbqkpbt.banquyen.dtngaysinh(Mtbnkxden.Text);
            }
            catch
            {
                Mtbnkxden.Text = "";
            }
        }

        private void NhapHTDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void txtMASANG_TextChanged(object sender, EventArgs e)
        {
            txtMASANG.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(txtMASANG.Text));
            SendKeys.Send("{End}");
        }

        private void txtMATOI_TextChanged(object sender, EventArgs e)
        {
            txtMATOI.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(txtMATOI.Text));
            SendKeys.Send("{End}");
        }

        private void txtMUCHT_TextChanged(object sender, EventArgs e)
        {
            txtMUCHT.Text = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(txtMUCHT.Text));
            SendKeys.Send("{End}");
        }
    }
}
