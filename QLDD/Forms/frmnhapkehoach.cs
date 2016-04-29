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

namespace KPBT.Forms
{
    public partial class frmnhapkehoach : Office2007Form
    {
        public frmnhapkehoach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboNam.EditValue = DateTime.Now.Year;
            cboThang.EditValue = DateTime.Now.Month.ToString("00");
            //MessageBox.Show(DateTime.Now.ToShortDateString());
            //Connect.LoadDL(LuNhomtuoi, "MaNT", "TenNT","Select * From tblnhomtuoi");
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
                        kq1 = "2";
                        break;
                    case "Tuesday":
                        kq1 = "3";
                        break;
                    case "Wednesday":
                        kq1 = "4";
                        break;
                    case "Thursday":
                        kq1 = "5";
                        break;
                    case "Friday":
                        kq1 = "6";
                        break;
                    case "Saturday":
                        kq1 = "7";
                        break;
                    case "Sunday":
                        kq1 = "8";
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

        private void reset()
        {
            #region group
            grb12.Text = "";
            grb13.Text = "";
            grb14.Text = "";
            grb15.Text = "";
            grb16.Text = "";
            grb17.Text = "";
            grb18.Text = "";
            grb22.Text = "";
            grb23.Text = "";
            grb24.Text = "";
            grb25.Text = "";
            grb26.Text = "";
            grb27.Text = "";
            grb28.Text = "";
            grb32.Text = "";
            grb33.Text = "";
            grb34.Text = "";
            grb35.Text = "";
            grb36.Text = "";
            grb37.Text = "";
            grb38.Text = "";
            grb42.Text = "";
            grb43.Text = "";
            grb44.Text = "";
            grb45.Text = "";
            grb46.Text = "";
            grb47.Text = "";
            grb48.Text = "";
            grb52.Text = "";
            grb53.Text = "";
            grb54.Text = "";
            grb55.Text = "";
            grb56.Text = "";
            grb57.Text = "";
            grb58.Text = "";
            grb62.Text = "";
            grb63.Text = "";
            grb64.Text = "";
            grb65.Text = "";
            grb66.Text = "";
            grb67.Text = "";
            grb68.Text = "";
            #endregion

            #region Labelcontrol
            lbc12.Text = "";
            lbc13.Text = "";
            lbc14.Text = "";
            lbc15.Text = "";
            lbc16.Text = "";
            lbc17.Text = "";
            lbc18.Text = "";
            lbc22.Text = "";
            lbc23.Text = "";
            lbc24.Text = "";
            lbc25.Text = "";
            lbc26.Text = "";
            lbc27.Text = "";
            lbc28.Text = "";
            lbc32.Text = "";
            lbc33.Text = "";
            lbc34.Text = "";
            lbc35.Text = "";
            lbc36.Text = "";
            lbc37.Text = "";
            lbc38.Text = "";
            lbc42.Text = "";
            lbc43.Text = "";
            lbc44.Text = "";
            lbc45.Text = "";
            lbc46.Text = "";
            lbc47.Text = "";
            lbc48.Text = "";
            lbc52.Text = "";
            lbc53.Text = "";
            lbc54.Text = "";
            lbc55.Text = "";
            lbc56.Text = "";
            lbc57.Text = "";
            lbc58.Text = "";
            lbc62.Text = "";
            lbc63.Text = "";
            lbc64.Text = "";
            lbc65.Text = "";
            lbc66.Text = "";
            lbc67.Text = "";
            lbc68.Text = "";
            #endregion

            #region color
            lbc12.Appearance.BackColor = Color.Transparent;
            lbc13.Appearance.BackColor = Color.Transparent;
            lbc14.Appearance.BackColor = Color.Transparent;
            lbc15.Appearance.BackColor = Color.Transparent;
            lbc16.Appearance.BackColor = Color.Transparent;
            lbc17.Appearance.BackColor = Color.Transparent;
            lbc18.Appearance.BackColor = Color.Transparent;
            lbc22.Appearance.BackColor = Color.Transparent;
            lbc23.Appearance.BackColor = Color.Transparent;
            lbc24.Appearance.BackColor = Color.Transparent;
            lbc25.Appearance.BackColor = Color.Transparent;
            lbc26.Appearance.BackColor = Color.Transparent;
            lbc27.Appearance.BackColor = Color.Transparent;
            lbc28.Appearance.BackColor = Color.Transparent;
            lbc32.Appearance.BackColor = Color.Transparent;
            lbc33.Appearance.BackColor = Color.Transparent;
            lbc34.Appearance.BackColor = Color.Transparent;
            lbc35.Appearance.BackColor = Color.Transparent;
            lbc36.Appearance.BackColor = Color.Transparent;
            lbc37.Appearance.BackColor = Color.Transparent;
            lbc38.Appearance.BackColor = Color.Transparent;
            lbc42.Appearance.BackColor = Color.Transparent;
            lbc43.Appearance.BackColor = Color.Transparent;
            lbc44.Appearance.BackColor = Color.Transparent;
            lbc45.Appearance.BackColor = Color.Transparent;
            lbc46.Appearance.BackColor = Color.Transparent;
            lbc47.Appearance.BackColor = Color.Transparent;
            lbc48.Appearance.BackColor = Color.Transparent;
            lbc52.Appearance.BackColor = Color.Transparent;
            lbc53.Appearance.BackColor = Color.Transparent;
            lbc54.Appearance.BackColor = Color.Transparent;
            lbc55.Appearance.BackColor = Color.Transparent;
            lbc56.Appearance.BackColor = Color.Transparent;
            lbc57.Appearance.BackColor = Color.Transparent;
            lbc58.Appearance.BackColor = Color.Transparent;
            lbc62.Appearance.BackColor = Color.Transparent;
            lbc63.Appearance.BackColor = Color.Transparent;
            lbc64.Appearance.BackColor = Color.Transparent;
            lbc65.Appearance.BackColor = Color.Transparent;
            lbc66.Appearance.BackColor = Color.Transparent;
            lbc67.Appearance.BackColor = Color.Transparent;
            lbc68.Appearance.BackColor = Color.Transparent;
            #endregion
        }

