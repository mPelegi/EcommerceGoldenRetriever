using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EcommerceGoldenRetriever.MVC.Views.Util
{
    public partial class frmLogger : Form
    {
        private static frmLogger Instance;

        private frmLogger()
        {
            InitializeComponent();
        }

        public static frmLogger GetInstance()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new frmLogger();
            }

            return Instance;
        }

        public void Popup(string log)
        {
            rtxtbLogs.Text = Convert.ToString(log);
            ShowDialog();
        }
    }
}
