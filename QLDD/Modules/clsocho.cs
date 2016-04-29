using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace KPBT.Modules
{
    class clsocho
    {
        static public void appdc(string ngaythang)
        {
            string sql = "insert into TblDC (TEN1,TEN2,TEN3,SL1,SL2,SL3) " +
                "Select nhxu.chokho,nhxu.tentp,nhxu.donvitinh,nhxu.slnh,nhxu.dongia,nhxu.dongia* nhxu.slnh as TT" +
                " From nhxu inner join nxct on nhxu.idnxct = nxct.idnxct" +
                " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            Connect.ThaoTac(sql);
        }
        static public void appdcphieu(string ngaythang)
        {
            string sql = "insert into TblDC (TEN1,TEN2,TEN3,SL1,SL2,SL3) " +
                "Select nhxu.chokho,nhxu.tentp,nhxu.donvitinh,nhxu.slnh,nhxu.dongia,nhxu.dongia* nhxu.slnh as TT" +
                " From nhxu inner join nxct on nhxu.idnxct = nxct.idnxct" +
                " where nhxu.slnh > 0 and nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            Connect.ThaoTac(sql);
        }
        static public void updc(string ngaythang)
        {
            OleDbDataReader dr = Connect.TruyVandr("select * From TblDC");
            while (dr.Read())
            {
                string sqlup = "Update TblDC set SL4=@SL4 where ID = " + Convert.ToInt64(dr["ID"].ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sqlup;
                cmd.Parameters.Add("@SL4", OleDbType.Double).Value = tongtien(dr["TEN1"].ToString(), ngaythang);
                Connect.LuuDL(cmd);
            }
            dr.Close();
        }
        static public double xuatanS(string ngaythang)
        {
            double kq = 0;
            string sql = "Select Sum([BS]) as An From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        static public double xuatanT(string ngaythang)
        {
            double kq = 0;
            string sql = "Select Sum([BT]) as An From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        static public double xuatanC(string ngaythang)
        {
            double kq = 0;
            string sql = "Select Sum([BC]) as An From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["An"].ToString());
            }
            dr.Close();
            return kq;
        }
        static public double mucansang(string ngaythang)
        {
            double kq = 0;
            string sql = "Select distinct MASANG From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = classdc.dungchung.kieudouble(dr["MASANG"].ToString());
            }
            dr.Close();
            return kq;
        }
        static public double mucantrua(string ngaythang)
        {
            double kq = 0;
            string sql = "Select distinct MA From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = classdc.dungchung.kieudouble(dr["MA"].ToString());
            }
            dr.Close();
            return kq;
        }
        static public double mucantoi(string ngaythang)
        {
            double kq = 0;
            string sql = "Select distinct MATOI From baoan" +
            " where ntan = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = classdc.dungchung.kieudouble(dr["MATOI"].ToString());
            }
            dr.Close();
            return kq;
        }
        static public double tienchi(string chokho, string ngaythang)
        {
            double kq = 0;
            string sql = "Select ttxu From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct" +
            " where nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["ttxu"].ToString());
            }
            dr.Close();
            return kq;
        }
        static public double tongtien(string chokho, string ngaythang)
        {
            double kq = 0;
            string sql = "Select nhxu.dongia* nhxu.slnh as TT From  nhxu inner join nxct on nhxu.idnxct = nxct.idnxct" +
            " where nhxu.chokho = '" + chokho + "' and nxct.ntnx = #" + classdc.dungchung.thaydoi(ngaythang) + "#";
            OleDbDataReader dr = Connect.TruyVandr(sql);
            while (dr.Read())
            {
                kq = kq + classdc.dungchung.kieudouble(dr["TT"].ToString());
            }
            dr.Close();
            return kq;
        }
    }
}
