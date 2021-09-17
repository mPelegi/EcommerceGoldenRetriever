using EcommerceGoldenRetriever.MVC.BLL.Cachorro;
using EcommerceGoldenRetriever.MVC.BLL.Pessoa;
using EcommerceGoldenRetriever.MVC.Models.Entidade;
using EcommerceGoldenRetriever.MVC.Views.Util;
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
    public partial class frmEditarCachorro : Form
    {
        private List<CachorroModel> Cachorros { get; set; }
        private CachorroBLL Bll;
        private frmAviso AvisoDialog = frmAviso.GetInstance();

        public frmEditarCachorro()
        {
            Bll = new CachorroBLL();
            Cachorros = Bll.ObterTodos();
            InitializeComponent();
        }

        public void CarregarDados(CachorroModel cachorro)
        {
            AtualizarComboBox();

            lblIdCachorro.Text = Convert.ToString(cachorro.IdCachorro);

            txtbNome.Text = cachorro.Nome;
            txtbNascimento.Text = cachorro.DataNascimento;
            txtbPedigree.Text = Convert.ToString(cachorro.Pedigree);

            cmbbCriador.SelectedValue = cachorro.IdCriador;
            cmbbComprador.SelectedValue = cachorro.IdComprador;
            cmbbMatriz.SelectedValue = cachorro.IdMatriz;
            cmbbPadreador.SelectedValue = cachorro.IdPadreador;
            cmbbRaca.SelectedItem = cachorro.Raca;
            cmbbSexo.SelectedItem = cachorro.Sexo;
            cmbbReservado.SelectedItem = (bool) cachorro.Reservado ? "Sim" : "Não";
            cmbbPorte.SelectedItem = cachorro.Porte;

            ShowDialog();
        }

        private void AtualizarComboBox()
        {
            List<CriadorModel> donos = new CriadorBLL().ObterTodos();
            List<CompradorModel> compradores = new CompradorBLL().ObterTodos();

            cmbbCriador.DisplayMember = "Nome";
            cmbbCriador.ValueMember = "IdCriador";
            cmbbCriador.DataSource = donos;

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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try 
            {
                CachorroModel cachorroAtualizado = new CachorroModel
                {
                    IdCachorro = Convert.ToInt32(lblIdCachorro.Text),
                    Nome = txtbNome.Text,
                    Porte = Convert.ToString(cmbbPorte.SelectedItem),
                    DataNascimento = txtbNascimento.Text,
                    Raca = Convert.ToString(cmbbRaca.SelectedItem),
                    Sexo = Convert.ToString(cmbbSexo.SelectedItem),
                    Pedigree = Convert.ToInt32(txtbPedigree.Text),
                    IdMatriz = Convert.ToInt32(cmbbMatriz.SelectedValue),
                    IdPadreador = Convert.ToInt32(cmbbPadreador.SelectedValue),
                    Reservado = cmbbReservado.SelectedValue == "Sim" ? true : false,
                    IdCriador = Convert.ToInt32(cmbbCriador.SelectedValue),
                    IdComprador = Convert.ToInt32(cmbbComprador.SelectedValue)
                };

                Bll.Atualizar(cachorroAtualizado);

                Close();
            }
            catch (Exception ex)
            {
                AvisoDialog.Popup("Erro ao atualizar cadastro cachorro: \n" + ex.Message);
            }
        }
    }
}
