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
    public partial class frmDadosPessoa : Form
    {
        private CompradorModel Comprador { get; set; }
        private CriadorModel Criador { get; set; }

        public frmDadosPessoa()
        {
            InitializeComponent();
        }

        public void CarregarDadosCriador(int idCriador)
        {

            Criador = new CriadorBLL().ObterPeloId(idCriador);


            lblPessoa.Text = "Criador";
            lblId.Text += Convert.ToString(Criador.IdCriador);
            lblNome.Text += Criador.Nome;
            lblDocumento.Text += Criador.Documento;
            lblTelefone.Text += Criador.Telefone;
            lblNascimento.Text += Convert.ToString(Criador.DataNascimento);
            lblEndereco.Text += Criador.Endereco;

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
