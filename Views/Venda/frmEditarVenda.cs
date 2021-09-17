using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.BLL.Pessoa;
using EcommerceGoldenRetriever.MVC.BLL.Venda;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using EcommerceGoldenRetriever.MVC.Views.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EcommerceGoldenRetriever.MVC.Views.Venda
{
    public partial class frmEditarVenda : Form
    {
        private List<VendaModel> Vendas { get; set; }
        private VendaBLL Bll;
        private frmAviso AvisoDialog = frmAviso.GetInstance();

        public frmEditarVenda()
        {
            Bll = new VendaBLL();
            Vendas = Bll.ObterTodos();
            InitializeComponent();
        }

        public void CarregarDados(VendaModel venda)
        {
            AtualizarComboBox();

            lblIdVenda.Text = Convert.ToString(venda.IdVenda);

            txtbDataCompra.Text = venda.DataCompra;
            txtbDataReserva.Text = venda.DataReserva;
            txtbValor.Text = Convert.ToString(venda.Valor);
            txtbNotaFiscal.Text = venda.NotaFiscal;

            cmbbCachorro.SelectedValue = venda.IdCachorro;
            cmbbComprador.SelectedValue = venda.IdComprador;
            cmbbStatus.SelectedItem = venda.Status;

            ShowDialog();
        }

        private void AtualizarComboBox()
        {
            List<CachorroModel> cachorros = new CachorroBLL().ObterTodos();
            List<CompradorModel> compradores = new CompradorBLL().ObterTodos();

            cmbbCachorro.DisplayMember = "Nome";
            cmbbCachorro.ValueMember = "IdCachorro";
            cmbbCachorro.DataSource = cachorros;

            cmbbComprador.DisplayMember = "Nome";
            cmbbComprador.ValueMember = "IdComprador";
            cmbbComprador.DataSource = compradores;

            cmbbStatus.DataSource = new string[] { "Reservado", "Finalizado" };
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                VendaModel venda = new VendaModel
                {
                    IdVenda = Convert.ToInt32(lblIdVenda.Text),
                    IdCachorro = Convert.ToInt32(cmbbCachorro.SelectedValue),
                    IdComprador = Convert.ToInt32(cmbbComprador.SelectedValue),
                    DataCompra = txtbDataCompra.Text,
                    DataReserva = txtbDataReserva.Text,
                    Status = Convert.ToString(cmbbStatus.SelectedItem),
                    Valor = Convert.ToDecimal(txtbValor.Text),
                    NotaFiscal = txtbNotaFiscal.Text
                };
                venda.Cachorro = Vendas.Find(x => x.Cachorro.IdCachorro == venda.IdCachorro).Cachorro;

                Bll.Atualizar(venda);

                Close();
            }
            catch (Exception ex)
            {
                AvisoDialog.Popup("Erro ao atualizar cadastro cachorro: \n" + ex.Message);
            }
        }
    }
}
