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
    public partial class frmchungtu : Office2007Form
    {
        DataTable dtnhan = new DataTable();
        DataTable dtnop = new DataTable();
        public string decimalChar = "";
        public frmchungtu()
        {
            InitializeComponent();
        }

        private void frmchungtu_Load(object sender, EventArgs e)
        {
            decimalChar = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (decimalChar == ".")
                decimalChar = ",";
            dtnhan = Connect.TruyVandt("Select Distinct nguoinhantien,diachint From chungtu ");
            dtnop = Connect.TruyVandt("Select Distinct nguoinoptien,diachinoptien From chungtu");
            grcKQ.DataSource = Connect.Loadgrc("Select * From chungtu order by idchungtutc");
            Connect.LoadDL(LuTaiKhoanNo, "SoHieuTaiKhoan", "SoHieuTaiKhoan", "Select * From TblDanhMucTaiKhoan order by SoHieuTaiKhoan");
            Connect.LoadDL(LuTaiKhoanCo, "SoHieuTaiKhoan", "SoHieuTaiKhoan", "Select * From TblDanhMucTaiKhoan order by SoHieuTaiKhoan");
            Connect.LoadDL(LuNguoiNhan, "nguoinhantien", "nguoinhantien", dtnhan);
            Connect.LoadDL(LuNguoiNop, "nguoinoptien", "nguoinoptien", dtnop);
        }       

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa chứng từ này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sql = "Delete * From chungtu Where idchungtutc = " + grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colidchungtutc);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                Connect.LuuDL(cmd);
                grvKQ.DeleteRow(grvKQ.FocusedRowHandle);
            }
        }

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insertchungtu(int i)
        {
            string sql = "Insert into chungtu(ngayct,ngaygs,quyen,sohieu,ploai,noidung,tkn,tkc,ctgockemtheo,sotien,nguoinhantien,diachint,nguoinoptien,diachinoptien) values(@ngayct,@ngaygs,@quyen,@sohieu,@ploai,@noidung,@tkn,@tkc,@ctgockemtheo,@sotien,@nguoinhantien,@diachint,@nguoinoptien,@diachinoptien)";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@ngayct", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colngayct);
            cmd.Parameters.Add("@ngaygs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colngayct);
            cmd.Parameters.Add("@quyen", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colquyen);
            cmd.Parameters.Add("@sohieu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colsohieu);
            cmd.Parameters.Add("@ploai", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colploai);
            cmd.Parameters.Add("@noidung", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colnoidung);
            cmd.Parameters.Add("@tkn", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltkn);
            cmd.Parameters.Add("@tkc", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltkc);
            cmd.Parameters.Add("@ctgockemtheo", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colctgockemtheo);
            cmd.Parameters.Add("@sotien", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colsotien);
            cmd.Parameters.Add("@nguoinhantien", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colnguoinhantien);
            cmd.Parameters.Add("@diachint", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldiachint);
            cmd.Parameters.Add("@nguoinoptien", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colnguoinoptien);
            cmd.Parameters.Add("@diachinoptien", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldiachinoptien);
            Connect.LuuDL(cmd);

        }
        private void updatechungtu(int i)
        {

            string sql = "Update chungtu set ngayct=@ngayct,ngaygs=@ngaygs,quyen=@quyen,sohieu=@sohieu,ploai=@ploai,noidung=@noidung,tkn=@tkn,tkc=@tkc,ctgockemtheo=@ctgockemtheo,sotien=@sotien,nguoinhantien=@nguoinhantien,diachint=@diachint,nguoinoptien=@nguoinoptien,diachinoptien=@diachinoptien";
            sql = sql + " Where idchungtutc = " + Convert.ToInt64(Connect.GetStr(grvKQ.GetRowCellValue(i, colidchungtutc)));
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@ngayct", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colngayct);
            cmd.Parameters.Add("@ngaygs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colngayct);
            cmd.Parameters.Add("@quyen", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colquyen);
            cmd.Parameters.Add("@sohieu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colsohieu);
            cmd.Parameters.Add("@ploai", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colploai);
            cmd.Parameters.Add("@noidung", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colnoidung);
            cmd.Parameters.Add("@tkn", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltkn);
            cmd.Parameters.Add("@tkc", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltkc);
            cmd.Parameters.Add("@ctgockemtheo", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colctgockemtheo);
            cmd.Parameters.Add("@sotien", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colsotien);
            cmd.Parameters.Add("@nguoinhantien", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colnguoinhantien);
            cmd.Parameters.Add("@diachint", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldiachint);
            cmd.Parameters.Add("@nguoinoptien", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colnguoinoptien);
            cmd.Parameters.Add("@diachinoptien", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coldiachinoptien);
            Connect.LuuDL(cmd);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtidchungtutc.Text == "")
            //    {
            //        insertchungtu();
            //        if (chbploai.Checked == true)
            //        {
            //            Settings1.Default.thuno = cbtkn.Text;
            //            Settings1.Default.Save();
            //            Settings1.Default.thuco = cbtkc.Text;
            //            Settings1.Default.Save();
            //        }
            //        else
            //        {
            //            Settings1.Default.chino = cbtkn.Text;
            //            Settings1.Default.Save();
            //            Settings1.Default.chico = cbtkc.Text;
            //            Settings1.Default.Save();
            //        }
            //    }
            //    else
            //    {
            //        updatechungtu();
            //        if (chbploai.Checked == true)
            //        {
            //            Settings1.Default.thuno = cbtkn.Text;
            //            Settings1.Default.Save();
            //            Settings1.Default.thuco = cbtkc.Text;
            //            Settings1.Default.Save();
            //        }
            //        else
            //        {
            //            Settings1.Default.chino = cbtkn.Text;
            //            Settings1.Default.Save();
            //            Settings1.Default.chico = cbtkc.Text;
            //            Settings1.Default.Save();
            //        }
            //    }
            //    grpdshs.Visible = false;
            //    grcKQ.DataSource = Connect.Loadgrc("Select * From chungtu order by idchungtutc");
            //}
            //catch
            //{
            //    MessageBox.Show("Có lỗi trong lúc cập nhật, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void cbnguoinhantien_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = Connect.TruyVandt("Select diachint From chungtu where nguoinhantien like '" + cbnguoinhantien.Text + "%' Group by diachint");
            //txtdiachint.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["diachint"].ToString() : "");
        }

        private void cbnguoinoptien_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = Connect.TruyVandt("Select diachinoptien From chungtu where nguoinoptien like '" + cbnguoinoptien.Text + "%' Group by diachinoptien");
            //txtdiachinoptien.Text = (dt.Rows.Count > 0 ? dt.Rows[0]["diachinoptien"].ToString() : "");
        }

        private void chbploai_TextChanged(object sender, EventArgs e)
        {
            
        }    
        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colploai).ToString() == "Thu")
            {
                string[] str = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colngayct).ToString().Split('/');
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.PhThu rpt = new KPBT.Reports.PhThu();
                rpt.TenDV.Value = "TÊN ĐƠN VỊ: " + thongtinketxuat.Default.tendv.ToString().ToUpper();
                rpt.MaDV.Value = "Mã đơn vị SDNS: " + thongtinketxuat.Default.madvqhns.ToString();
                rpt.NTN.Value = "Ngày " + str[0] + " tháng " + str[1] + " năm " + str[2].Substring(0, 4);
                rpt.Quyen.Value = "Quyển: " + grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colquyen).ToString();
                rpt.No.Value = "Nợ: " + grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, coltkn).ToString();
                rpt.Co.Value = "Có: " + grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, coltkc).ToString();
                rpt.nguoinoptien.Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colnguoinoptien).ToString();
                rpt.diachi.Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, coldiachinoptien).ToString();
                rpt.ldnop.Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colnoidung).ToString();
                rpt.sotien.Value = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colsotien).ToString()));
                rpt.bangchu.Value = classdc.dungchung.So_chu(classdc.dungchung.kieudouble(grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colsotien).ToString()));
                rpt.kemtho.Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colctgockemtheo).ToString();
                rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
                rpt.nlb.Value = thongtinketxuat.Default.nlb.ToString();
                rpt.ptkt.Value = thongtinketxuat.Default.ptkt.ToString();
                rpt.thuquy.Value = thongtinketxuat.Default.thuquy.ToString();
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                frm.ShowDialog();
            }
        }

        private void phiếuChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colploai).ToString() == "Chi")
            {
                string[] str = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colngayct).ToString().Split('/');
                Forms.frmHienThi frm = new Forms.frmHienThi();
                Reports.PhChi rpt = new KPBT.Reports.PhChi();
                rpt.TenDV.Value = "TÊN ĐƠN VỊ: " + thongtinketxuat.Default.tendv.ToString().ToUpper();
                rpt.MaDV.Value = "Mã đơn vị SDNS: " + thongtinketxuat.Default.madvqhns.ToString();
                rpt.NTN.Value = "Ngày " + str[0] + " tháng " + str[1] + " năm " + str[2].Substring(0, 4);
                rpt.Quyen.Value = "Quyển: " + grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colquyen).ToString();
                rpt.No.Value = "Nợ: " + grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, coltkn).ToString();
                rpt.Co.Value = "Có: " + grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, coltkc).ToString();
                rpt.nguoinhantien.Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colnguoinhantien).ToString();
                rpt.diachi.Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, coldiachint).ToString();
                rpt.lydo.Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colnoidung).ToString();
                rpt.sotien.Value = string.Format("{0:#" + decimalChar + "#}", classdc.dungchung.kieudouble(grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colsotien).ToString()));
                rpt.bangchu.Value = classdc.dungchung.So_chu(classdc.dungchung.kieudouble(grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colsotien).ToString()));
                rpt.ctgoc.Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colctgockemtheo).ToString();
                rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
                rpt.nlb.Value = thongtinketxuat.Default.nlb.ToString();
                rpt.ptkt.Value = thongtinketxuat.Default.ptkt.ToString();
                rpt.thuquy.Value = thongtinketxuat.Default.thuquy.ToString();
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
                frm.ShowDialog();
            }
        }

        private void frmchungtu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void grvKQ_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            grvKQ.SetRowCellValue(e.RowHandle, colSTT, grvKQ.RowCount.ToString());
            grvKQ.SetRowCellValue(e.RowHandle, colTT, "1");
            grvKQ.SetRowCellValue(e.RowHandle, colidchungtutc, "-1");   
        }

        private void grvKQ_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "nguoinhantien")
            {
                grvKQ.SetFocusedRowCellValue(coldiachint, dcts.LayGT(dtnhan.Select("nguoinhantien='" + grvKQ.GetFocusedRowCellValue(colnguoinhantien).ToString() + "'"), "diachint"));
            }
        }

        private void tbtLuu_Click(object sender, EventArgs e)
        {
            grvKQ.CloseEditor();
            grvKQ.MoveFirst();
            try
            {
                for (int i = 0; i < grvKQ.RowCount - 1; i++)
                {
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "1")
                        insertchungtu(i);
                    if (Connect.GetStr(grvKQ.GetRowCellValue(i, colTT)) == "0" && Connect.GetStr(grvKQ.GetRowCellValue(i, colidchungtutc)) != "-1")
                        updatechungtu(i);                    
                }
                Connect.Reconnect();
                grcKQ.DataSource = Connect.Loadgrc("Select * From chungtu order by idchungtutc");
                MessageBox.Show("Bạn đã cập nhật thành công chứng từ!", "Thông báo");
            }
            catch {
                MessageBox.Show("Có lỗi trong quá trình lưu dữ liệu. Bạn hãy kiểm tra lại các chi tiết!", "Thông báo");
            }
        }

        private void LuNguoiNhan_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            e.DisplayValue = DC2.xuly(e.DisplayValue.ToString());
            if (e.DisplayValue.ToString().Length > 0)
                dtnhan.Rows.Add(DC2.xuly(e.DisplayValue.ToString()));
            e.Handled = true;
        }

        private void LuNguoiNop_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            e.DisplayValue = DC2.xuly(e.DisplayValue.ToString());
            if (e.DisplayValue.ToString().Length > 0)
                dtnop.Rows.Add(DC2.xuly(e.DisplayValue.ToString()));
            e.Handled = true;
        }
    }
}
