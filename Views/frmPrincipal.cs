using EcommerceGoldenRetriever.MVC.Helpers;
using EcommerceGoldenRetriever.MVC.Views.Cachorro;
using EcommerceGoldenRetriever.MVC.Views.Util;
using EcommerceGoldenRetriever.MVC.Views.Venda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceGoldenRetriever.MVC
{
    public partial class frmPrincipal : Form
    {
        private LoggerHelper LoggerHelper = LoggerHelper.GetInstance();
        private frmLogger LoggerDialog = frmLogger.GetInstance();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void CreateChildren(Form formulario)
        {
            if (!formulario.IsDisposed)
            {
                formulario.Show();
            }
        }

        private void btnCachorros_Click(object sender, EventArgs e)
        {
            CreateChildren(new frmCachorro());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            CreateChildren(new frmVenda());
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            LoggerDialog.Popup(Convert.ToString(LoggerHelper.Logs));
        }
    }
}
