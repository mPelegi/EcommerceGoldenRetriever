using EcommerceGoldenRetriever.MVC.Views.Cachorro;
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
    }
}
