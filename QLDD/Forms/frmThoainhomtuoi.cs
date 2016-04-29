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
    public partial class frmThoainhomtuoi : Office2007Form
    {
        public frmThoainhomtuoi()
        {
            InitializeComponent();
        }

        private void frmThoainhomtuoi_Load(object sender, EventArgs e)
        {
            grcMain.DataSource = Connect.Loadgrc("Select * From tblnhomtuoi");
            //txtMaNT.Text = Connect.TaoMa("NT", "Select * From tblnhomtuoi", "MaNT");            
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < grvCT.RowCount - 1; i++)
                {
                    if (Connect.GetStr(grvCT.GetRowCellValue(i, colTT)) == "1")
                    {
                        Connect.Reconnect();
                        string ma = Connect.TaoMa("NT", Connect.TruyVandt("Select * From tblnhomtuoi"), "MaNT");
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Insert into tblnhomtuoi (MaNT,TenNT) values (@MaNT,@TenNT)";
                        cmd.Parameters.Add("@MaNT", OleDbType.VarChar).Value = ma;
                        cmd.Parameters.Add("@TenNT", OleDbType.VarChar).Value = grvCT.GetRowCellValue(i, colTenNT);
                        Connect.LuuDL(cmd);
                        OleDbDataReader dr = Connect.TruyVandr("Select * From tblbuaan where Theodoi = True");
                        while (dr.Read())
                        {
                            OleDbCommand cmdct = new OleDbCommand();
                            cmdct.CommandText = "Insert into tblchitietnhomtuoi (MaNT,buaan) values (@MaNT,@buaan)";
                            cmdct.Parameters.Add("@MaNT", OleDbType.VarChar).Value = ma;
                            cmdct.Parameters.Add("@buaan", OleDbType.VarChar).Value = dr["TenBA"].ToString();
                            Connect.LuuDL(cmdct);
                        }
                        dr.Close();
                    }
                    if (Connect.GetStr(grvCT.GetRowCellValue(i, colTT)) == "0" && Connect.GetStr(grvCT.GetRowCellValue(i, colIDNT)) != "-1")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update tblnhomtuoi set MaNT=@MaNT,TenNT=@TenNT where IDNT = " + Convert.ToInt64(Connect.GetStr(grvCT.GetRowCellValue(i,colIDNT)));
                        cmd.Parameters.Add("@MaNT", OleDbType.VarChar).Value = grvCT.GetRowCellValue(i, colMaNT);
                        cmd.Parameters.Add("@TenNT", OleDbType.VarChar).Value = grvCT.GetRowCellValue(i, colTenNT);
                        Connect.LuuDL(cmd);
                    }                   
                }
                this.Dispose();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu. Bạn hãy kiểm tra lại!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void grvCT_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvCT.SetRowCellValue(e.RowHandle, colSTT, grvCT.RowCount);
            grvCT.SetRowCellValue(e.RowHandle, colTT, "1");
            grvCT.SetRowCellValue(e.RowHandle, colIDNT, "-1");
        }

        private void frmThoainhomtuoi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Connect.ThaoTac("Delete * From tblnhomtuoi Where IDNT = " + Convert.ToInt64(grvCT.GetFocusedRowCellValue(colIDNT).ToString()));
                    Connect.ThaoTac("Delete * From tblchitietnhomtuoi Where MaNT = " + Connect.GetDou(grvCT.GetFocusedRowCellValue(colMaNT)));
                    grvCT.DeleteSelectedRows();
                    for (int i = 0; i < grvCT.RowCount; i++)
                    {
                        grvCT.SetRowCellValue(i, colSTT, i + 1);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xóa, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
