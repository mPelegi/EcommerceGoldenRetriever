using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EcommerceGoldenRetriever.MVC.Views.Util
{
    public partial class frmAviso : Form
    {
        private static frmAviso Instance;

        private frmAviso()
        {
            InitializeComponent();
        }

        public static frmAviso GetInstance()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new frmAviso();
            }

            return Instance;
        }

        public void Popup(string aviso)
        {
            rtxtbDetalhes.Text = aviso;
            ShowDialog();
        }
    }
}
