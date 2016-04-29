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
    public partial class frmDMKhoanThu : DevComponents.DotNetBar.Office2007Form
    {
        int SoBG = 0;

        public frmDMKhoanThu()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            grcKQ.DataSource = Connect.Loadgrc("Select * From dmthu");    
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
            if (e.KeyCode == Keys.Enter && grBDMPB.Visible == true)
            {
                LuuDL();
            }
        }

        private void ThemMoi()
        {
            SoBG = grvKQ.FocusedRowHandle;
            grcKQ.Enabled = false;
            grBDMPB.Visible = true;            
            txtiddmthu.EditValue = "";
            txtmakhthu.EditValue = "";
            txttenkhoanthu.EditValue = "";
            txtsoluong.EditValue = "";
            txtsotien.EditValue = "";
            txtmakhthu.Focus();
        }        

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete * From dmthu Where iddmthu = " + grvKQ.GetFocusedRowCellValue(coliddmthu).ToString();
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
            LuuDL();
        }
        private void LuuDL()
        {
            if (txtiddmthu.Text.Length == 0)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Insert into dmthu (makhthu, tenkhoanthu,soluong,sotien) values(@makhthu, @tenkhoanthu,@soluong,@sotien)";
                cmd.Parameters.Add("@makhthu", OleDbType.VarChar).Value = txtmakhthu.Text;
                cmd.Parameters.Add("@tenkhoanthu", OleDbType.VarChar).Value = txttenkhoanthu.Text;
                cmd.Parameters.Add("@soluong", OleDbType.VarChar).Value = txtsoluong.Text;
                cmd.Parameters.Add("@sotien", OleDbType.VarChar).Value = txtsotien.Text;
                Connect.LuuDL(cmd);
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Update dmthu set makhthu=@makhthu, tenkhoanthu=@tenkhoanthu,soluong=@soluong,sotien=@sotien" +
                                      " Where iddmthu = " + txtiddmthu.Text;

                cmd.Parameters.Add("@makhthu", OleDbType.VarChar).Value = txtmakhthu.Text;
                cmd.Parameters.Add("@tenkhoanthu", OleDbType.VarChar).Value = txttenkhoanthu.Text;
                cmd.Parameters.Add("@soluong", OleDbType.VarChar).Value = txtsoluong.Text;
                cmd.Parameters.Add("@sotien", OleDbType.VarChar).Value = txtsotien.Text;
                Connect.LuuDL(cmd);
            }
            grBDMPB.Visible = false;
            grcKQ.Enabled = true;
            grcKQ.DataSource = Connect.Loadgrc("Select * From dmthu");
            grvKQ.MoveBy(SoBG);
        }

        private void grvKQ_DoubleClick(object sender, EventArgs e)
        {
            SoBG = grvKQ.FocusedRowHandle;
            grcKQ.Enabled = false;
            grBDMPB.Visible = true;
            txtiddmthu.EditValue = grvKQ.GetFocusedRowCellValue(coliddmthu);
            txtmakhthu.EditValue = grvKQ.GetFocusedRowCellValue(colmakhthu);
            txttenkhoanthu.EditValue = grvKQ.GetFocusedRowCellValue(coltenkhoanthu);
            txtsoluong.EditValue = grvKQ.GetFocusedRowCellValue(colsoluong);
            txtsotien.EditValue = grvKQ.GetFocusedRowCellValue(colsotien);
            txtmakhthu.Focus();
        }

        private void frmDMKho_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}