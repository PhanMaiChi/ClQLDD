using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace KPBT.Forms
{
    public partial class frmQLThu : Office2007Form
    {
        public DataTable dt;
        public DataTable dtkt;
        public DataTable dtdk;
        public string sql = "";
        public frmQLThu()
        {
            InitializeComponent();
        }

        private void frmTDSKHS_Load(object sender, EventArgs e)
        {            
            dt = new DataTable();
            KPBT.Modules.dcts.taoTG(false, dt,"STT", "TEN1", "TEN2", "TEN3", "TEN4", "TEN5","TEN6", "SL1", "SL2", "TEN7","TEN8");
            grcKQ.DataSource = dt;
            loadhs();            
            cboThang.Text = DateTime.Now.Month.ToString();
            phong();
            lop();
            cbtenphongb.Text = "";
            cboLop.Text = "";
        }

        private void phong()
        {
            sql = "Select * From phong";
            DataTable dt1 = KPBT.Modules.Connect.TruyVandt(sql);
            cbtenphongb.Items.Clear();
            cbtenphongb.DataSource = dt1;
            cbtenphongb.DisplayMember = "tenphong";
            cbtenphongb.ValueMember = "tenphong";
        }
        private void lop()
        {
            sql = "Select * From phong";
            DataTable dt1 = KPBT.Modules.Connect.TruyVandt(sql);
            cboLop.Items.Clear();
            cboLop.DataSource = dt1;
            cboLop.DisplayMember = "tenphong";
            cboLop.ValueMember = "tenphong";
        }
        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void MtbNTDG_Leave(object sender, EventArgs e)
        {
            try
            {
                MtbNTDG.Text = clsbqkpbt.banquyen.dtngaysinh(MtbNTDG.Text);
            }
            catch
            {
                MtbNTDG.Text = clsbqkpbt.banquyen.dtngaysinh(DateTime.Now.ToString());
            }            
        }
        private void frmTDSKHS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
        private string ten( string mshs)
        {
            string kq = "";
            sql = "Select tenhs From hocsinh where mshs = '" + mshs + "'";
            System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = dr["tenhs"].ToString().Substring(dr["tenhs"].ToString().LastIndexOf(" "));
            }
            dr.Close();
            return kq;
        }
        private string ho(string mshs)
        {
            string kq = "";
            sql = "Select tenhs From hocsinh where mshs = '" + mshs + "'";
            System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = dr["tenhs"].ToString().Substring(0, dr["tenhs"].ToString().LastIndexOf(" "));
            }
            dr.Close();
            return kq;
        }           
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }
        private void btnTaoKT_Click(object sender, EventArgs e)
        {            
            try
            {               
                MtbNTDG.Text = clsbqkpbt.banquyen.ngaythang(DateTime.Now.ToString("dd/MM/yyyy"));
                grbTaoKT.Visible = true;
                try
                {
                    txtSoPhieu.Text = KPBT.Modules.Connect.TaoMa("PT", "Select sophieu From thutien group by sophieu", "sophieu");
                }
                catch
                {
                    txtSoPhieu.Text = "PT0001";
                }
                dtdk = new DataTable();
                dtdk = KPBT.Modules.Connect.TruyVandt("Select * From dmthu");
                dtdk.Columns.Add("Check", typeof(Boolean));
                grcTKT.DataSource = dtdk;
            }
            catch
            {
                MessageBox.Show("Bạn hãy chọn học sinh muốn tạo khoản thu", "Thông báo");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            grbTaoKT.Visible = false;
        }
        private void CreatNewRow(string tenkhoanthu, string ngaythu, string sophieu, string sophaithu, string sotienphaithu, string masohocsinh)
        {
            //grvKT.AddNewRow();
            //int rowHandle = grvKT.GetRowHandle(grvKT.DataRowCount);
            //if (grvKT.IsNewItemRow(rowHandle))
            //{
            //    if (tenkhoanthu == "Tiền ăn")
            //    {
            //        grvKT.SetRowCellValue(rowHandle, colSTT, grvKT.RowCount);
            //        grvKT.SetRowCellValue(rowHandle, coltenkhoanthu, tenkhoanthu);
            //        grvKT.SetRowCellValue(rowHandle, colngaythu, Convert.ToDateTime(ngaythu));
            //        grvKT.SetRowCellValue(rowHandle, colsophieu, sophieu);
            //        grvKT.SetRowCellValue(rowHandle, colsophaithu, sophaithu);
            //        grvKT.SetRowCellValue(rowHandle, colsotienphaithu, sotienphaithu);
            //        grvKT.SetRowCellValue(rowHandle, colmahocsinh, masohocsinh);
            //        grvKT.SetRowCellValue(rowHandle, colsoluongton, soluongton());
            //        grvKT.SetRowCellValue(rowHandle, colsotienton, (soluongton()*double.Parse(sotienphaithu)/double.Parse(sophaithu)));
            //        grvKT.SetRowCellValue(rowHandle, colsothu, (double.Parse(sophaithu) - soluongton()));
            //        grvKT.SetRowCellValue(rowHandle, colsotienthu, (double.Parse(sotienphaithu)-(soluongton() * double.Parse(sotienphaithu) / double.Parse(sophaithu))));
            //    }
            //    else
            //    {
            //        grvKT.SetRowCellValue(rowHandle, colSTT, grvKT.RowCount);
            //        grvKT.SetRowCellValue(rowHandle, coltenkhoanthu, tenkhoanthu);
            //        grvKT.SetRowCellValue(rowHandle, colngaythu, Convert.ToDateTime(ngaythu));
            //        grvKT.SetRowCellValue(rowHandle, colsophieu, sophieu);
            //        grvKT.SetRowCellValue(rowHandle, colsophaithu, sophaithu);
            //        grvKT.SetRowCellValue(rowHandle, colsotienphaithu, sotienphaithu);
            //        grvKT.SetRowCellValue(rowHandle, colmahocsinh, masohocsinh);
            //    }
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sophieu = "";
            DataTable dtKQ = KPBT.Modules.Connect.TruyVandt("Select sophieu From thutien group by sophieu");
            string strID = "0", strSH = "";
            try
            {
                strSH = dtKQ.Rows[0]["sophieu"].ToString();
            }
            catch { }
            foreach (char c in strSH)
            {
                if (Char.IsDigit(c))
                    strID += c;
            }
            double sp = double.Parse(strID);
            string sqldk = "Select mshs From hocsinh where tenphong like '" + (cboLop.Text == "" ? "%" : cboLop.Text) + "'";
            System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sqldk);
            while (dr.Read())
            {
                sp += 1;
                try
                {
                    //sophieu = KPBT.Modules.Connect.TaoMa("PT", "Select sophieu From thutien group by sophieu", "sophieu");                           
                    sophieu = "PT" + sp.ToString("0000");
                }
                catch
                {
                    sophieu = "PT0001";
                }
                for (int i = 0; i < grvTKT.RowCount; i++)
                {                    
                    if (grvTKT.GetRowCellValue(i, colCheck).ToString() == "True")
                    {                        
                        string sqlin = "Insert into thutien(ngaythu,noidung,sophieu,mshs,makhthu,sophaithu,sotienphaithu,sothu,sotienthu,thang)"+
                            " values (@ngaythu,@noidung,@sophieu,@mshs,@makhthu,@sophaithu,@sotienphaithu,@sothu,@sotienthu,@thang)";
                        System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                        cmd.CommandText = sqlin;
                        if (grvTKT.GetRowCellValue(i, coltenkhoanthu).ToString() == "Tiền ăn")
                            cmd.CommandText = "Insert into thutien(ngaythu,noidung,sophieu,mshs,makhthu,sophaithu,sotienphaithu,soluongton,sotienton,sothu,sotienthu,thang)" +
                                " values (@ngaythu,@noidung,@sophieu,@mshs,@makhthu,@sophaithu,@sotienphaithu,@soluongton,@sotienton,@sothu,@sotienthu,@thang)";
                        cmd.Parameters.Add("@ngaythu", System.Data.OleDb.OleDbType.Date).Value = KPBT.Modules.DC1.ngaythang(MtbNTDG.Text);
                        cmd.Parameters.Add("@noidung", System.Data.OleDb.OleDbType.VarChar).Value = txtenoidung.Text;
                        cmd.Parameters.Add("@sophieu", System.Data.OleDb.OleDbType.VarChar).Value = sophieu;
                        cmd.Parameters.Add("@mshs", System.Data.OleDb.OleDbType.VarChar).Value  = dr["mshs"].ToString();
                        cmd.Parameters.Add("@makhthu", System.Data.OleDb.OleDbType.VarChar).Value = grvTKT.GetRowCellValue(i, colmakhthu).ToString();
                        cmd.Parameters.Add("@sophaithu", System.Data.OleDb.OleDbType.Double).Value = grvTKT.GetRowCellValue(i, colsoluong).ToString();
                        cmd.Parameters.Add("@sotienphaithu", System.Data.OleDb.OleDbType.Double).Value = grvTKT.GetRowCellValue(i, colsotien).ToString();
                        if (grvTKT.GetRowCellValue(i, coltenkhoanthu).ToString() == "Tiền ăn")
                        {
                            if (dr["mshs"].ToString() == "hs.0013")
                                MessageBox.Show("aaaaa");
                            cmd.Parameters.Add("@soluongton", System.Data.OleDb.OleDbType.Double).Value = soluongton(dr["mshs"].ToString());
                            cmd.Parameters.Add("@sotienton", System.Data.OleDb.OleDbType.Double).Value = soluongton(dr["mshs"].ToString()) * sotien();
                            try
                            {
                                cmd.Parameters.Add("@sophaithu", System.Data.OleDb.OleDbType.Double).Value = classdc.dungchung.kieudouble(grvTKT.GetRowCellValue(i, colsoluong).ToString()) - soluongton(dr["mshs"].ToString());
                            }
                            catch {cmd.Parameters.Add("@sophaithu", System.Data.OleDb.OleDbType.Double).Value=0; }
                            try{
                                cmd.Parameters.Add("@sotienphaithu", System.Data.OleDb.OleDbType.Double).Value = classdc.dungchung.kieudouble(grvTKT.GetRowCellValue(i, colsotien).ToString()) - (soluongton(dr["mshs"].ToString()) * sotien());
                            }
                            catch { cmd.Parameters.Add("@sotienphaithu", System.Data.OleDb.OleDbType.Double).Value = 0; }
                        }
                        else
                        {
                            cmd.Parameters.Add("@sothu", System.Data.OleDb.OleDbType.Double).Value = grvTKT.GetRowCellValue(i, colsoluong).ToString();
                            cmd.Parameters.Add("@sotienthu", System.Data.OleDb.OleDbType.Double).Value = grvTKT.GetRowCellValue(i, colsotien).ToString();
                        }
                        cmd.Parameters.Add("@thang", System.Data.OleDb.OleDbType.Double).Value = classdc.dungchung.kieudouble(cbothangthu.Text);
                        KPBT.Modules.Connect.LuuDL(cmd);
                    }
                }
            }
            dr.Close();            
            grbTaoKT.Visible = false;            
        }
        private void grcKQ_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT dmthu.tenkhoanthu, thutien.* FROM dmthu INNER JOIN thutien ON dmthu.makhthu = thutien.makhthu" +
                    " where thutien.mshs = '" + grvKQ.GetFocusedRowCellValue(colmshs).ToString() + "' and thang = " + cboThang.Text;
                grcKT.DataSource = KPBT.Modules.Connect.Loadgrc(sql);
            }
            catch { }
        }
        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT dmthu.tenkhoanthu, thutien.* FROM dmthu INNER JOIN thutien ON dmthu.makhthu = thutien.makhthu" +
                   " where thutien.mshs = '" + grvKQ.GetFocusedRowCellValue(colmshs).ToString() + "' and thang = " + cboThang.Text;
                grcKT.DataSource = KPBT.Modules.Connect.Loadgrc(sql);
            }
            catch { }
        }
        private double soluongton( string mshs)
        {
            double kq = 0, kq1 = 0, kq2 = 0;
            try
            {
                string sql1 = "Select ntan From baoan where Month(ntan) = '" + (double.Parse(cboThang.Text) - 1) + "' and mshs = '" + mshs + "' and BS = 1";
                System.Data.OleDb.OleDbDataReader dr1 = KPBT.Modules.Connect.TruyVandr(sql1);
                while (dr1.Read())
                {
                    kq1 += 1;
                }
                dr1.Close();
                string sql2 = "Select sophaithu From thutien inner join dmthu on thutien.makhthu = dmthu.makhthu where thang = " + (double.Parse(cboThang.Text) - 1) + " and thutien.mshs = '" + mshs + "' and dmthu.tenkhoanthu = 'Tiền ăn'";
                System.Data.OleDb.OleDbDataReader dr2 = KPBT.Modules.Connect.TruyVandr(sql2);
                while (dr2.Read())
                {
                    kq2 += double.Parse(dr2["sophaithu"].ToString());
                }
                dr2.Close();
                kq = kq2 - kq1;                
            }
            catch { }
            return kq;
        }
        private double sotien()
        {
            double kq = 0;
            string sql = "Select sotien/soluong as tien From dmthu where tenkhoanthu = 'Tiền ăn'";
            System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = classdc.dungchung.kieudouble(dr["tien"].ToString());
            }
            dr.Close();           
            return kq;
        }
        private void cbtenphongb_TextChanged(object sender, EventArgs e)
        {
            if (cbtenphongb.Text != "")
            {
                try
                {
                    grvKQ.Columns["TEN5"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[TEN5] = '" + cbtenphongb.Text + "'");
                }
                catch { }
            }
            else
            {
                grvKQ.Columns["TEN5"].ClearFilter();
            }
        }
        private void loadhs()
        {
            try
            {
                sql = "SELECT mshs as TEN1,tenphong as TEN5,  gths as TEN4" +
                    " FROM hocsinh";
                System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr(sql);
                DataTable dtdk = new DataTable();
                dtdk.Load(dr);
                if (dtdk.Rows.Count > 0)
                {
                    dt.Rows.Clear();
                    foreach (DataRow item in dtdk.Rows)
                    {
                        dt.ImportRow(item);
                    }
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["STT"] = i + 1;
                            dt.Rows[i]["TEN2"] = ho(dt.Rows[i]["TEN1"].ToString());
                            dt.Rows[i]["TEN3"] = ten(dt.Rows[i]["TEN1"].ToString());
                        }
                    }
                    grcKQ.DataSource = dt;
                }
            }
            catch { }
        }
        private void tbtXoa_Click(object sender, EventArgs e)
        {
            grbXoa.Visible = true;
            rbtnDT.Checked = true;
        }
        private void xoa()
        {
            try
            {
                if (rbtnDT.Checked == true)
                {
                    if (MessageBox.Show("Bạn có muốn xóa khoản thu của học sinh này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                        cmd.CommandText = "Delete * From thutien Where mshs = '" + grvKQ.GetFocusedRowCellValue(colmshs).ToString() + "'" +
                            " and thang = " + classdc.dungchung.kieudouble(cboThang.Text);
                        KPBT.Modules.Connect.LuuDL(cmd);
                        grcKT.DataSource = null;
                    }
                }
                if (rbtnLop.Checked == true)
                {
                    if (cbtenphongb.Text == "")
                        MessageBox.Show("Bạn chưa chọn phòng trước khi xóa. Bạn hãy thoát ra và chọn phòng cần xóa trước!", "Thông báo");
                    else
                    {
                        if (MessageBox.Show("Bạn có muốn xóa khoản thu của " + cbtenphongb.Text + " này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                            System.Data.OleDb.OleDbDataReader dr = KPBT.Modules.Connect.TruyVandr("Select mshs From hocsinh where tenphong = '" + cbtenphongb.Text + "'");
                            while (dr.Read())
                            {
                                cmd.CommandText = "Delete * From thutien Where mshs = '" + dr["mshs"].ToString() + "'" +
                                    " and thang = " + classdc.dungchung.kieudouble(cboThang.Text);
                                KPBT.Modules.Connect.LuuDL(cmd);
                            }
                            grcKT.DataSource = null;
                        }
                    }
                }
                if (rbtnTruong.Checked == true)
                {
                    if (MessageBox.Show("Bạn có muốn xóa khoản thu của học sinh tháng " + cboThang.Text + " này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                        cmd.CommandText = "Delete * From thutien Where thang = " + classdc.dungchung.kieudouble(cboThang.Text);
                        KPBT.Modules.Connect.LuuDL(cmd);
                        grcKT.DataSource = null;
                    }
                }
            }
            catch { }
        }
        private void tsbXoaCT_Click(object sender, EventArgs e)
        {
            xoaCT();
        }
        private void btneXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            xoaCT();
        }
        private void btneXoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                xoaCT();
        }
        private void xoaCT()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết khoản thu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int BG = grvKT.FocusedRowHandle - 1;
                    System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                    cmd.CommandText = "Delete * From thutien Where idthutien = " + grvKT.GetFocusedRowCellValue(colidthutien).ToString();
                    KPBT.Modules.Connect.LuuDL(cmd);
                    int So = grvKT.FocusedRowHandle;
                    if (So == (grvKT.RowCount - 2))
                        grvKT.MovePrev();
                    grvKT.DeleteRow(So);
                    if (grvKT.RowCount > 0)
                        for (int i = 0; i < grvKT.RowCount - 1; i++)
                            grvKT.SetRowCellValue(i, colSTT, i + 1);
                }
            }
            catch { }
        }
        private void biênLaiThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                double st = 0;
                DataTable dt = new DataTable();
                classdc.dungchung.taoTG(dt);
                for (int i = 0; i < grvKT.RowCount; i++)
                {
                    DataRow row;
                    row = dt.NewRow();
                    row["TEN1"] = grvKT.GetRowCellValue(i, colkhoanthu).ToString();
                    row["SL1"] = grvKT.GetRowCellValue(i, colsoluongton).ToString();
                    row["SL2"] = grvKT.GetRowCellValue(i, colsotienton).ToString();
                    row["SL3"] = grvKT.GetRowCellValue(i, colsophaithu).ToString();
                    row["SL4"] = grvKT.GetRowCellValue(i, colsotienphaithu).ToString();
                    row["SL5"] = grvKT.GetRowCellValue(i, colsotienthu).ToString();
                    dt.Rows.Add(row);
                    st += classdc.dungchung.kieudouble(grvKT.GetRowCellValue(i, colsotienthu).ToString());
                }
                string[] st1 = grvKT.GetFocusedRowCellDisplayText(colngaythu).ToString().Split('/');
                DataSet dts = new DataSet();
                dt.TableName = "TblDC";
                dts.Tables.Add(dt);
                frmHienThi frm = new frmHienThi();
                KPBT.Reports.BLThu rpt = new KPBT.Reports.BLThu();
                rpt.bangchu.Value = classdc.dungchung.So_chu(st);
                rpt.diachi.Value = grvKQ.GetFocusedRowCellValue(coltenphong);
                rpt.So.Value = grvKT.GetFocusedRowCellValue(colsophieu);
                rpt.ldnop.Value = grvKT.GetFocusedRowCellValue(colnoidung);
                rpt.nguoinoptien.Value = grvKQ.GetFocusedRowCellValue(coltenhs) + " " + grvKQ.GetFocusedRowCellValue(colten);
                rpt.NTN.Value = "Ngày " + st1[0] + " tháng " + st1[1] + " năm " + st1[2];
                rpt.TenDV.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.thuquy.Value = thongtinketxuat.Default.thuquy.ToString();
                rpt.Thang.Value = cboThang.Text + "/" + DateTime.Now.Year;
                frm.printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.DataSource = dts;
                rpt.CreateDocument();
                frm.ShowDialog();
            }
            catch 
            {
                MessageBox.Show("Không có khoản thu nào của học sinh. Bạn hãy chọn học sinh hoặc tạo khoản thu mới!", "Thông báo");
            }
        }

        private void grvKQ_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                string sql = "SELECT dmthu.tenkhoanthu, thutien.* FROM dmthu INNER JOIN thutien ON dmthu.makhthu = thutien.makhthu" +
                    " where thutien.mshs = '" + grvKQ.GetFocusedRowCellValue(colmshs).ToString() + "' and thang = " + classdc.dungchung.kieudouble(cboThang.Text) ;
                grcKT.DataSource = KPBT.Modules.Connect.Loadgrc(sql);
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
            grbXoa.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grbXoa.Visible = false;
        }

        private void MtbNTDG_Leave_1(object sender, EventArgs e)
        {
            try
            {
                MtbNTDG.Text = KPBT.Modules.DC1.ngaythang(MtbNTDG.Text);
            }
            catch
            {
                MtbNTDG.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Today);
            }
        }

        private void grvKQ_GotFocus(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT dmthu.tenkhoanthu, thutien.* FROM dmthu INNER JOIN thutien ON dmthu.makhthu = thutien.makhthu" +
                    " where thutien.mshs = '" + grvKQ.GetFocusedRowCellValue(colmshs).ToString() + "' and thang = " + classdc.dungchung.kieudouble(cboThang.Text);
                grcKT.DataSource = KPBT.Modules.Connect.Loadgrc(sql);
            }
            catch { }
        }             
    }
}
