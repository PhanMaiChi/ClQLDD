using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using KPBT.Modules;
using System.Data.OleDb;

namespace KPBT.Forms
{
    public partial class frmTaonhomtuoi : Office2007Form
    {
        public DataTable dt = new DataTable();
        public frmTaonhomtuoi()
        {
            InitializeComponent();
        }

        private void frmTaonhomtuoi_Load(object sender, EventArgs e)
        {            
            dt = Connect.TruyVandt("Select * from tblchitietnhomtuoi");
            //grcMain.DataSource = dt;
            Connect.LoadDL(Lunhomtuoi, "MaNT", "TenNT", "Select * From tblnhomtuoi");
            Connect.LoadDL(Lubuaan, "TenBA","TenBA", "Select TenBA From tblbuaan");
        }
        private void loadDL()
        {
            grcMain.DataSource = Connect.Loadgrc("Select * From tblchitietnhomtuoi where MaNT = '" + Connect.GetStr(Lunhomtuoi.EditValue) + "'");
            //grcMain.DataSource = dt.Select("MaNT = '" + Connect.GetStr(Lunhomtuoi.EditValue) + "'");
        }

        private void Lunhomtuoi_EditValueChanged(object sender, EventArgs e)
        {
            grcMain.DataSource = dt.Select("MaNT = '" + Connect.GetStr(Lunhomtuoi.EditValue) + "'");
            loadDL();
        }

        private void Lunhomtuoi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                using (Form frm = new frmThoainhomtuoi())
                {
                    frm.ShowDialog();
                    Connect.LoadDL(Lunhomtuoi, "MaNT", "TenNT", "Select * From tblnhomtuoi");
                }
            }   
        }

        private void tbtLuu_Click(object sender, EventArgs e)
        {
            //try
            //{
                for (int i = 0; i < grvCT.RowCount - 1; i++)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "Update tblchitietnhomtuoi set nangluong=@nangluong,protein=@protein,chatbeo=@chatbeo,carbohydrat=@carbohydrat,dongia=@dongia" +
                        " where IDCTNT = " + Convert.ToInt64(Connect.GetStr(grvCT.GetRowCellValue(i, colIDCTNT)));
                    cmd.Parameters.Add("@nangluong", OleDbType.VarChar).Value = grvCT.GetRowCellValue(i, colnangluong);
                    cmd.Parameters.Add("@protein", OleDbType.VarChar).Value = grvCT.GetRowCellValue(i, colprotein);
                    cmd.Parameters.Add("@chatbeo", OleDbType.VarChar).Value = grvCT.GetRowCellValue(i, colchatbeo);
                    cmd.Parameters.Add("@carbohydrat", OleDbType.VarChar).Value = grvCT.GetRowCellValue(i, colcarbohydrat);
                    cmd.Parameters.Add("@dongia", OleDbType.VarChar).Value = grvCT.GetRowCellValue(i, coldongia);
                    Connect.LuuDL(cmd);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu. Bạn hãy kiểm tra lại dữ liệu nhập!", "Thông báo!");
            //}
        }

        Boolean Kiemtra(string buaan, string nhomtuoi)
        {
            Boolean kq = false;
            OleDbDataReader dr = Connect.TruyVandr("Select buaan From tblchitietnhomtuoi where MaNT = '" + nhomtuoi + "'");
            while (dr.Read())
            {
                if (dr["buaan"].ToString() == buaan)
                    kq = true;
            }
            dr.Close();
            return kq;
        }
        private void nhómTuổiHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect.Reconnect();
            OleDbDataReader dr = Connect.TruyVandr("Select * From tblbuaan where Theodoi = True");
            while (dr.Read())
            {
                if (Kiemtra(dr["TenBA"].ToString(),Connect.GetStr(Lunhomtuoi.EditValue)) == false)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "Insert into tblchitietnhomtuoi (MaNT,buaan) values (@MaNT,@buaan)";
                    cmd.Parameters.Add("@MaNT", OleDbType.VarChar).Value = Lunhomtuoi.EditValue;
                    cmd.Parameters.Add("@buaan", OleDbType.VarChar).Value = dr["TenBA"].ToString();
                    Connect.LuuDL(cmd);
                }
            }
            dr.Close();
            loadDL();
        }
        
        private void tấtCảCácNhómTuổiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect.Reconnect();
            OleDbDataReader drdk = Connect.TruyVandr("Select distinct MaNT From tblnhomtuoi");
            while (drdk.Read())
            {
                OleDbDataReader dr = Connect.TruyVandr("Select * From tblbuaan where Theodoi = True");
                while (dr.Read())
                {
                    if (Kiemtra(dr["TenBA"].ToString(), drdk["MaNT"].ToString()) == false)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Insert into tblchitietnhomtuoi (MaNT,buaan) values (@MaNT,@buaan)";
                        cmd.Parameters.Add("@MaNT", OleDbType.VarChar).Value = drdk["MaNT"].ToString();
                        cmd.Parameters.Add("@buaan", OleDbType.VarChar).Value = dr["TenBA"].ToString();
                        Connect.LuuDL(cmd);
                    }
                }
                dr.Close();
            }
            drdk.Close();
            loadDL();
        }

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            Modules.DC1.iform = 1;
            this.Dispose();
        }

        private void frmTaonhomtuoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void nhậpDanhMụcBữaĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Forms.DanhMuc.frmDMBA();
            //frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();             
        }

        private void tbtXoa_Click(object sender, EventArgs e)
        {
           
        }        
    }
}
