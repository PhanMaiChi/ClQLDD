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
    public partial class frmnhapbaoan : Office2007Form
    {
        public string decimalChar = "";
        public frmnhapbaoan()
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            try
            {
                if (txtntanb.Text != "  /  /")
                {
                    string sql = "Select * From hocsinh Where tenphong Like '" + cbtenphongb.Text + "%' and ht = 'Đi học' and mshs Not in (Select mshs From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                    sql = sql + " and tenphong like '" + cbtenphongb.Text + "%')";
                    OleDbDataReader dr = Connect.TruyVandr(sql);
                    while (dr.Read())
                    {
                        string sqlin = "Insert into baoan(mshs,tenhs,tenphong,ntan,thu,tuanthu,BS,BC,BT,MA,GC,BS1,BC1,BT1,MASANG,MATOI,MUCHT) values(@mshs,@tenhs,@tenphong,@ntan,@thu,@tuanthu,@BS,@BC,@BT,@MA,@GC,@BS1,@BC1,@BT1,@MASANG,@MATOI,@MUCHT)";
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = sqlin;
                        cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = dr["mshs"].ToString();
                        cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = dr["tenhs"].ToString();
                        cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = dr["tenphong"].ToString();
                        cmd.Parameters.Add("@ntan", OleDbType.Date).Value = Convert.ToDateTime(txtntanb.Text, cultuere);
                        cmd.Parameters.Add("@thu", OleDbType.VarChar).Value = thu(txtntanb.Text);
                        cmd.Parameters.Add("@tuanthu", OleDbType.Integer).Value = tuanthu(txtntanb.Text);
                        cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 1;
                        cmd.Parameters.Add("@BC", OleDbType.Integer).Value = 1;
                        cmd.Parameters.Add("@BT", OleDbType.Integer).Value = 1;
                        cmd.Parameters.Add("@MA", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                        cmd.Parameters.Add("@GC", OleDbType.VarChar).Value = "";
                        cmd.Parameters.Add("@BS1", OleDbType.Boolean).Value = true;
                        cmd.Parameters.Add("@BC1", OleDbType.Boolean).Value = true;
                        cmd.Parameters.Add("@BT1", OleDbType.Boolean).Value = true;
                        cmd.Parameters.Add("@MASANG", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucansang.ToString());
                        cmd.Parameters.Add("@MATOI", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucantoi.ToString());
                        cmd.Parameters.Add("@MUCHT", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucanht.ToString());
                        Connect.LuuDL(cmd);
                    }
                    dr.Close();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc tạo, hãy kiểm tra lại!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            grcKQ.DataSource = Connect.Loadgrc("Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs");
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
            }
            catch
            {
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            try
            {
                if (txtntanb.Text != "  /  /")
                {
                    if (grvKQ.RowCount == 0)
                    {
                        string sql = "Select * From hocsinh Where tenphong Like '" + cbtenphongb.Text + "%' and ht = 'Đi học' and mshs Not in (Select mshs From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                        sql = sql + " and tenphong like '" + cbtenphongb.Text + "%')";
                        OleDbDataReader dr = Connect.TruyVandr(sql);
                        while (dr.Read())
                        {
                            string sqlin = "Insert into baoan(mshs,tenhs,tenphong,ntan,thu,tuanthu,BS,BC,BT,MA,GC,BS1,BC1,BT1,MUCHT) values(@mshs,@tenhs,@tenphong,@ntan,@thu,@tuanthu,@BS,@BC,@BT,@MA,@GC,@BS1,@BC1,@BT1,@MUCHT)";
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = sqlin;
                            cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = dr["mshs"].ToString();
                            cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = dr["tenhs"].ToString();
                            cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = dr["tenphong"].ToString();
                            cmd.Parameters.Add("@ntan", OleDbType.Date).Value = Convert.ToDateTime(txtntanb.Text, cultuere);
                            cmd.Parameters.Add("@thu", OleDbType.VarChar).Value = thu(txtntanb.Text);
                            cmd.Parameters.Add("@tuanthu", OleDbType.Integer).Value = tuanthu(txtntanb.Text);
                            cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 0;
                            cmd.Parameters.Add("@BC", OleDbType.Integer).Value = 1;
                            cmd.Parameters.Add("@BT", OleDbType.Integer).Value = 0;
                            cmd.Parameters.Add("@MA", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucan.ToString());
                            cmd.Parameters.Add("@GC", OleDbType.VarChar).Value = "";
                            cmd.Parameters.Add("@BS1", OleDbType.Boolean).Value = false;
                            cmd.Parameters.Add("@BC1", OleDbType.Boolean).Value = true;
                            cmd.Parameters.Add("@BT1", OleDbType.Boolean).Value = false;
                            cmd.Parameters.Add("@MUCHT", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucanht.ToString());
                            Connect.LuuDL(cmd);
                        }
                        dr.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có muốn tạo bữa ăn trưa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string sqlup = "Update baoan Set BC=1,BC1=true where tenphong Like '" + cbtenphongb.Text + "%' and ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                            OleDbCommand cmdup = new OleDbCommand();
                            cmdup.CommandText = sqlup;
                            Connect.LuuDL(cmdup);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc tạo, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            grcKQ.DataSource = Connect.Loadgrc("Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            try
            {
                if (txtntanb.Text != "  /  /")
                {
                    if (grvKQ.RowCount == 0)
                    {
                        string sql = "Select * From hocsinh Where tenphong Like '" + cbtenphongb.Text + "%' and ht = 'Đi học' and mshs Not in (Select mshs From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                        sql = sql + " and tenphong like '" + cbtenphongb.Text + "%')";
                        OleDbDataReader dr = Connect.TruyVandr(sql);
                        while (dr.Read())
                        {
                            string sqlin = "Insert into baoan(mshs,tenhs,tenphong,ntan,thu,tuanthu,BS,BC,BT,MATOI,GC,BS1,BC1,BT1,MUCHT) values(@mshs,@tenhs,@tenphong,@ntan,@thu,@tuanthu,@BS,@BC,@BT,@MATOI,@GC,@BS1,@BC1,@BT1,@MUCHT)";
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = sqlin;
                            cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = dr["mshs"].ToString();
                            cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = dr["tenhs"].ToString();
                            cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = dr["tenphong"].ToString();
                            cmd.Parameters.Add("@ntan", OleDbType.Date).Value = Convert.ToDateTime(txtntanb.Text, cultuere);
                            cmd.Parameters.Add("@thu", OleDbType.VarChar).Value = thu(txtntanb.Text);
                            cmd.Parameters.Add("@tuanthu", OleDbType.Integer).Value = tuanthu(txtntanb.Text);
                            cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 0;
                            cmd.Parameters.Add("@BC", OleDbType.Integer).Value = 0;
                            cmd.Parameters.Add("@BT", OleDbType.Integer).Value = 1;
                            cmd.Parameters.Add("@MATOI", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucantoi.ToString());
                            cmd.Parameters.Add("@GC", OleDbType.VarChar).Value = "";
                            cmd.Parameters.Add("@BS1", OleDbType.Boolean).Value = false;
                            cmd.Parameters.Add("@BC1", OleDbType.Boolean).Value = false;
                            cmd.Parameters.Add("@BT1", OleDbType.Boolean).Value = true;
                            cmd.Parameters.Add("@MUCHT", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucanht.ToString());
                            Connect.LuuDL(cmd);
                        }
                        dr.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có muốn tạo bữa ăn tối!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string sqlup = "Update baoan Set BT=1,BT1=true where tenphong Like '" + cbtenphongb.Text + "%' and ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                            OleDbCommand cmdup = new OleDbCommand();
                            cmdup.CommandText = sqlup;
                            Connect.LuuDL(cmdup);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc tạo, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            grcKQ.DataSource = Connect.Loadgrc("Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs");
        }

        private void tbtXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa báo ăn này!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = "Delete * From baoan Where idbaoan = " + Convert.ToInt64(grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colidbaoan).ToString());
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = sql;
                    Connect.LuuDL(cmd);
                    grcKQ.DataSource = Connect.Loadgrc("Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi xóa, hãy kiểm tra lại!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        }

        private void grvKQ_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                string sql = "Update baoan Set BS=@BS,BC=@BC,BT=@BT,GC=@GC,BS1=@BS1,BC1=@BC1,BT1=@BT1 Where idbaoan = " + Convert.ToInt64(grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colidbaoan).ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;
                if (grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBS1).ToString() == "True")
                    cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 1;
                else
                    cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 0;
                if (grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBC1).ToString() == "True")
                    cmd.Parameters.Add("@BC", OleDbType.Integer).Value = 1;
                else
                    cmd.Parameters.Add("@BC", OleDbType.Integer).Value = 0;
                if (grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBT1).ToString() == "True")
                    cmd.Parameters.Add("@BT", OleDbType.Integer).Value = 1;
                else
                    cmd.Parameters.Add("@BT", OleDbType.Integer).Value = 0;
                cmd.Parameters.Add("@GC", OleDbType.VarChar).Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colGC).ToString();
                cmd.Parameters.Add("@BS1", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBS1);
                cmd.Parameters.Add("@BC1", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBC1);
                cmd.Parameters.Add("@BT1", OleDbType.Boolean).Value = grvKQ.GetRowCellValue(grvKQ.FocusedRowHandle, colBT1);
                Connect.LuuDL(cmd);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi thay đổi, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void grvKQ_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            SendKeys.Send("{Tab}");
        }

        private void tbtIn_Click(object sender, EventArgs e)
        {
            string[] nt = txtntanb.Text.Split('/');
            try
            {
                string sql = "Select * From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs";
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
                txtntanb.Text = "";
            }
        }

        private void frmnhapbaoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            try
            {
                if (txtntanb.Text != "  /  /")
                {
                    if (grvKQ.RowCount == 0)
                    {
                        string sql = "Select * From hocsinh Where tenphong Like '" + cbtenphongb.Text + "%' and ht = 'Đi học' and mshs Not in (Select mshs From baoan where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                        sql = sql + " and tenphong like '" + cbtenphongb.Text + "%')";
                        OleDbDataReader dr = Connect.TruyVandr(sql);
                        while (dr.Read())
                        {
                            string sqlin = "Insert into baoan(mshs,tenhs,tenphong,ntan,thu,tuanthu,BS,BC,BT,MA,GC,BS1,BC1,BT1,MUCHT) values(@mshs,@tenhs,@tenphong,@ntan,@thu,@tuanthu,@BS,@BC,@BT,@MA,@GC,@BS1,@BC1,@BT1,@MUCHT)";
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandText = sqlin;
                            cmd.Parameters.Add("@mshs", OleDbType.VarChar).Value = dr["mshs"].ToString();
                            cmd.Parameters.Add("@tenhs", OleDbType.VarChar).Value = dr["tenhs"].ToString();
                            cmd.Parameters.Add("@tenphong", OleDbType.VarChar).Value = dr["tenphong"].ToString();
                            cmd.Parameters.Add("@ntan", OleDbType.Date).Value = Convert.ToDateTime(txtntanb.Text, cultuere);
                            cmd.Parameters.Add("@thu", OleDbType.VarChar).Value = thu(txtntanb.Text);
                            cmd.Parameters.Add("@tuanthu", OleDbType.Integer).Value = tuanthu(txtntanb.Text);
                            cmd.Parameters.Add("@BS", OleDbType.Integer).Value = 1;
                            cmd.Parameters.Add("@BC", OleDbType.Integer).Value = 0;
                            cmd.Parameters.Add("@BT", OleDbType.Integer).Value = 0;
                            cmd.Parameters.Add("@MASANG", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucansang.ToString());
                            cmd.Parameters.Add("@GC", OleDbType.VarChar).Value = "";
                            cmd.Parameters.Add("@BS1", OleDbType.Boolean).Value = true;
                            cmd.Parameters.Add("@BC1", OleDbType.Boolean).Value = false;
                            cmd.Parameters.Add("@BT1", OleDbType.Boolean).Value = false;
                            cmd.Parameters.Add("@MUCHT", OleDbType.Double).Value = classdc.dungchung.kieudouble(Settings1.Default.mucanht.ToString());
                            Connect.LuuDL(cmd);
                        }
                        dr.Close();
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có muốn tạo bữa ăn sáng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string sqlup = "Update baoan Set BS=1,BS1=true,MASANG=" + classdc.dungchung.kieudouble(Settings1.Default.mucansang.ToString()) + " where tenphong Like '" + cbtenphongb.Text + "%' and ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "#";
                            OleDbCommand cmdup = new OleDbCommand();
                            cmdup.CommandText = sqlup;
                            Connect.LuuDL(cmdup);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc tạo, hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            grcKQ.DataSource = Connect.Loadgrc("Select * From baoan Where ntan = #" + classdc.dungchung.thaydoi(txtntanb.Text) + "# and tenphong Like '" + cbtenphongb.Text + "%' order by tenphong,mshs");
        }
    }
}