        //private string tenkh(string ngay)
        //{
        //    //string kq = "";
        //    //OleDbDataReader dr = Connect.TruyVandr("Select MaTD FROM tblthucdon INNER JOIN tblkehoach ON tblthucdon.MaTD = tblkehoach.MaTD"+
        //    //    " where Ngaythang = #" + classdc.dungchung.thaydoi(ngay) + "#");
        //    //while (dr.Read())
        //    //{
        //    //    if(dr["MaTD"])
        //    //}
        //}

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

        private void ganten(string ten, int i, string ngay )
        {
            switch (ten)
            {
                #region Tuần 1
                case "grb12":
                    grb12.Text = i.ToString("00");
                    lbc12.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc12.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb13":
                    grb13.Text = i.ToString("00");
                    lbc13.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc13.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb14":
                    grb14.Text = i.ToString("00");
                    lbc14.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc14.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb15":
                    grb15.Text = i.ToString("00");
                    lbc15.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc15.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb16":
                    grb16.Text = i.ToString("00");
                    lbc16.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc16.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb17":
                    grb17.Text = i.ToString("00");
                    lbc17.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc17.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb18":
                    grb18.Text = i.ToString("00");
                    lbc18.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc18.Appearance.BackColor = Color.Khaki;
                    break;
                #endregion

                #region Tuần 2
                case "grb22":
                    grb22.Text = i.ToString("00");
                    lbc22.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc22.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb23":
                    grb23.Text = i.ToString("00");
                    lbc23.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc23.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb24":
                    grb24.Text = i.ToString("00");
                    lbc24.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc24.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb25":
                    grb25.Text = i.ToString("00");
                    lbc25.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc25.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb26":
                    grb26.Text = i.ToString("00");
                    lbc26.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc26.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb27":
                    grb27.Text = i.ToString("00");
                    lbc27.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc27.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb28":
                    grb28.Text = i.ToString("00");
                    lbc28.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc28.Appearance.BackColor = Color.Khaki;
                    break;
                #endregion

                #region Tuần 3
                case "grb32":
                    grb32.Text = i.ToString("00");
                    lbc32.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc32.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb33":
                    grb33.Text = i.ToString("00");
                    lbc33.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc33.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb34":
                    grb34.Text = i.ToString("00");
                    lbc34.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc34.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb35":
                    grb35.Text = i.ToString("00");
                    lbc35.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc35.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb36":
                    grb36.Text = i.ToString("00");
                    lbc36.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc36.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb37":
                    grb37.Text = i.ToString("00");
                    lbc37.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc37.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb38":
                    grb38.Text = i.ToString("00");
                    lbc38.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc38.Appearance.BackColor = Color.Khaki;
                    break;
                #endregion

                #region Tuần 4
                case "grb42":
                    grb42.Text = i.ToString("00");
                    lbc42.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc42.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb43":
                    grb43.Text = i.ToString("00");
                    lbc43.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc43.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb44":
                    grb44.Text = i.ToString("00");
                    lbc44.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc44.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb45":
                    grb45.Text = i.ToString("00");
                    lbc45.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc45.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb46":
                    grb46.Text = i.ToString("00");
                    lbc46.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc46.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb47":
                    grb47.Text = i.ToString("00");
                    lbc47.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc47.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb48":
                    grb48.Text = i.ToString("00");
                    lbc48.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc48.Appearance.BackColor = Color.Khaki;
                    break;
                #endregion

                #region Tuần 5
                case "grb52":
                    grb52.Text = i.ToString("00");
                    lbc52.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc52.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb53":
                    grb53.Text = i.ToString("00");
                    lbc53.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc53.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb54":
                    grb54.Text = i.ToString("00");
                    lbc54.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc54.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb55":
                    grb55.Text = i.ToString("00");
                    lbc55.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc55.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb56":
                    grb56.Text = i.ToString("00");
                    lbc56.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc56.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb57":
                    grb57.Text = i.ToString("00");
                    lbc57.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc57.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb58":
                    grb58.Text = i.ToString("00");
                    lbc58.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc58.Appearance.BackColor = Color.Khaki;
                    break;
                #endregion

                #region Tuần 6
                case "grb62":
                    grb62.Text = i.ToString("00");
                    lbc62.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc62.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb63":
                    grb63.Text = i.ToString("00");
                    lbc63.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc63.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb64":
                    grb64.Text = i.ToString("00");
                    lbc64.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc64.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb65":
                    grb65.Text = i.ToString("00");
                    lbc65.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc65.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb66":
                    grb66.Text = i.ToString("00");
                    lbc66.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc66.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb67":
                    grb67.Text = i.ToString("00");
                    lbc67.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc67.Appearance.BackColor = Color.Khaki;
                    break;
                case "grb68":
                    grb68.Text = i.ToString("00");
                    lbc68.Text = text(ngay);
                    if (ngay == DateTime.Now.ToShortDateString())
                        lbc68.Appearance.BackColor = Color.Khaki;
                    break;
                default:
                    break;
                #endregion

            }
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                reset();                
                for (int i = 1; i <= DateTime.DaysInMonth(Convert.ToInt16(cboNam.Text), Convert.ToInt16(cboThang.Text)); i++)
                {
                    string ngay = i.ToString("00") + "/" + cboThang.Text + "/" + cboNam.Text;
                    string x = "grb" + tuanthu(ngay) + thu(ngay);
                    ganten(x, i,ngay);
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
                    string ngay = ten + "/" + cboThang.Text + "/" + cboNam.Text;
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

        private void grb12_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb12.Text, sender, e);
        }

