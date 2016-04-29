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
    public partial class frmDMCanBo : DevComponents.DotNetBar.Office2007Form
    {
        int SoBG = 0;

        public frmDMCanBo()
        {
            InitializeComponent();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            Connect.LoadDL(Luphong, "tenphong","tenphong", "Select tenphong From phong Order by tenphong");
            grcKQ.DataSource = Connect.Loadgrc("Select * From canbo");    
        }              

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }          

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Delete * From canbo Where idcanbo = " + grvKQ.GetFocusedRowCellValue(colidcanbo).ToString();
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
            grvKQ.CloseEditor();
            grvKQ.MoveFirst();
            Luu();
        }        
        private void Luu()
        {
            try
            {
                for (int i = 0; i < grvKQ.RowCount - 1; i++)
                {
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "1")
                    {
                        Connect.Reconnect();
                        grvKQ.SetRowCellValue(i, colmacb, Connect.TaoMa("CB", "Select Max(macb) as macb From canbo", "macb"));
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Insert into canbo (macb, tencb, dccb, phongban) values(@macb, @tencb, @dccb, @phongban)";
                        cmd.Parameters.Add("@macb", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmacb);
                        cmd.Parameters.Add("@tencb", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltencb);
                        cmd.Parameters.Add("@dccb", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldccb);
                        cmd.Parameters.Add("@phongban", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colphongban);
                        Connect.LuuDL(cmd);
                    }
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "0" && Connect.GetStr(grvKQ.GetRowCellValue(i, colidcanbo)) != "-1")
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Update canbo set macb=@macb, tencb=@tencb, dccb=@dccb, phongban=@phongban" +
                                              " Where idcanbo = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetRowCellValue(i, colidcanbo)));

                        cmd.Parameters.Add("@macb", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmacb);
                        cmd.Parameters.Add("@tencb", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltencb);
                        cmd.Parameters.Add("@dccb", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldccb);
                        cmd.Parameters.Add("@phongban", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colphongban);
                        Connect.LuuDL(cmd);
                    }
                }
                MessageBox.Show("Bạn đã cập nhật thành công!", "Thông báo");
                grcKQ.DataSource = Connect.Loadgrc("Select * From canbo");
                //grvKQ.MoveBy(SoBG);
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu. Bạn hãy kiểm tra lại dữ liệu nhập!", "Thông báo");
            }
        }
             
        private void frmDMCanBo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void grvKQ_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvKQ.SetRowCellValue(e.RowHandle, colSTT, grvKQ.RowCount);
            grvKQ.SetRowCellValue(e.RowHandle, colTT, "1");
            grvKQ.SetRowCellValue(e.RowHandle, colidcanbo, "-1");
        }
    }
}