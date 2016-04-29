using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace KPBT.Modules
{
    class dcts
    {
       // public static string hieut = "";
        //public static string hieup = "";     
        public static int truyen = 0;
        
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
       
        public static double TinhToan(DataRow[] dr, string col)
        {
            double kq = 0;
            foreach (DataRow row in dr)
            {
                kq += classdc.dungchung.kieudouble(row[col].ToString());
            }
            return kq;
        }

        public static double TinhToan(DataTable dt, string col)
        {
            double kq = 0;
            foreach (DataRow row in dt.Rows)
            {
                kq += Convert.ToDouble(row[col].ToString());
            }
            return kq;
        }

        public static void taoTG(bool kieu, DataTable dt, params string[] col)
        {
            if (kieu)
                foreach (string str in col)
                {
                    //DataColumn addcolumn = new DataColumn(str);
                    if (str.Substring(0, 1) == "S")
                        dt.Columns.Add(str, Type.GetType("System.Double"));
                    else
                        dt.Columns.Add(str, Type.GetType("System.String"));
                }
            else
                foreach (string str in col)
                {
                    dt.Columns.Add(str, Type.GetType("System.String"));
                }
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

        public static bool KTChuoi(string gtKT, params string[] GT)
        {
            foreach (string str in GT)
            {
                if (str == gtKT)
                {
                    return false;
                }
            }
            return true;
        }

        public static string DoiNT(bool ChuHoa,DateTime dtpKQ)
        {
            if(ChuHoa)
                return "Ngày " + dtpKQ.Day.ToString("00") + " tháng " + dtpKQ.Month.ToString("00") + " năm " + dtpKQ.Year.ToString();
            else
                return "ngày " + dtpKQ.Day.ToString("00") + " tháng " + dtpKQ.Month.ToString("00") + " năm " + dtpKQ.Year.ToString();
        }

        public static string DoiNT(bool ChuHoa, string dtpKQ)
        {
            if (ChuHoa)
                return "Ngày " + Convert.ToDateTime(dtpKQ).Day.ToString("00") + " tháng " + Convert.ToDateTime(dtpKQ).Month.ToString("00") + " năm " + Convert.ToDateTime(dtpKQ).Year.ToString();
            else
                return "ngày " + Convert.ToDateTime(dtpKQ).Day.ToString("00") + " tháng " + Convert.ToDateTime(dtpKQ).Month.ToString("00") + " năm " + Convert.ToDateTime(dtpKQ).Year.ToString();
        }
        internal static string GetStr(object giatriTV)
        {
            string strKQ = "";
            if (giatriTV != null)
                strKQ = giatriTV.ToString();
            return strKQ;
        }

        internal static double GetDbl(object giatriTV)
        {
            double dblKQ = 0;
            if (giatriTV != null)
                dblKQ = classdc.dungchung.kieudouble(giatriTV.ToString());
            return dblKQ;
        }

        internal static string LayGT(DataRow[] rowKQ, string col)
        {
            string str = "";
            if (rowKQ.Length > 0)
            {
                str = rowKQ[0][col].ToString();
            }
            return str;
        }       
    }

    class DC2       //Đọc số tiền + chuẩn hóa số liệu
    {
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
        public static string xuly(string doituong)
        {
            try
            {
                string chuoicat = " ", tendt, xl, chuoighep, chuoikq;
                int vtdaucach;
                tendt = doituong.Trim();
                vtdaucach = 1;
                chuoikq = " ";
                for (int i = 0; i < 10000; i++)
                {
                    vtdaucach = tendt.IndexOf(" ");
                    if (vtdaucach < 0)
                    {
                        xl = tendt.Trim();
                    }
                    else
                    {
                        chuoicat = tendt.Substring(vtdaucach).Trim();
                        xl = tendt.Remove(vtdaucach);
                    }
                    if (xl.Length == 1)
                        chuoighep = xl.ToUpper();
                    else
                        chuoighep = xl.ToUpper().Remove(1) + xl.Substring(1);
                    chuoikq = chuoikq + " " + chuoighep.Trim();
                    tendt = chuoicat.Trim();
                    i = vtdaucach;
                    if (i < 0)
                        break;
                }
                chuoikq = chuoikq.Trim();
                return chuoikq.ToString();
            }
            catch
            {
                return "";
            }
        }

    }

    class DC3       //Các thông tin liên quan tới bản quyền
    {
        
    }

    class DC4       //Các hàm khác
    {

    }

    class Connect   //Kết nối + thao tác với CSDL
    {
        //public static string namdllv = TCXP.Settings1.Default.namlv.ToString();
        static OleDbConnection cnn;
        static OleDbCommand cmd;
        static OleDbDataReader dr;
        static OleDbDataAdapter ada;

        static Connect()
        {
            string strconn = "Provider = Microsoft.Jet.OLEDB.4.0; Data source = '" + KPBT.Settings1.Default.namlv.ToString() + "'; Jet OLEDB:Database Password=cs080313;";
            cnn = new OleDbConnection(strconn);
            cnn.Open();
        }
        static public void Reconnect()
        {
            if (cnn.State == System.Data.ConnectionState.Open)
                cnn.Dispose();
            cnn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data source = '" + KPBT.Settings1.Default.namlv.ToString() + "'; Jet OLEDB:Database Password=cs080313;");
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        static public DataTable TruyVandt(string sql)
        {
            DataTable dt = new DataTable();
            cmd = new OleDbCommand(sql, cnn);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        static public OleDbDataReader TruyVandr(string sql)
        {
            cmd = new OleDbCommand(sql, cnn);
            dr = cmd.ExecuteReader();
            return dr;
        }

        static public void ThaoTac(string sql)
        {
            DataTable dt = new DataTable();
            cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
        }

        static public int KiemTra(string sql)
        {
            DataTable dt = new DataTable();
            cmd = new OleDbCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            return dt.Rows.Count;
        }

        static public int LuuDL(OleDbCommand cmdtt)
        {            
            cmdtt.Connection = cnn;
            return cmdtt.ExecuteNonQuery();
        }

        static public DataTable Loadgrc(string sql)
        {
            DataTable dtKQ =TruyVandt(sql);
            dtKQ.Columns.Add("STT");
            dtKQ.Columns.Add("TT");
            if (dtKQ.Rows.Count > 0)
            {
                for (int i = 0; i < dtKQ.Rows.Count; i++)
                {
                    dtKQ.Rows[i]["STT"] = i + 1;
                    dtKQ.Rows[i]["TT"] = 0;
                }
            }
            return dtKQ;
        }

        static public void LoadDL(DevExpress.XtraEditors.LookUpEdit luKQ, string value, string display, string sql)
        {
            DataTable dt = new DataTable();
            cmd = new OleDbCommand(sql, cnn);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            luKQ.Properties.DataSource = dt;
            luKQ.Properties.ValueMember = value;
            luKQ.Properties.DisplayMember = display;
        }
        static public void LoadDL(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luKQ, string value, string display, string sql)

        {
            DataTable dt = new DataTable();
            cmd = new OleDbCommand(sql, cnn);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            luKQ.Properties.DataSource = dt;
            luKQ.Properties.ValueMember = value;
            luKQ.Properties.DisplayMember = display;
        }

        static public void LoadDL(DevExpress.XtraEditors.LookUpEdit luKQ, string value, string display, DataTable dt)
        {
            luKQ.Properties.DataSource = dt;
            luKQ.Properties.ValueMember = value;
            luKQ.Properties.DisplayMember = display;
        }

        static public void LoadDL(DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luKQ, string value, string display, DataTable dt)
        {
            luKQ.Properties.DataSource = dt;
            luKQ.Properties.ValueMember = value;
            luKQ.Properties.DisplayMember = display;
        }
        
        static public DataSet Loadds(DataSet dsKQ, string sql, string tblName)
        {
            cmd = new OleDbCommand(sql, cnn);
            ada = new OleDbDataAdapter(cmd);           
            ada.Fill(dsKQ, tblName);
            return dsKQ;
        }

        static internal string TaoMSHS()
        {
            DataTable dtMa = TruyVandt("Select mshs From hocsinh order by idhs");
            string strKQ = (dtMa.Rows.Count > 0 ? dtMa.Rows[dtMa.Rows.Count-1]["mshs"].ToString() : "");
            int Max = 0;
            foreach (DataRow row in dtMa.Select("mshs Like '" + strKQ + "%'"))
            {
                string[] sMa = row["mshs"].ToString().Split('.');
                Max = (int.Parse(sMa[sMa.Length - 1]) > Max ? int.Parse(sMa[sMa.Length - 1]) : Max);
            }
            strKQ = "hs." + (Max + 1).ToString("0000");
            return strKQ;
        }
        static internal string TaoMSTScc(string strMa, DataTable dtKQ)
        {
            DataTable dtMa = TruyVandt("Select MSDM From DMTS Where TENTS='" + strMa + "' and MSDM Like 'C%'");
            string strKQ = (dtMa.Rows.Count > 0 ? dtMa.Rows[0]["MSDM"].ToString() : "");
            int Max = 0;
            foreach (DataRow row in dtKQ.Select("MSTS Like '" + strKQ + "%'"))
            {
                string[] sMa = row["MSTS"].ToString().Split('.');
                Max = (int.Parse(sMa[sMa.Length - 1]) > Max ? int.Parse(sMa[sMa.Length - 1]) : Max);
            }
            strKQ += "." + (Max + 1).ToString("0000");
            return strKQ;
        }
        static internal void LoadCBB(DevExpress.XtraEditors.ComboBoxEdit cbKQ, string col, string sql)
        {
            DataTable dt = new DataTable();
            cmd = new OleDbCommand(sql, cnn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
                if (dcts.GetStr(dr[col]).Length > 0)
                    cbKQ.Properties.Items.Add(dcts.GetStr(dr[col]));
            dr.Close();
        }       

        static internal void LoadCBB(DevExpress.XtraEditors.ComboBoxEdit cbKQ, string col, DataTable dtKQ)
        {
            foreach (DataRow row in dtKQ.Rows)
                if (dcts.GetStr(row[col]).Length > 0)
                    cbKQ.Properties.Items.Add(dcts.GetStr(row[col]));
        }
        static internal string TaoMa(string strMa, string sql, string col)
        {
            DataTable dtKQ = Connect.TruyVandt(sql);
            string strID = "0", strSH = "";
            strSH = dtKQ.Rows[0][col].ToString();
            foreach (char c in strSH)
            {
                if (Char.IsDigit(c))
                    strID += c;
            }
            return strMa + (double.Parse(strID) + 1).ToString("0000");
        }
        static internal string TaoMa(string _Ma, DataTable dtKQ, string col)
        {
            int Max = 0;
            string sID = "0", strKQ = "";
            foreach (DataRow row in dtKQ.Rows)
            {
                sID = "0";
                string sMa = row[col].ToString();
                foreach (char c in sMa)
                    if (Char.IsDigit(c))
                        sID += c;
                Max = (int.Parse(sID) > Max ? int.Parse(sID) : Max);
            }
            strKQ = _Ma + (Max + 1).ToString("0000");
            return strKQ;
        }
        internal static string GetStr(object giatriTV)
        {
            string strKQ = "";
            if (giatriTV != null)
                strKQ = giatriTV.ToString();
            return strKQ;
        }
        internal static double GetDou(object giatriTV)
        {
            double douKQ = 0;
            if (giatriTV != null)
                douKQ = classdc.dungchung.kieudouble(giatriTV.ToString());
            return douKQ;
        }
        internal static string LayGT(string sql, string col)
        {
            string str = "";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                str = dr[col].ToString();
            }
            dr.Close();
            return str;
        }

        static public double doubltt(OleDbDataReader dr, string col)
        {
            double kq = 0;
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            while (dr.Read())
            {
                kq += classdc.dungchung.kieudouble(dr[col].ToString());
            }
            dr.Close();
            return kq;
        }
    }
}
