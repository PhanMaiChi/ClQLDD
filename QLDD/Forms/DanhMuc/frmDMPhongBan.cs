using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KPBT.Modules;
using System.Data.OleDb;

namespace KPBT.Forms.DanhMuc
{
    public partial class frmDMPhongBan : DevComponents.DotNetBar.Office2007Form
    {
        int SoBG = 0;

        public frmDMPhongBan()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            grcKQ.DataSource = Connect.Loadgrc("Select * From phong");
            loptren();
        }              

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ThemMoi();
            }
            if (e.KeyCode == Keys.Escape && grBDMPB.Visible==true)
            {
                grBDMPB.Visible = false;
                grcKQ.Enabled = true;
            }
        }

        private void ThemMoi()
        {
            SoBG = grvKQ.FocusedRowHandle;
            grcKQ.Enabled = false;
            grBDMPB.Visible = true;            
            txtidsophong.EditValue = "";
            txttenphong.EditValue = "";
            txtttkhac.EditValue = "";
            cbonhatre.EditValue = "";
            txttenphong.Focus();
            loptren();
        }
        private Boolean check()
        {
            string sql = "Select * From hocsinh where tenphong = '" + grvKQ.GetFocusedRowCellValue(coltenphong).ToString() + "'";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            if (dr.Read())
                return true;
            else
                return false;
        }

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (check() == true)
                {
                    MessageBox.Show("Lớp học đã có học sinh. Bạn không thể xóa lớp này. Bạn hãy thực hiện chuyển học sinh sang lớp khác trước khi xóa!", "Thông báo");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "Delete * From phong Where idsophong = " + grvKQ.GetFocusedRowCellValue(colidsophong).ToString();
                    Connect.LuuDL(cmd);

                    int So = grvKQ.FocusedRowHandle;
                    if (So == (grvKQ.RowCount - 1))
                        grvKQ.MovePrev();
                    grvKQ.DeleteRow(So);
                    if (grvKQ.RowCount > 0)
                        for (int i = 0; i < grvKQ.RowCount; i++)
                            grvKQ.SetRowCellValue(i, colSTT, i + 1);
                }
            }
        }
        private void loptren()
        {
            Connect.Reconnect();
            DataTable dt = Connect.TruyVandt("Select tenphong from phong");            
            DataRow dtRow = dt.NewRow();
            dtRow["tenphong"] = "cuối cấp";
            dt.Rows.Add(dtRow);
            cboLoptren.Properties.Items.Clear();
            Connect.LoadCBB(cboLoptren, "tenphong", dt);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            ThemMoi();            
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            grBDMPB.Visible = false;
            grcKQ.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (txtidsophong.Text.Length == 0)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Insert into phong (tenphong, ttkhac,nhatre,loptren) values(@tenphong, @ttkhac,@nhatre,@loptren)";
                cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = txttenphong.Text;
                cmd.Parameters.Add("@ttkhac", OleDbType.VarChar).Value = txtttkhac.Text;
                cmd.Parameters.Add("@nhatre", OleDbType.VarChar).Value = cbonhatre.Text;
                cmd.Parameters.Add("@loptren", OleDbType.VarChar).Value = cboLoptren.Text;
                Connect.LuuDL(cmd);
            }
            else
            {
                if (txttenlopcu.Text != txttenphong.Text && check() == true)
                {
                    if (MessageBox.Show("Lớp học đã có học sinh. Bạn có muốn chuyển tất cả học sinh, cán bộ sang lớp mới trước khi thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        chuyenbaoan();
                        chuyencanbo();
                        chuyendshs();
                        luu();
                    }
                }
                else
                {
                    luu();
                }
            }
            grBDMPB.Visible = false;
            grcKQ.Enabled = true;
            grcKQ.DataSource = Connect.Loadgrc("Select * From phong");
            grvKQ.MoveBy(SoBG);
        }

        private void luu()
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "Update phong set tenphong=@tenphong, ttkhac=@ttkhac,nhatre=@nhatre,loptren=@loptren" +
                                  " Where idsophong = " + txtidsophong.Text;

            cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = txttenphong.Text;
            cmd.Parameters.Add("@ttkhac", OleDbType.VarChar).Value = txtttkhac.Text;
            cmd.Parameters.Add("@nhatre", OleDbType.VarChar).Value = cbonhatre.Text;
            cmd.Parameters.Add("@loptren", OleDbType.VarChar).Value = cboLoptren.Text;
            Connect.LuuDL(cmd);
        }

        #region chuyển học sinh sang lớp khác
        private void chuyendshs()
        {
            string sqldk = "Select * From hocsinh where tenphong = '" + txttenlopcu.EditValue + "'";
            OleDbDataReader dr = Connect.TruyVandr(sqldk);
            while (dr.Read())
            {
                string sql = "Update hocsinh set tenphong = @tenphong where idhs = " + Convert.ToInt64(dr["idhs"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = txttenphong.EditValue;
                Connect.LuuDL(cmd);
            }
            dr.Close();
        }
        private void chuyenbaoan()
        {
            string sqldk = "Select * From baoan where tenphong = '" + txttenlopcu.EditValue + "'";
            OleDbDataReader dr = Connect.TruyVandr(sqldk);
            while (dr.Read())
            {
                string sql = "Update baoan set tenphong = @tenphong where idbaoan = " + Convert.ToInt64(dr["idbaoan"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = txttenphong.EditValue;
                Connect.LuuDL(cmd);
            }
            dr.Close();
        }
        private void chuyencanbo()
        {
            string sqldk = "Select * From canbo where phongban = '" + txttenlopcu.EditValue + "'";
            OleDbDataReader dr = Connect.TruyVandr(sqldk);
            while (dr.Read())
            {
                string sql = "Update canbo set phongban = @phongban where idcanbo = " + Convert.ToInt64(dr["idcanbo"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                cmd.Parameters.Add("@phongban", OleDbType.VarChar).Value = txttenphong.EditValue;
                Connect.LuuDL(cmd);
            }
            dr.Close();
        }
        #endregion

        private void grvKQ_DoubleClick(object sender, EventArgs e)
        {
            loptren();
            SoBG = grvKQ.FocusedRowHandle;
            grcKQ.Enabled = false;
            grBDMPB.Visible = true;
            txtidsophong.EditValue = grvKQ.GetFocusedRowCellValue(colidsophong);
            txttenphong.EditValue = grvKQ.GetFocusedRowCellValue(coltenphong);
            txtttkhac.EditValue = grvKQ.GetFocusedRowCellValue(colttkhac);
            cbonhatre.EditValue = grvKQ.GetFocusedRowCellValue(colnhatre);
            cboLoptren.EditValue = grvKQ.GetFocusedRowCellValue(colLoptren);
            txttenlopcu.EditValue = grvKQ.GetFocusedRowCellValue(coltenphong);
        }

        private void frmDMPhongBan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frm = new frmChuyenHS();
            frm.Show();
        }
    }
}