using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.OleDb;
using KPBT.Modules;
using System.Globalization;

namespace KPBT.Forms
{
    public partial class frmnhapkehoachtuan : Office2007Form
    {
        public frmnhapkehoachtuan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboNam.EditValue = DateTime.Now.Year;            
            loadtuan();
            cboThang.EditValue = Convert.ToInt64(tuan(true)).ToString("00");
        }

        private DateTime FirstDateOfWeek(int nam, int weekNum)
        {            
            DateTime jan1 = new DateTime(nam, 1, 1);

            int daysOffset = (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;

            DateTime firstMonday = jan1.AddDays(daysOffset);

            int firstWeek = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(jan1, CultureInfo.CurrentCulture.DateTimeFormat.CalendarWeekRule, CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek);

            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }

            return firstMonday.AddDays(weekNum * 7);          

        }

        private void reset()
        {
            grbT2.Text = "";
            grbT3.Text = "";
            grbT4.Text = "";
            grbT5.Text = "";
            grbT6.Text = "";
            grbT7.Text = "";
            grbcn.Text = "";
            lbc1.Appearance.BackColor = Color.Transparent;
            lbc2.Appearance.BackColor = Color.Transparent;
            lbc3.Appearance.BackColor = Color.Transparent;
            lbc4.Appearance.BackColor = Color.Transparent;
            lbc5.Appearance.BackColor = Color.Transparent;
            lbc6.Appearance.BackColor = Color.Transparent;
            lbc7.Appearance.BackColor = Color.Transparent;
        }

        private string thu(string nt)
        {
            string kq = "", kq1 = "";
            kq = Convert.ToDateTime(nt).DayOfWeek.ToString();
            try
            {
                switch (kq)
                {
                    case "Monday":
                        kq1 = "T2";
                        break;
                    case "Tuesday":
                        kq1 = "T3";
                        break;
                    case "Wednesday":
                        kq1 = "T4";
                        break;
                    case "Thursday":
                        kq1 = "T5";
                        break;
                    case "Friday":
                        kq1 = "T6";
                        break;
                    case "Saturday":
                        kq1 = "T7";
                        break;
                    case "Sunday":
                        kq1 = "cn";
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

        private void loadtuan()
        {
            cboThang.Properties.Items.Clear();
            cboThang.Text = "";
            cboTuan.Properties.Items.Clear();
            cboTuan.Text = "";
            for (int i = 1; i <= Convert.ToInt64(tuan(false)); i++)
            {
                cboThang.Properties.Items.Add(i.ToString("00"));
                cboTuan.Properties.Items.Add(i.ToString("00"));
            }
        }        

        private string tuan(Boolean dk)
        {          
            DateTime date1 = new DateTime();
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            if (dk == false)
            {
                int nam = Convert.ToInt16(cboNam.EditValue);                
                date1 = new DateTime(nam, 12, 31);
            }
            else
            {                
                date1 = DateTime.Now;
            }
            System.Globalization.Calendar cal = dfi.Calendar;
            return cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek).ToString();
        }

        private int tuanthu(string nt)
        {
            int tuan = 0;
            string ngay = "";
            int a = 0, b = 1, c = 0;
            string[] ntn = nt.Split('/');
            for (int i = 1; i <= 31; i++)
            {
                try
                {
                    ngay = i.ToString("00") + "/" + ntn[1] + "/" + ntn[2];
                    if (thu(ngay) == "8")
                    {
                        tuan = tuan + 1;
                        a = i;
                        if ((Convert.ToInt16(ntn[0]) >= b) && (Convert.ToInt16(ntn[0]) <= a))
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

        string text(string ngay)
        {
            string kq ="";            
            OleDbDataReader dr =  Connect.TruyVandr("Select distinct TenBA from tblkehoach" +
                 " where MaNT = '" + Connect.GetStr(cboNhomTuoi.EditValue) + "' and Ngaythang = #" + classdc.dungchung.thaydoi(ngay) + "# ");
            while (dr.Read())
            {
                kq += "- " + dr["TenBA"].ToString() + "\r\n";
            }
            return kq;
        }

        private void ganten(string ten, string ngay )
        {            
            switch (ten)
            {
                #region Tuần 1
                case "grbT2":                    
                    grbT2.Text = "Thứ 2 " + ngay;
                    lbc1.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc1.Appearance.BackColor = Color.Khaki;
                    break;
                case "grbT3":                    
                    grbT3.Text = "Thứ 3 " + ngay;
                    lbc2.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc2.Appearance.BackColor = Color.Khaki;
                    break;
                case "grbT4":
                    grbT4.Text = "Thứ 4 " + ngay;
                    lbc3.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc3.Appearance.BackColor = Color.Khaki;
                    break;
                case "grbT5":
                    grbT5.Text = "Thứ 5 " + ngay;
                    lbc4.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc4.Appearance.BackColor = Color.Khaki;
                    break;
                case "grbT6":
                    grbT6.Text = "Thứ 6 " + ngay;
                    lbc5.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc5.Appearance.BackColor = Color.Khaki;
                    break;
                case "grbT7":
                    grbT7.Text = "Thứ 7 " + ngay;
                    lbc6.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc6.Appearance.BackColor = Color.Khaki;
                    break;
                case "grbcn":
                    grbcn.Text = "CN " + ngay;
                    lbc7.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc7.Appearance.BackColor = Color.Khaki;
                    break;
                #endregion               
            }
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] s = FirstDateOfWeek().Split('/');            
            try
            {
                int nam = Convert.ToInt16(cboNam.EditValue);
                int weekNum = Convert.ToInt16(cboThang.EditValue);
                reset();
                for (DateTime i = FirstDateOfWeek(nam, weekNum); i <= FirstDateOfWeek(nam, weekNum).AddDays(6); i = i.AddDays(1))
                {
                    string x = "";
                    string ngay = i.ToShortDateString();                        
                    x = "grb" + thu(ngay);
                    ganten(x, ngay);                 
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình load lịch ăn. Bạn hãy chọn lại tháng và năm cần xem!", "Thông báo");
            }            
        }        

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboThang_SelectedIndexChanged(sender, e);
        }

        #region doubleclick

        private void doubleclick(string ten, object sender, EventArgs e)
        {
            if (Connect.GetStr(cboNhomTuoi.EditValue) == "")
            {
                MessageBox.Show("Nhóm tuổi không để trống. Bạn hãy chọn lại nhóm tuổi!", "Thông báo");
            }
            else
            {
                if (ten != "")
                {
                    string ngay = ten.Substring(ten.LastIndexOf(" ") + 1);
                    //string ngay = ten + "/" + cboThang.Text + "/" + cboNam.Text;
                    DC1.ngay = ngay;
                    DC1.nhomtuoi = cboNhomTuoi.EditValue.ToString();
                    using (Form frm = new frmThoaikehoach())
                    {
                        frm.ShowDialog();
                        Connect.Reconnect();
                        cboThang_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }
        private void grbT2_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grbT2.Text, sender, e);
        }

        private void grbT3_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grbT3.Text, sender, e);
        }

        private void grbT4_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grbT4.Text, sender, e);
        }

        private void grbT5_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grbT5.Text, sender, e);
        }

