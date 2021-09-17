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
    public partial class frmVenda : Form
    {
        private List<VendaModel> Vendas { get; set; }
        private VendaBLL Bll;
        private frmAviso AvisoDialog = frmAviso.GetInstance();

        public frmVenda()
        {
            Bll = new VendaBLL();
            InitializeComponent();
            AtualizarDataGridView();
            AtualizarComboBox();
        }

        private void AtualizarDataGridView()
        {
            try
            {
                dgvVendas.Rows.Clear();
                Vendas = Bll.ObterTodos();

                foreach (VendaModel v in Vendas)
                {
                    dgvVendas.Rows.Add(v.IdVenda, v.Cachorro.Nome, v.Comprador.Nome, v.DataCompra, v.DataReserva, v.Status, v.Valor, v.NotaFiscal, null, null);
                }
            }
            catch (Exception ex)
            {
                AvisoDialog.Popup("Erro ao atualizar DataGridView: \n" + ex.Message);
            }        
        }

        private void LimparCampos()
        {
            txtbDataCompra.Text = "";
            txtbDataReserva.Text = "";
            txtbNotaFiscal.Text = "";
            txtbValor.Text = "";
        }

        private void AtualizarComboBox()
        {
            List<CachorroModel> cachorros = new CachorroBLL().ObterPeloExemplo(new CachorroModel { Reservado = false });
            List<CompradorModel> compradores = new CompradorBLL().ObterTodos();

            cachorros.RemoveAll(x => x.IdCachorro == 0);

            cmbbCachorrosDisponiveis.DisplayMember = "Nome";
            cmbbCachorrosDisponiveis.ValueMember = "IdCachorro";
            cmbbCachorrosDisponiveis.DataSource = cachorros;

            cmbbComprador.DisplayMember = "Nome";
            cmbbComprador.ValueMember = "IdComprador";
            cmbbComprador.DataSource = compradores;

            cmbbStatus.DataSource = new string[] { "Reservado", "Finalizado" };
        }

        private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex >= 0) && (e.RowIndex >= 0))
            {
                frmDadosCachorro cachorro;
                frmDadosComprador comprador;
                frmEditarVenda editar;

                try
                {
                    switch (dgvVendas.Columns[e.ColumnIndex].Name)
                    {
                        case "colCachorro":
                            cachorro = new frmDadosCachorro();
                            cachorro.CarregarDados(Vendas[e.RowIndex].IdCachorro);
                            break;

                        case "colComprador":
                            comprador = new frmDadosComprador();
                            comprador.CarregarDados(Vendas[e.RowIndex].IdComprador);
                            break;

                        case "colEditar":
                            editar = new frmEditarVenda();
                            editar.CarregarDados(Vendas[e.RowIndex]);
                            AtualizarDataGridView();
                            AtualizarComboBox();
                            break;

                        case "colCancelar":
                            if (Vendas[e.RowIndex].Status != "Cancelado")
                            {
                                Bll.Cancelar(Vendas[e.RowIndex]);
                                AtualizarDataGridView();
                            }
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    AvisoDialog.Popup("Erro ao executar ação: \n" + ex.Message);
                }
            }
        }

        private void dgvVendas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int w = 0;
            int h = 0;
            int x = 0;
            int y = 0;

            try
            {
                switch (dgvVendas.Columns[e.ColumnIndex].Name)
                {
                    case "colCancelar":
                        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                        Bitmap deletar = Properties.Resources.delete;

                        w = deletar.Width;
                        h = deletar.Height;
                        x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                        y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2; ;

                        e.Graphics.DrawImage(deletar, new Rectangle(x, y, w, h));
                        e.Handled = true;
                        break;

                    case "colEditar":
                        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                        Bitmap editar = Properties.Resources.edit;

                        w = editar.Width;
                        h = editar.Height;
                        x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                        y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                        e.Graphics.DrawImage(editar, new Rectangle(x, y, w, h));
                        e.Handled = true;
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                AvisoDialog.Popup("Erro ao inserir imagens dinamicamente nos botões do DataGridView: \n" + ex.Message);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                VendaModel venda = new VendaModel
                {
                    IdCachorro = Convert.ToInt32(cmbbCachorrosDisponiveis.SelectedValue),
                    IdComprador = Convert.ToInt32(cmbbComprador.SelectedValue),
                    DataCompra = txtbDataCompra.Text,
                    DataReserva = txtbDataReserva.Text,
                    Status = Convert.ToString(cmbbStatus.SelectedItem),
                    Valor = Convert.ToDecimal(txtbValor.Text),
                    NotaFiscal = txtbNotaFiscal.Text
                };
                venda.Cachorro = Vendas.Find(x => x.Cachorro.IdCachorro == venda.IdCachorro).Cachorro;

                Bll.Inserir(venda);

                LimparCampos();
                AtualizarDataGridView();
                AtualizarComboBox();
            }
            catch (Exception ex)
            {
                AvisoDialog.Popup("Erro ao inserir nova venda : \n" + ex.Message);
            }
        }
    }
}
