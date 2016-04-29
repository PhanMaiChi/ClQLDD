using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using ConvertDB;
using System.Drawing;
namespace KPBT.Modules
{
    class Class1
    {
        public static string CvrtUni(string str)
        {
            var cvt = new FontConverter();
            Font f = cvt.ConvertFromString(str) as Font;
            string s = cvt.ConvertToString(f);
            string[] st = s.Split(',');
            System.Windows.Forms.MessageBox.Show(st[0].ToString());
            if (st[0].ToString() != "Times New Roman")
            {
                ConvertDB.ConvertFont convert = new ConvertDB.ConvertFont();
                convert.Convert(ref str, FontIndex.iTCV, FontIndex.iUNI);
            }
            return str;
        }
    }
}
