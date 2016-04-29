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
    public partial class frmnhapbaoanN : Office2007Form
    {
        public string decimalChar = "";
        public frmnhapbaoanN()
        {
            InitializeComponent();
        }

        private void frmnhapbaoan_Load(object sender, EventArgs e)
        {
            decimalChar = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator;
            if (decimalChar == ".")
                decimalChar = ",";
            grcKQ.DataSource = Connect.Loadgrc("Select * From baoan order by tenphong,mshs");            
            lbmucan.Text = "Mức ăn một bữa (Sáng/Trưa/Chiều) là: " + string.Format("{0:0" + decimalChar + "0}", classdc.dungchung.kieudouble(Settings1.Default.mucansang.ToString())) + " đồng/" + string.Format("{0:0" + decimalChar + "0}", classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString())) + " đồng/" + string.Format("{0:0" + decimalChar + "0}", classdc.dungchung.kieudouble(Settings1.Default.mucantoi.ToString())) + " đồng";
            txtntanb.Text = DateTime.Today.ToString();
            phong();            
        }
        private void phong()
        {
            string sql = "Select * From phong";
            DataTable dt = Connect.TruyVandt(sql);
            cbtenphongb.Items.Clear();
            cbtenphongb.DataSource = dt;
            cbtenphongb.DisplayMember = "tenphong";
            cbtenphongb.ValueMember = "tenphong";
        }
        private void lop()
        {
            string sql = "Select * From phong";
            DataTable dt = Connect.TruyVandt(sql);
            //cboLop.Items.Clear();
            cboLop.DataSource = dt;
            cboLop.DisplayMember = "tenphong";
            cboLop.ValueMember = "tenphong";            
        } 
        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string thu(string nt)
        {
            string kq = "",kq1="";
            kq = Convert.ToDateTime(nt).DayOfWeek.ToString();
            try
            {
                switch (kq)
                {
                    case "Monday":
                        kq1 = "Thứ 2";
                        break;
                    case "Tuesday":
                        kq1 = "Thứ 3";
                        break;
                    case "Wednesday":
                        kq1 = "Thứ 4";
                        break;
                    case "Thursday":
                        kq1 = "Thứ 5";
                        break;
                    case "Friday":
                        kq1 = "Thứ 6";
                        break;
                    case "Saturday":
                        kq1 = "Thứ 7";
                        break;
                    case "Sunday":
                        kq1 = "Chủ nhật";
                        break;                                      
                    default:
                        kq1 = "";
                        break;
                }
            }
            catch
            {
                kq1 = "";
            }
            return kq1;            
        }
        private int tuanthu(string nt)
        {
            int tuan = 0;
            string ngay = "";
            int a = 0,b =1,c=0;
            string[] ntn = nt.Split('/');
            for (int i = 1; i <= 31; i++)
            {                
                try
                {
                    ngay = i.ToString("00") + "/" + ntn[1] + "/" + ntn[2];
                    if (thu(ngay) == "Chủ nhật")
                    {                        
                        tuan = tuan + 1;
                        a = i;                        
                        if ((Convert.ToInt16(ntn[0])>=b)&&(Convert.ToInt16(ntn[0])<=a))
                        {                            
                            break;
                        }
                        b = i;
                    }
                    if (thu(i.ToString() + "/" + ntn[1] + "/" + ntn[2]) != "")
                    {
                        c = i;
                    }
                }
                catch
                {
                }                
            }
            if (c > a)
            {
                tuan = tuan + 1;
            }
            return tuan;
        }        
        private void tbtTroGiup_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tuanthu(txtntanb.Text).ToString());
        }
        private void tbtLuu_Click(object sender, EventArgs e)
        {

        }
        private void txtntanb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                grcKQ.DataSource = Connect.Loadgrc("Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs");
                if (grvKQ.RowCount == 0)
                {
                    tbtLuu.Enabled = true;
                    tbtSua.Enabled = false;
                }
                else
                {
                    tbtLuu.Enabled = false;
                    tbtSua.Enabled = true;
                }
            }
            catch
            {
            }
        }
        private void cbtenphongb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                grcKQ.DataSource = Connect.Loadgrc("Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs");
                if (grvKQ.RowCount == 0)
                {
                    tbtLuu.Enabled = true;
                    tbtSua.Enabled = false;
                }
                else
                {
                    tbtLuu.Enabled = false;
                    tbtSua.Enabled = true;
                }
            }
            catch
            {
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa toàn bộ báo ăn này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = "Delete * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%'";
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    Connect.LuuDL(cmd);
                    grcKQ.DataSource = null;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xóa, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (grvKQ.RowCount == 0)
            {
                tbtLuu.Enabled = true;
                tbtSua.Enabled = false;
            }
            else
            {
                tbtLuu.Enabled = false;
                tbtSua.Enabled = true;
            }
        }
        private void grvKQ_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //try
            //{
            //    if (e.Column.FieldName == "BS1" || e.Column.FieldName == "GC")
            //    {
            //        string sql = "Update baoan Set BS=@BS,BC=@BC,BT=@BT,GC=@GC,BS1=@BS1,BC1=@BC1,BT1=@BT1 Where idbaoan = " + Convert.ToInt64(grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colidbaoan).ToString());
            //        OleDbCommand cmd = new OleDbCommand();
            //        cmd.CommandText = sql;
            //        if (grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBS1).ToString() == "True")
            //            cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 1;
            //        else
            //            cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 0;
            //        if (grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBC1).ToString() == "True")
            //            cmd.Parameters.Add("@BC", OleDbType.Integer).Value = 1;
            //        else
            //            cmd.Parameters.Add("@BC", OleDbType.Integer).Value = 0;
            //        if (grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBT1).ToString() == "True")
            //            cmd.Parameters.Add("@BT", OleDbType.Integer).Value = 1;
            //        else
            //            cmd.Parameters.Add("@BT", OleDbType.Integer).Value = 0;
            //        cmd.Parameters.Add("@GC", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colGC).ToString();
            //        cmd.Parameters.Add("@BS1", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBS1);
            //        cmd.Parameters.Add("@BC1", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBC1);
            //        cmd.Parameters.Add("@BT1", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBT1);
            //        Connect.LuuDL(cmd);
            //    }
            //    //if (e.Column.FieldName == "BS1"  && grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBS1).ToString() == "False")
            //    //    grvKQ.Appearance.EvenRow.BackColor = Color.Red;
            //}
            //catch
            //{
            //    MessageBox.Show("Có lỗi khi thay đổi, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }
        private void grvKQ_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //SendKeys.Send("{Tab}");
        }
        private void tbtIn_Click(object sender, EventArgs e)
        {
            grcKQ.Enabled = false;
            grbCIn.Visible = true;
            rbtnbaoan.Checked = true;            
        }
        private void Inbaoan()
        {
            string[] nt = txtntanb.Text.Split('/');
            try
            {
                string sql = "";
                if(rbtnbaoan.Checked == true)
                    sql = "Select * From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' and BS = 1 order by tenphong,mshs";
                if(rbtnKbaoan.Checked == true)
                    sql = "Select * From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' and BS <> 1 order by tenphong,mshs";
                if (rbtnIn.Checked == true)
                    sql = "Select * From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs";
                DataSet ds = new DataSet();
                ds = Modules.Connect.Loadds(ds, sql, "baoan");
                Reports.rptbaoan rpt = new Reports.rptbaoan();
                Forms.frmHienThi frm = new Forms.frmHienThi();
                rpt.tendv.Value = thongtinketxuat.Default.tendv.ToString();
                rpt.ntkx.Value = thongtinketxuat.Default.diadanh.ToString() + ", ngày " + nt[0] + " tháng " + nt[1] + " năm " + nt[2];
                rpt.nlb.Value = thongtinketxuat.Default.nlb.ToString();
                rpt.ttdv.Value = thongtinketxuat.Default.ttdv.ToString();
                rpt.sshs.Value = ds.Tables["baoan"].Rows.Count;
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
              

        private void txtntanb_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtntanb_Leave(object sender, EventArgs e)
        {
            try
            {
                txtntanb.Text = clsbqkpbt.banquyen.dtngaysinh(txtntanb.Text);
            }
            catch
            {
                txtntanb.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Today);
            }
        }
        private void frmnhapbaoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dcts.taoTG(false, dt,"STT","idbaoan", "mshs", "tenhs", "tenphong", "thu", "tuanthu", "BS", "MA", "GC", "MUCHT", "MASANG");
            dt.Columns.Add("BS1", Type.GetType("System.Boolean"));
            dt.Columns.Add("ntan", Type.GetType("System.DateTime"));
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            try
            {
                double i = 0;
                if (txtntanb.Text != "  /  /")
                {
                    if (grvKQ.RowCount == 0)
                    {
                        string sql = "Select * From hocsinh Where tenphong = '" + cbtenphongb.Text + "' and ht = 'Đi học' and mshs Not in (Select mshs From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                        sql = sql + " and tenphong = '" + cbtenphongb.Text + "')";
                        foreach (DataRow item in Connect.TruyVandt(sql).Rows)
                        {
                            dt.ImportRow(item);
                        }
                        foreach (DataRow row in dt.Rows)
                        {
                            i += 1;
                            row["BS1"] = "True";
                            row["MA"] = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                            row["MUCHT"] = classdc.dungchung.kieudouble(Settings1.Default.mucanht.ToString());
                            row["MASANG"] = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                            row["ntan"] = Convert.ToDateTime(txtntanb.Text, cultuere);
                            row["thu"] = thu(txtntanb.Text);
                            row["tuanthu"] = tuanthu(txtntanb.Text);
                            row["BS"] = "1";
                            row["STT"] = i;
                            row["idbaoan"] = 0;

                        }                       
                    }                    
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc tạo, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            grcKQ.DataSource = dt;
        }
        private void btneXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết báo ăn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int BG = grvKQ.FocusedRowHandle - 1;
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
                cmd.CommandText = "Delete * From baoan Where idbaoan = " + Convert.ToInt64(grvKQ.GetFocusedRowCellValue(colidbaoan).ToString());
                KPBT.Modules.Connect.LuuDL(cmd);
                int So = grvKQ.FocusedRowHandle;
                if (So == (grvKQ.RowCount - 2))
                    grvKQ.MovePrev();
                grvKQ.DeleteRow(So);
                if (grvKQ.RowCount > 0)
                    for (int i = 0; i < grvKQ.RowCount - 1; i++)
                        grvKQ.SetRowCellValue(i, colSTT, i + 1);
            }
            if (grvKQ.RowCount == 0)
            {
                tbtLuu.Enabled = true;
                tbtSua.Enabled = false;
            }
            else
            {
                tbtLuu.Enabled = false;
                tbtSua.Enabled = true;
            }
        }
        private void grvKQ_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.Column.FieldName == "BS1")
            //{
            //    string category = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBS1).ToString();
            //    if (category == "False")
            //        e.Appearance.BackColor = Color.Red;
            //}
        }
        private void setmau()
        {
            for (int i = 0; i < grvKQ.RowCount; i++)
            {
                if (grvKQ.GetRowCellValue(i, colBS1).ToString() == "False")
                    grvKQ.Appearance.EvenRow.BackColor = Color.Red;
            }
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dcts.taoTG(false, dt, "STT", "idbaoan", "mshs", "tenhs", "tenphong", "thu", "tuanthu", "BS", "MA", "GC", "MUCHT", "MASANG");
            dt.Columns.Add("BS1", Type.GetType("System.Boolean"));
            dt.Columns.Add("ntan", Type.GetType("System.DateTime"));
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            try
            {
                double i = 0;
                if (txtntanb.Text != "  /  /")
                {
                    string sqlin = "Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs";
                    foreach (DataRow item in Connect.TruyVandt(sqlin).Rows)
                    {
                        dt.ImportRow(item);
                    }
                    string sql = "Select * From hocsinh Where tenphong = '" + cbtenphongb.Text + "' and ht = 'Đi học' and mshs Not in (Select mshs From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                    sql = sql + " and tenphong = '" + cbtenphongb.Text + "')";
                    foreach (DataRow item in Connect.TruyVandt(sql).Rows)
                    {
                        dt.ImportRow(item);
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["idbaoan"].ToString() == "")
                        {
                            i += 1;
                            row["BS1"] = "True";
                            row["MA"] = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                            row["MUCHT"] = classdc.dungchung.kieudouble(Settings1.Default.mucanht.ToString());
                            row["MASANG"] = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                            row["ntan"] = Convert.ToDateTime(txtntanb.Text, cultuere);
                            row["thu"] = thu(txtntanb.Text);
                            row["tuanthu"] = tuanthu(txtntanb.Text);
                            row["BS"] = "1";
                            row["STT"] = i;
                            row["idbaoan"] = 0;
                        }

                    }
                }
                grcKQ.DataSource = dt;
            }
            catch { }            
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            Inbaoan();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            grbCIn.Visible = false;
            grcKQ.Enabled = true;
        }
        private double sotien(string mshs, string thang)
        {
            double kq = 0;
            string sql = "Select sotienphaithu From thutien inner join dmthu on thutien.makhthu = dmthu.makhthu where thang = " + double.Parse(thang)  + " and thutien.mshs = '" + mshs + "' and dmthu.tenkhoanthu = 'Tiền ăn'";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq += classdc.dungchung.kieudouble(dr["sotienphaithu"].ToString());
            }
            dr.Close();
            return kq;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            grvKQ.CloseEditor();
            grvKQ.MoveFirst();
            if (grvKQ.RowCount == 0)
            {
                MessageBox.Show("Không có học sinh nào báo ăn. Bạn hãy kiểm tra lại!", "Thông báo");
            }
            else
            {        
        
                for (int i = 0; i < grvKQ.RowCount; i++)
                {
                    if (grvKQ.GetRowCellValue(i, colidbaoan).ToString() == "0")
                    {
                        string sqlin = "Insert into baoan(mshs,tenhs,tenphong,ntan,thu,tuanthu,BS,MA,GC,BS1,MUCHT,MASANG) values(@mshs,@tenhs,@tenphong,@ntan,@thu,@tuanthu,@BS,@MA,@GC,@BS1,@MUCHT,@MASANG)";
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = sqlin;
                        cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmshs);
                        cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltenhs);
                        cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltenphong);
                        cmd.Parameters.Add("@ntan", OleDbType.Date).Value = grvKQ.GetRowCellValue(i, colntan);
                        cmd.Parameters.Add("@thu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colthu);
                        cmd.Parameters.Add("@tuanthu", OleDbType.Integer).Value = grvKQ.GetRowCellValue(i, coltuanthu);
                        cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 1;
                        cmd.Parameters.Add("@MA", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                        cmd.Parameters.Add("@GC", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colGC);
                        cmd.Parameters.Add("@BS1", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(i, colBS1);
                        cmd.Parameters.Add("@MUCHT", OleDbType.Double).Value = sotien(grvKQ.GetRowCellValue(i, colmshs).ToString(), DateTime.Parse(txtntanb.Text).Month.ToString());
                        cmd.Parameters.Add("@MASANG", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                        Connect.LuuDL(cmd);
                    }
                    else
                    {
                        string sqlup = "Update baoan set mshs=@mshs,tenhs =@tenhs,tenphong=@tenphong,ntan=@ntan,thu=@thu,tuanthu=@tuanthu,BS=@BS,MA=@MA,GC=@GC,BS1=@BS1,MUCHT=@MUCHT,MASANG=@MASANG where idbaoan =" + grvKQ.GetRowCellValue(i, colidbaoan);
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = sqlup;
                        cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colmshs);
                        cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltenhs);
                        cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, coltenphong);
                        cmd.Parameters.Add("@ntan", OleDbType.Date).Value = grvKQ.GetRowCellValue(i, colntan);
                        cmd.Parameters.Add("@thu", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colthu);
                        cmd.Parameters.Add("@tuanthu", OleDbType.Integer).Value = grvKQ.GetRowCellValue(i, coltuanthu);
                        if (grvKQ.GetRowCellValue(i, colBS1).ToString() == "True")
                            cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 1;
                        else
                            cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 0;
                        cmd.Parameters.Add("@MA", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                        cmd.Parameters.Add("@GC", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(i, colGC);
                        cmd.Parameters.Add("@BS1", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(i, colBS1);
                        cmd.Parameters.Add("@MUCHT", OleDbType.Double).Value = sotien(grvKQ.GetRowCellValue(i, colmshs).ToString(), DateTime.Parse(txtntanb.Text).Month.ToString());
                        cmd.Parameters.Add("@MASANG", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                        Connect.LuuDL(cmd);
                    }
                }
                grcKQ.DataSource = Connect.Loadgrc("Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs");
                MessageBox.Show("Bạn đã lưu thành công báo ăn ngày " + txtntanb.Text + " của phòng " + cbtenphongb.Text, "Thông báo");
                tbtLuu.Enabled = false;
                tbtSua.Enabled = true;
            }
        }
        private void tbtSua_Click(object sender, EventArgs e)
        {
            tbtLuu.Enabled = true;
            tbtSua.Enabled = false;
        }
        private void txtTenhs_TextChanged(object sender, EventArgs e)
        {
            if (txtTenhs.Text.Length > 0)
                grvKQ.Columns["tenhs"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[tenhs] like '" + txtTenhs.Text + "%'");
            else
                grvKQ.Columns["tenhs"].ClearFilter();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            lop();
            grpdshs.Visible = !grpdshs.Visible;
            grbTraCuu.Visible = !grbTraCuu.Visible;            
            cboLop.Text = "";
            grcKQ.DataSource = Connect.Loadgrc("Select baoan.*, Month(ntan) as thang From baoan order by tenphong,mshs");
        }

        private void cboLop_TextChanged(object sender, EventArgs e)
        {
            if (cboLop.Text.Length > 0)
                grvKQ.Columns["tenphong"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[tenphong] = '" + cboLop.Text + "'");
            else
                grvKQ.Columns["tenphong"].ClearFilter();
        }

        private void cboThang_TextChanged(object sender, EventArgs e)
        {
            if (cboThang.Text.Length > 0)
                grvKQ.Columns["thang"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo("[thang] = '" + cboThang.Text + "'");
            else
                grvKQ.Columns["thang"].ClearFilter();
        }
    }
}
