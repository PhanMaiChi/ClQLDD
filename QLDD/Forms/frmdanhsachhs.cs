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

namespace KPBT.Forms
{
    public partial class frmdanhsachhs : Office2007Form
    {
        string strTB = "";
        public frmdanhsachhs()
        {
            InitializeComponent();
        }

        private void frmdanhsachhs_Load(object sender, EventArgs e)
        {            
            grcKQ.DataSource = Connect.Loadgrc("Select * From hocsinh order by tenphong,mshs");
            Connect.LoadDL(LuDanToc, "DANT", "DANT", "Select DANT From DANT order by DANT");
            Connect.LoadDL(LuPhong, "tenphong", "tenphong", "Select tenphong From phong order by tenphong");                   
        }
        
        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa học sinh này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sql = "Delete * From hocsinh Where mshs = '" + grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colmshs).ToString() + "'";
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                Connect.LuuDL(cmd);
                grcKQ.DataSource = Connect.Loadgrc("Select * From hocsinh order by tenphong,mshs");
            }
        }

        private void tbtLuu_Click(object sender, EventArgs e)
        {
            grvKQ.CloseEditor();
            grvKQ.MoveFirst();
            try
            {
                for (int i = 0; i < grvKQ.RowCount; i++)
                {
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "1")
                    {
                        Connect.Reconnect();
                        grvKQ.SetRowCellValue(i, colmshs, Connect.TaoMa("hs.", "Select Max(mshs) as mshs From hocsinh", "mshs"));
                        string sql = "Insert into hocsinh(mshs,tenhs,ntns,datoc,dchs,tenphong,gths,ht) values(@mshs,@tenhs,@ntns,@datoc,@dchs,@tenphong,@gths,@ht)";
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = sql;
                        cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmshs);
                        cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltenhs);
                        cmd.Parameters.Add("@ntns", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colntns);
                        cmd.Parameters.Add("@datoc", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldatoc);
                        cmd.Parameters.Add("@dchs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldchs);
                        cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltenphong);
                        cmd.Parameters.Add("@gths", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colgths);
                        cmd.Parameters.Add("@ht", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colht);
                        Connect.LuuDL(cmd);
                    }
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "0" && Connect.GetStr(grvKQ.GetRowCellValue(i, colidhs)) != "-1")
                    {
                        string sql = "Update hocsinh set mshs = @mshs,tenhs=@tenhs,ntns=@ntns,datoc=@datoc,dchs=@dchs,tenphong=@tenphong,gths=@gths,ht=@ht where idhs = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetRowCellValue(i, colidhs)));
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = sql;
                        cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, colmshs));
                        cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, coltenhs));
                        cmd.Parameters.Add("@ntns", OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, colntns));
                        cmd.Parameters.Add("@datoc", OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, coldatoc));
                        cmd.Parameters.Add("@dchs", OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, coldchs));
                        cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, coltenphong));
                        cmd.Parameters.Add("@gths", OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, colgths));
                        cmd.Parameters.Add("@ht", OleDbType.VarChar).Value = Connect.GetStr(grvKQ.GetRowCellValue(i, colht));
                        Connect.LuuDL(cmd);
                    }                    
                }
                Connect.Reconnect();
                grcKQ.DataSource = Connect.Loadgrc("Select * From hocsinh order by tenphong,mshs");
                MessageBox.Show("Bạn đã cập nhật thành công dữ liệu!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu. Bạn hãy kiểm tra lại!", "Thông báo");
            }
        }         
       
        private void tbtIn_Click(object sender, EventArgs e)
        {
            try
            {                
                string sql = "Select * From hocsinh where ht = 'Đi học'";                
                DataSet ds = new DataSet();
                ds = Modules.Connect.Loadds(ds, sql, "hocsinh");                
                Reports.rptdshs rpt = new Reports.rptdshs();
                Forms.frmHienThi frm = new Forms.frmHienThi();
                rpt.tendv.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.ntkx.Value = thongtinketxuat.Default.diadanh.ToString() + ", ngày ... tháng ... năm ........";
                rpt.nlb.Value = thongtinketxuat.Default.nlb.ToString();
                rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
                rpt.sshs.Value = ds.Tables["hocsinh"].Rows.Count;                
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.DataSource = ds;
                rpt.CreateDocument();
                frm.ShowDialog();                
            }
            catch
            {
                MessageBox.Show("Có lỗi trong khi kết xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmdanhsachhs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
            DC1.tenhs = "";
        }

        private void grvKQ_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvKQ.SetRowCellValue(e.RowHandle, colgths, grvKQ.GetRowCellValue(grvKQ.RowCount - 2, colgths));
            grvKQ.SetRowCellValue(e.RowHandle, coldatoc, grvKQ.GetRowCellValue(grvKQ.RowCount - 2, coldatoc));
            grvKQ.SetRowCellValue(e.RowHandle, coldchs, grvKQ.GetRowCellValue(grvKQ.RowCount - 2, coldchs));
            grvKQ.SetRowCellValue(e.RowHandle, coltenphong, grvKQ.GetRowCellValue(grvKQ.RowCount - 2, coltenphong));
            grvKQ.SetRowCellValue(e.RowHandle, colht, grvKQ.GetRowCellValue(grvKQ.RowCount - 2, colht));
            grvKQ.SetRowCellValue(e.RowHandle, colSTT, grvKQ.RowCount.ToString());
            grvKQ.SetRowCellValue(e.RowHandle, colTT, "1");
            grvKQ.SetRowCellValue(e.RowHandle, colidhs, "-1");
        }

        private void grvKQ_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (Connect.GetStr(grvKQ.GetRowCellValue(e.RowHandle, coltenhs).ToString()).Length == 0)
            {
                e.Valid = false;
                strTB = "Tên học sinh không được bỏ trống. Bạn có muốn nhập lại?";
            }            
        }

        private void grvKQ_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (MessageBox.Show(strTB, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            else
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
        }

        private void taoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DC1.tenhs = Connect.GetStr(grvKQ.GetFocusedRowCellValue(colmshs));
            Form frm = new Forms.ThoaiKX.ThoaiTest();
            frm.ShowDialog();            
        }        
    }
}
