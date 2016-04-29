using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using KPBT.Modules;
using System.Threading;

namespace KPBT.Forms
{
    public partial class Nhapthutien : Office2007Form
    {
        public Nhapthutien()
        {
            InitializeComponent();
        }

        private void Nhapthutien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modules.DC1.iform = 1;
        }
    }
}
