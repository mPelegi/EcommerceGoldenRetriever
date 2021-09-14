using EcommerceGoldenRetriever.MVC.BLL.Pessoa;
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
    public partial class frmPessoa : Form
    {
        private CompradorModel Comprador { get; set; }
        private DonoModel Dono { get; set; }

        public frmPessoa()
        {
            InitializeComponent();
        }

        public void CarregarDadosDono(int idDono)
        {

            Dono = new DonoBLL().ObterPeloId(idDono);


            lblPessoa.Text = "Dono";
            lblId.Text += Convert.ToString(Dono.IdDono);
            lblNome.Text += Dono.Nome;
            lblDocumento.Text += Dono.Documento;
            lblTelefone.Text += Dono.Telefone;
            lblNascimento.Text += Convert.ToString(Dono.DataNascimento);
            lblEndereco.Text += Dono.Endereco;

            ShowDialog();
        }

        public void CarregarDadosComprador(int idComprador)
        {

            Comprador = new CompradorBLL().ObterPeloId(idComprador);

            lblPessoa.Text = "Comprador";
            lblId.Text += Convert.ToString(Comprador.IdComprador);
            lblNome.Text += Comprador.Nome;
            lblDocumento.Text += Comprador.Documento;
            lblTelefone.Text += Comprador.Telefone;
            lblNascimento.Text += Convert.ToString(Comprador.DataNascimento);
            lblEndereco.Text += Comprador.Endereco;

            ShowDialog();
        }
    }
}
