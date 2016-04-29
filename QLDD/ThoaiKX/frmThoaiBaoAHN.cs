using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Office;
using DevComponents.DotNetBar;
using KPBT.Modules;
using System.Data.OleDb;

namespace KPBT.ThoaiKX
{
    public partial class frmThoaiBaoAHN : Office2007Form
    {
        public frmThoaiBaoAHN()
        {
            InitializeComponent();
        }

        private void frmThoaiLuuMTAn_Load(object sender, EventArgs e)
        {            
            cboThang.Text = "";
            cboTuan.Text = "";
            cboNam.Text = "";
        }
        
        private void appDC()
        {
            string sql = "insert into TblDC (NTCT,TEN1) " +
                " Select ntan,tenphong From baoan" +
                " Where Month(ntan) = '" + cboThang.Text + "' and Year(ntan) = '" + cboNam.Text + "' and tuanthu = " + Convert.ToInt32(cboTuan.Text) + "" +
                " Group by ntan,tenphong";                
            Connect.ThaoTac(sql);            
        }
        private double chamcom( string tuan,string tenphong,string ntan)
        {
            double kq = 0;
            string sql = "Select Sum([BS]) +Sum([BT])+Sum([BC]) as An From baoan where Month(ntan) = '" + cboThang.Text + "' and" +
            " tenphong = '" + tenphong + "' and year(ntan) = '" + cboNam.Text + "' and ntan = #" + classdc.dungchung.thaydoi(ntan) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        private double TongXAN(string tuan, string ntan)
        {
            double kq = 0;
            string sql = "Select Sum([BS]) +Sum([BT])+Sum([BC]) as An From baoan where ntan = #" + classdc.dungchung.thaydoi(ntan) + "#";            
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }       
        private void upDC()
        {            
            OleDbDataReader dr = Connect.TruyVandr("select * From TblDC");
            while (dr.Read())
            {
                string sqlup = "Update TblDC set SL1 = @SL1,SL2= @SL2 where NTCT = #" + classdc.dungchung.thaydoi(dr["NTCT"].ToString()) + "# and TEN1 = '" + dr["TEN1"].ToString() + "'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sqlup;
                cmd.Parameters.Add("@SL1", OleDbType.Double).Value = chamcom(cboTuan.Text, dr["TEN1"].ToString(), dr["NTCT"].ToString());
                cmd.Parameters.Add("@SL2", OleDbType.Double).Value = TongXAN(cboTuan.Text, dr["NTCT"].ToString());                
                Connect.LuuDL(cmd);                
            }
            dr.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboThang.Text != "" && cboNam.Text != "" && cboTuan.Text != "")
            {
                Connect.ThaoTac("Delete * From TblDC");
                appDC();
                upDC();
                DataSet dts = new DataSet();
                Connect.Loadds(dts, "Select * From TblDC", "TblDC");
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.BaoAHN rpt = new KPBT.Reports.BaoAHN();
                rpt.TenDV.Value = Thongtinketxuat.Default.TenDV.ToString();
                rpt.TNDN.Value = "Tuần: " ;
                //rpt.HTHT.Value = Thongtinketxuat.Default.HTHT.ToString();
                //rpt.HTGVND.Value = Thongtinketxuat.Default.HTGVND.ToString();
                rpt.DataSource = dts;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn tuần, tháng, năm muốn kết xuất!", "Thông báo");
            }
        }        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