        private void grbT6_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grbT6.Text, sender, e);
        }

        private void grbT7_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grbT7.Text, sender, e);
        }

        private void grbcn_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grbcn.Text, sender, e);
        }
       
        #endregion

        private void tbtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmnhapkehoach_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }

        private void cboNhomTuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboThang_SelectedIndexChanged(sender, e);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (cboNhomTuoi.Text == "")
                MessageBox.Show("Bạn hãy chọn nhóm tuổi.", "Thông báo");
            else if (cboNhomTuoiT.Text == "")
                MessageBox.Show("Bạn hãy chọn nhóm tuổi cần tạo.", "Thông báo");
            else if (cboTuan.Text == "")
                MessageBox.Show("Bạn hãy chọn tuần kế hoạch cần tạo.", "Thông báo");            
            else if (cboThang.Text == cboTuan.Text && cboNhomTuoi.Text == cboNhomTuoiT.Text)
                MessageBox.Show("Tuần cần tạo và tuần tạo giống nhau. Bạn hãy chọn lại!", "Thông báo");
            else
            {
                int nam = Convert.ToInt16(cboNam.EditValue);
                int weekNum = Convert.ToInt16(cboThang.EditValue);
                int weekNumT = Convert.ToInt16(cboTuan.EditValue);
                int d = 0;
                DateTime ngay = FirstDateOfWeek(nam, weekNum);
                DateTime ngayT = FirstDateOfWeek(nam, weekNumT);
            Start:
                if (d == 7)
                    goto End;
                else
                {
                    string sql = "Select * From tblkehoach where ngaythang = #" + classdc.dungchung.thaydoi(ngay.ToShortDateString()) + "# and MaNT = '" + cboNhomTuoi.Text + "'";
                    OleDbDataReader dr = Connect.TruyVandr("Select * From tblkehoach where ngaythang = #" + classdc.dungchung.thaydoi(ngay.ToShortDateString()) + "# and MaNT = '" + cboNhomTuoi.Text + "'");
                    while (dr.Read())
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "Insert into tblkehoach (MaNT,Tuan,Ngaythang,MaTD,MaMA,TenBA,Tenbua) values (@MaNT,@Tuan,@Ngaythang,@MaTD,@MaMA,@TenBA,@Tenbua)";
                        cmd.Parameters.Add("@MaNT", OleDbType.VarChar).Value = cboNhomTuoiT.Text;
                        cmd.Parameters.Add("@Tuan", OleDbType.VarChar).Value = tuanthu(ngayT.ToShortDateString());
                        cmd.Parameters.Add("@Ngaythang", OleDbType.Date).Value = ngayT;
                        cmd.Parameters.Add("@MaTD", OleDbType.VarChar).Value = dr["MaTD"].ToString();
                        cmd.Parameters.Add("@MaMA", OleDbType.VarChar).Value = dr["MaMA"].ToString();
                        cmd.Parameters.Add("@TenBA", OleDbType.VarChar).Value = dr["TenBA"].ToString();
                        cmd.Parameters.Add("@Tenbua", OleDbType.VarChar).Value = dr["Tenbua"].ToString();
                        Connect.LuuDL(cmd);
                    }
                    dr.Close();
                    ngay = ngay.AddDays(1);
                    ngayT = ngayT.AddDays(1);
                    d++;
                    goto Start;
                }
            }
        End:            
            MessageBox.Show("Bạn đã tạo thành công kế hoạch ăn.", "Thông báo");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa kế hoạch ăn tuần này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int nam = Convert.ToInt16(cboNam.EditValue);
                int weekNum = Convert.ToInt16(cboThang.EditValue);
                DateTime ngay = FirstDateOfWeek(nam, weekNum);
                for (DateTime i = ngay; i <= ngay.AddDays(6); i = i.AddDays(1))
                {
                    Connect.ThaoTac("Delete * From tblkehoach where ngaythang = #" + classdc.dungchung.thaydoi(i.ToShortDateString()) + "# and MaNT = '" + cboNhomTuoi.Text + "'");
                }
                cboThang_SelectedIndexChanged(sender, e);
            }
        }        
    }

}
