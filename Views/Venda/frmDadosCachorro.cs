using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EcommerceGoldenRetriever.MVC.Views.Venda
{
    public partial class frmDadosCachorro : Form
    {
        private CachorroModel Cachorro { get; set; }

        public frmDadosCachorro()
        {
            InitializeComponent();
        }

        public void CarregarDados(int idCachorro)
        {
            LimparDados();

            Cachorro = new CachorroBLL().ObterPeloId(idCachorro);

            lblIdCachorro.Text = Convert.ToString(Cachorro.IdCachorro);
            lblNome.Text += Cachorro.Nome;
            lblPorte.Text += Cachorro.Porte;
            lblNascimento.Text += Convert.ToString(Cachorro.DataNascimento);
            lblRaca.Text += Cachorro.Raca;
            lblSexo.Text += Cachorro.Sexo;
            lblPedigree.Text += Convert.ToString(Cachorro.Pedigree);

            ShowDialog();
        }

        private void LimparDados()
        {
            lblIdCachorro.Text = "-";
            lblNome.Text = "Nome: ";
            lblPorte.Text = "Porte: ";
            lblNascimento.Text = "Nascimento: ";
            lblRaca.Text = "Raça: ";
            lblSexo.Text = "Sexo: ";
            lblPedigree.Text = "Pedigree: ";
        }
    }
}
