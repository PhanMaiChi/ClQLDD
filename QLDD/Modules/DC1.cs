using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KPBT.Modules;

namespace KPBT.Modules
{
    class DC1
    {
        public static string ngay = "", nhomtuoi = "", tenhs = "";
        public static string hieut = "";
        public static int iform = 1;
        public static string hieup = "";
        public static string namchuyen = Settings1.Default.namchuyen.ToString();
        public static string namdllv = Settings1.Default.namlv.ToString();
        public static double ttkk = 0;
        public static OleDbConnection Ketnoi_Database(string namdl)
        {
            string strconn = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = '" + namdl + "'; Jet OLEDB:Database Password=cs080313;";
            OleDbConnection cnn = new OleDbConnection(strconn);
            cnn.Open();
            return cnn;
        }

        public static OleDbConnection Ketnoi_Databasechuyen(string namdl)
        {
            string strconnch = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = '" + namdl + "'; Jet OLEDB:Database Password=cs080313;";
            //string strconn = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = '" + namdl + "'";
            OleDbConnection cnnch = new OleDbConnection(strconnch);
            cnnch.Open();
            return cnnch;
        }     
       
        public static string bodau(string accented)
        {
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = accented.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public static string Func(String Strs)
        {
            Char[] chars = Strs.ToCharArray();
            string str = "";
            foreach (char c in chars)
            {
                //if (Convert.ToInt32(c) >= 65 && Convert.ToInt32(c) <= 90)
                //{
                //    str += c.ToString().ToLower();
                //}
                //else if (Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122)
                //{
                //    //str += c.ToString().ToUpper();
                //    str += c.ToString().ToLower();
                //}
                str += c.ToString().ToLower();
            }
            return str;
        }       
        public static void taoTG(DataTable dt)
        {
            DataColumn addcolumn = new DataColumn("IDSOCAI", Type.GetType("System.Int64"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("NTCT", Type.GetType("System.DateTime"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN1", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN2", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN3", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN4", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN5", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN6", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN7", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN8", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN9", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN10", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN11", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN12", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN13", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN14", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN15", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN16", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN17", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN18", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN19", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("TEN20", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL1", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL2", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL3", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL4", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL5", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL6", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL7", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL8", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL9", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL10", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("SL11", Type.GetType("System.Double"));
            dt.Columns.Add(addcolumn);
            addcolumn = new DataColumn("GCCT", Type.GetType("System.String"));
            dt.Columns.Add(addcolumn);
        }
        public static void delSOCAI()
        {
            string sql = "Delete * From tbldc";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = sql;
            Connect.LuuDL(cmd);
            //string sqldel = "Drop Table SOCAI";
            //OleDbCommand cmddel = new OleDbCommand(sqldel, cn);
            //cmddel.ExecuteNonQuery();
            //string sqlcr = "Create table SOCAI(ID AUTOINCREMENT Primary Key, NTCT Datetime, NTGS Datetime, TEN1 Varchar(250), TEN2 Varchar(250),";
            //sqlcr = sqlcr + "TEN3 Varchar(250),TEN4 Varchar(250),TEN5 Varchar(250),TEN6 Varchar(250),TEN7 Varchar(250),TEN8 Varchar(250),TEN9 Varchar(250),TEN10 Varchar(250),";
            //sqlcr = sqlcr + "TEN11 Varchar(250),TEN12 Varchar(250),TEN13 Varchar(250),TEN14 Varchar(250),TEN15 Varchar(250),TEN16 Varchar(250),TEN17 Varchar(250),TEN18 Varchar(250),TEN19 Varchar(250),TEN20 Varchar(250),";
            //sqlcr = sqlcr + "SL1 double default 0,SL2 double default 0,SL3 double default 0,SL4 double default 0,SL5 double default 0,SL6 double default 0,SL7 double default 0,SL8 double default 0,SL9 double default 0,SL10 double default 0,SL11 double default 0,SL12 double default 0,";
            //sqlcr = sqlcr + "SL13 double default 0,SL14 double default 0,SL15 double default 0,SL16 double default 0,SL17 double default 0,SL18 double default 0,SL19 double default 0,SL20 double default 0)";
            //OleDbCommand cmdcr = new OleDbCommand(sqlcr, cn);
            //cmdcr.ExecuteNonQuery();
        }
        public static void xoadc()
        {
            string sqldel = "Drop Table tbldc";
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = sqldel;
            Connect.LuuDL(cmd);
            string sqlcr = "Create table tbldc(ID AUTOINCREMENT Primary Key, ngay1 Datetime, ngay2 Datetime, TEN1 Varchar(250), TEN2 Varchar(250),";
            sqlcr = sqlcr + "TEN3 Varchar(250),TEN4 Varchar(250),TEN5 Varchar(250),TEN6 Varchar(250),TEN7 Varchar(250),TEN8 Varchar(250),TEN9 Varchar(250),TEN10 Varchar(250),";
            sqlcr = sqlcr + "TEN11 Varchar(250),TEN12 Varchar(250),TEN13 Varchar(250),TEN14 Varchar(250),TEN15 Varchar(250),TEN16 Varchar(250),TEN17 Varchar(250),TEN18 Varchar(250),TEN19 Varchar(250),TEN20 Varchar(250),";
            sqlcr = sqlcr + "SL1 double default 0,SL2 double default 0,SL3 double default 0,SL4 double default 0,SL5 double default 0,SL6 double default 0,SL7 double default 0,SL8 double default 0,SL9 double default 0,SL10 double default 0,SL11 double default 0,SL12 double default 0,";
            sqlcr = sqlcr + "SL13 double default 0,SL14 double default 0,SL15 double default 0,SL16 double default 0,SL17 double default 0,SL18 double default 0,SL19 double default 0,SL20 double default 0)";
            OleDbCommand cmdcr = new OleDbCommand();
            cmdcr.CommandText = sqlcr;
            Connect.LuuDL(cmdcr);
        }
        public static string tendvdv(string ten)
        {
            string kq = "";
            int i = 0;
            if (ten != "")
            {
                i = ten.IndexOf("&");
                if (i > 0)
                    kq = ten.Substring(0, i) + "&" + ten.Substring(i);
                else
                    kq = ten;
            }
            return kq;
        }
        public static string sodd(Int32 so)
        {
            string kq = "";
            if (so < 10)
                kq = "000" + so.ToString();
            else if (so < 100)
                kq = "00" + so.ToString();
            else if (so < 1000)
                kq = "0" + so.ToString();
            else
                kq = so.ToString();
            return kq;
        }
        public static void TaoBQ(DataTable dt)
        {
            clsbqkpbt.banquyen.taobq(dt);
        }
        public static void capbanquyen(DataTable dt)
        {
            clsbqkpbt.banquyen.thongtinbanquyen(dt);            
        }
        public static string ngaythang(string ngay)
        {
            string[] str1 = ngay.Split('/');
            if (str1[2] == "")
                ngay = str1[0] + "/" + str1[1] + "/" + DateTime.Today.Year.ToString();
            System.Globalization.CultureInfo cultuere = new System.Globalization.CultureInfo("vi-VN");
            cultuere.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            DateTimePicker dtp = new DateTimePicker();
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "dd/MM/yyyy";
            dtp.Value = Convert.ToDateTime(ngay, cultuere);
            ngay = string.Format("{0:00}", dtp.Value.Day) + "/" + string.Format("{0:00}", dtp.Value.Month) + "/" + string.Format("{0:00}", dtp.Value.Year);
            return ngay;
        }
        public static string thu(string nt)
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
        public static int tuanthu(string nt)
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
        internal static string thaydoi(string ngaythaydoi)
        {
            string kq = "";
            string[] xl = ngaythaydoi.Split('/');
            try
            {
                if (Convert.ToDouble(xl[0]) <= 12)
                    kq = string.Format("{0: MM/dd/yyyy}", Convert.ToDateTime(ngaythaydoi));
                else
                    kq = string.Format("{0: dd/MM/yyyy}", Convert.ToDateTime(ngaythaydoi));
            }
            catch
            { }
            return kq;
        }        


    }
}
