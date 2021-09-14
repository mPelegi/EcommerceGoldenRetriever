using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.BLL.Pessoa;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EcommerceGoldenRetriever.MVC.Views.Cachorro
{
    public partial class frmCachorro : Form
    {
        private List<CachorroModel> Cachorros { get; set; }
        private CachorroBLL Bll;

        public frmCachorro()
        {
            Bll = new CachorroBLL();
            InitializeComponent();
            AtualizarDataGridView();
            PopularComboBox();
        }

        private void AtualizarDataGridView()
        {
            dgvCachorros.Rows.Clear();
            Cachorros = Bll.ObterTodos();

            foreach (CachorroModel c in Cachorros)
            {
                string reservado = (bool)c.Reservado ? "Sim" : "Não";

                dgvCachorros.Rows.Add(c.IdCachorro, c.Nome, c.Porte, c.DataNascimento, c.Raca, c.Sexo, c.Pedigree, "Matriz", "Padreador", reservado, "Dono", "Comprador");
            }
        }

        private void PopularComboBox()
        {
            List<DonoModel> donos = new DonoBLL().ObterTodos();
            List<CompradorModel> compradores = new CompradorBLL().ObterTodos();

            cmbbDono.DisplayMember = "Nome";
            cmbbDono.ValueMember = "IdDono";
            cmbbDono.DataSource = donos;

            cmbbComprador.DisplayMember = "Nome";
            cmbbComprador.ValueMember = "IdComprador";
            cmbbComprador.DataSource = compradores;

            cmbbMatriz.DisplayMember = "Nome";
            cmbbMatriz.ValueMember = "IdCachorro";
            cmbbMatriz.DataSource = Cachorros.FindAll(x => x.Sexo == "Fêmea" || x.IdCachorro == 0).ToList();

            cmbbPadreador.DisplayMember = "Nome";
            cmbbPadreador.ValueMember = "IdCachorro";
            cmbbPadreador.DataSource = Cachorros.FindAll(x => x.Sexo == "Macho" || x.IdCachorro == 0).ToList();

            cmbbRaca.DataSource = new string[] { "Golden Retriever" };

            cmbbSexo.DataSource = new string[] { "Fêmea", "Macho" };

            cmbbReservado.DataSource = new string[] { "Não", "Sim" };

            cmbbPorte.DataSource = new string[] { "Pequeno", "Médio", "Grande" };
        }

        private void dgvCachorros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex >= 0) && (e.RowIndex >= 0))
            {
                frmPais pais = new frmPais();
                frmPessoa pessoa = new frmPessoa();

                switch (dgvCachorros.Columns[e.ColumnIndex].Name)
                {
                    case "colMatriz":
                        pais.CarregarDados(Cachorros[e.RowIndex].IdMatriz);
                        break;

                    case "colPadreador":
                        pais.CarregarDados(Cachorros[e.RowIndex].IdPadreador);
                        break;

                    case "colDono":
                        pessoa.CarregarDadosDono(Cachorros[e.RowIndex].IdDono);
                        break;

                    case "colComprador":
                        pessoa.CarregarDadosComprador(Cachorros[e.RowIndex].IdComprador);
                        break;

                    case "colCarteiras":
                        
                        break;

                    case "colEditar":
                        //TODO
                        Bll.Atualizar(Cachorros[e.RowIndex]);
                        AtualizarDataGridView();
                        break;

                    case "colDeletar":
                        Bll.Deletar(Cachorros[e.RowIndex].IdCachorro);
                        AtualizarDataGridView();
                        break;

                    default:
                        break;
                }
            }
        }

        private void dgvCachorros_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int w = 0;
            int h = 0;
            int x = 0;
            int y = 0;

            switch (dgvCachorros.Columns[e.ColumnIndex].Name)
            {
                case "colDeletar":
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

                case "colCarteiras":
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    Bitmap carteiras = Properties.Resources.document;

                    w = carteiras.Width;
                    h = carteiras.Height;
                    x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(carteiras, new Rectangle(x, y, w, h));
                    e.Handled = true;
                    break;

                default:
                    break;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CachorroModel cachorro = new CachorroModel
            {
                Nome = txtbNome.Text,
                Porte = Convert.ToString(cmbbPorte.SelectedItem),
                DataNascimento = txtbNascimento.Text,
                Raca = Convert.ToString(cmbbRaca.SelectedItem),
                Sexo = Convert.ToString(cmbbSexo.SelectedItem),
                Pedigree = Convert.ToInt32(txtbPedigree.Text),
                IdMatriz = Convert.ToInt32(cmbbMatriz.SelectedValue),
                IdPadreador = Convert.ToInt32(cmbbPadreador.SelectedValue),
                Reservado = cmbbReservado.SelectedValue == "Sim" ? true : false,
                IdDono = Convert.ToInt32(cmbbDono.SelectedValue),
                IdComprador = Convert.ToInt32(cmbbComprador.SelectedValue)
            };

            Bll.Inserir(cachorro);

            AtualizarDataGridView();
        }
    }
}