        private void grb13_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb13.Text, sender, e);
        }

        private void grb14_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb14.Text, sender, e);
        }

        private void grb15_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb15.Text, sender, e);
        }

        private void grb16_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb16.Text, sender, e);
        }

        private void grb17_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb17.Text, sender, e);
        }

        private void grb18_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb18.Text, sender, e);
        }

        private void grb22_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb22.Text, sender, e);
        }

        private void grb23_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb23.Text, sender, e);
        }

        private void grb24_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb24.Text, sender, e);
        }

        private void grb25_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb25.Text, sender, e);
        }

        private void grb26_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb26.Text, sender, e);
        }

        private void grb27_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb27.Text, sender, e);
        }

        private void grb28_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb28.Text, sender, e);
        }

        private void grb32_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb32.Text, sender, e);
        }

        private void grb33_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb33.Text, sender, e);
        }

        private void grb34_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb34.Text, sender, e);
        }

        private void grb35_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb35.Text, sender, e);
        }

        private void grb36_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb36.Text, sender, e);
        }

        private void grb337_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb37.Text, sender, e);
        }

        private void grb38_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb38.Text, sender, e);
        }

        private void grb42_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb42.Text, sender, e);
        }

        private void grb43_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb43.Text, sender, e);
        }

        private void grb44_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb44.Text, sender, e);
        }

        private void grb45_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb45.Text, sender, e);
        }

        private void grb46_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb46.Text, sender, e);
        }

        private void grb47_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb47.Text, sender, e);
        }

        private void grb48_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb48.Text, sender, e);
        }

        private void grb52_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb52.Text, sender, e);
        }

        private void grb53_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb53.Text, sender, e);
        }

        private void grb54_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb54.Text, sender, e);
        }

        private void grb55_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb55.Text, sender, e);
        }

        private void grb56_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb56.Text, sender, e);
        }

        private void grb57_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb57.Text, sender, e);
        }

        private void grb58_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb58.Text, sender, e);
        }

        private void grb62_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb62.Text, sender, e);
        }

        private void grb63_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb63.Text, sender, e);
        }

        private void grb64_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb64.Text, sender, e);
        }

        private void grb65_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb65.Text, sender, e);
        }

        private void grb66_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb66.Text, sender, e);
        }

        private void grb67_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb67.Text, sender, e);
        }

        private void grb68_DoubleClick(object sender, EventArgs e)
        {
            doubleclick(grb68.Text, sender, e);
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
    }

}
