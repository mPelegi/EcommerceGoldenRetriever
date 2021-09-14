using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EcommerceGoldenRetriever.MVC.Views.Cachorro
{
    public partial class frmPais : Form
    {
        private CachorroModel Cachorro { get; set; }

        public frmPais()
        {
            InitializeComponent();
        }

        public void CarregarDados(int idCachorro)
        {
            LimparDados();

            Cachorro = new CachorroBLL().ObterPeloId(idCachorro);
            
            if (Cachorro.IdMatriz > 0 && Cachorro.IdPadreador > 0)
            {
                lblPais.Text = Cachorro.Sexo == "Fêmea" ? "Matriz" : "Padreador";
            }
            else
            {
                lblPais.Text = "Externo";
            }
            lblId.Text += Convert.ToString(Cachorro.IdCachorro);
            lblNome.Text += Cachorro.Nome;
            lblPorte.Text += Cachorro.Porte;
            lblNascimento.Text += Convert.ToString(Cachorro.DataNascimento);
            lblRaca.Text += Cachorro.Raca;
            lblSexo.Text += Cachorro.Sexo;
            lblPedigree.Text+= Convert.ToString(Cachorro.Pedigree);

            ShowDialog();
        }

        public void LimparDados()
        {
            lblPais.Text = "-";
            lblId.Text = "Id: ";
            lblNome.Text = "Nome: ";
            lblPorte.Text = "Porte: ";
            lblNascimento.Text = "Nascimento: ";
            lblRaca.Text = "Raça: ";
            lblSexo.Text = "Sexo: ";
            lblPedigree.Text = "Pedigree: ";
        }
    }
}
