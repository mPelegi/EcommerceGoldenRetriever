using EcommerceGoldenRetriever.MVC.BLL.Pessoa;
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
    public partial class frmDadosComprador : Form
    {
        private CompradorModel Comprador { get; set; }

        public frmDadosComprador()
        {
            InitializeComponent();
        }

        public void CarregarDados(int idComprador)
        {
            Comprador = new CompradorBLL().ObterPeloId(idComprador);

            lblIdComprador.Text = Convert.ToString(Comprador.IdComprador);
            lblNome.Text += Comprador.Nome;
            lblDocumento.Text += Comprador.Documento;
            lblTelefone.Text += Comprador.Telefone;
            lblNascimento.Text += Convert.ToString(Comprador.DataNascimento);
            lblEndereco.Text += Comprador.Endereco;

            ShowDialog();
        }
    }
}
