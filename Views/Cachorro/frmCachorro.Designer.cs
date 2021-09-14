
namespace EcommerceGoldenRetriever.MVC.Views.Cachorro
{
    partial class frmCachorro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCachorros = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbNascimento = new System.Windows.Forms.TextBox();
            this.txtbPedigree = new System.Windows.Forms.TextBox();
            this.cmbbPorte = new System.Windows.Forms.ComboBox();
            this.cmbbRaca = new System.Windows.Forms.ComboBox();
            this.cmbbSexo = new System.Windows.Forms.ComboBox();
            this.cmbbMatriz = new System.Windows.Forms.ComboBox();
            this.cmbbPadreador = new System.Windows.Forms.ComboBox();
            this.cmbbReservado = new System.Windows.Forms.ComboBox();
            this.cmbbDono = new System.Windows.Forms.ComboBox();
            this.cmbbComprador = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPorte = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPedigree = new System.Windows.Forms.Label();
            this.lblMatriz = new System.Windows.Forms.Label();
            this.lblPadreador = new System.Windows.Forms.Label();
            this.lblReservado = new System.Windows.Forms.Label();
            this.lblDono = new System.Windows.Forms.Label();
            this.lblComprador = new System.Windows.Forms.Label();
            this.colIdCachorro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPedigree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatriz = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colPadreador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colReservado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDono = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colComprador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCarteiras = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeletar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachorros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCachorros
            // 
            this.dgvCachorros.AllowUserToAddRows = false;
            this.dgvCachorros.AllowUserToDeleteRows = false;
            this.dgvCachorros.AllowUserToResizeRows = false;
            this.dgvCachorros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCachorros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdCachorro,
            this.colNome,
            this.colPorte,
            this.colNascimento,
            this.colRaca,
            this.colSexo,
            this.colPedigree,
            this.colMatriz,
            this.colPadreador,
            this.colReservado,
            this.colDono,
            this.colComprador,
            this.colCarteiras,
            this.colEditar,
            this.colDeletar});
            this.dgvCachorros.Location = new System.Drawing.Point(12, 161);
            this.dgvCachorros.Name = "dgvCachorros";
            this.dgvCachorros.RowHeadersVisible = false;
            this.dgvCachorros.RowTemplate.Height = 25;
            this.dgvCachorros.Size = new System.Drawing.Size(944, 386);
            this.dgvCachorros.TabIndex = 0;
            this.dgvCachorros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCachorros_CellClick);
            this.dgvCachorros.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvCachorros_CellPainting);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::EcommerceGoldenRetriever.MVC.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(712, 79);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(38, 75);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(13, 79);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(100, 23);
            this.txtbNome.TabIndex = 2;
            // 
            // txtbNascimento
            // 
            this.txtbNascimento.Location = new System.Drawing.Point(246, 79);
            this.txtbNascimento.Name = "txtbNascimento";
            this.txtbNascimento.Size = new System.Drawing.Size(100, 23);
            this.txtbNascimento.TabIndex = 4;
            // 
            // txtbPedigree
            // 
            this.txtbPedigree.Location = new System.Drawing.Point(606, 79);
            this.txtbPedigree.Name = "txtbPedigree";
            this.txtbPedigree.Size = new System.Drawing.Size(100, 23);
            this.txtbPedigree.TabIndex = 7;
            // 
            // cmbbPorte
            // 
            this.cmbbPorte.FormattingEnabled = true;
            this.cmbbPorte.Location = new System.Drawing.Point(119, 79);
            this.cmbbPorte.Name = "cmbbPorte";
            this.cmbbPorte.Size = new System.Drawing.Size(121, 23);
            this.cmbbPorte.TabIndex = 8;
            // 
            // cmbbRaca
            // 
            this.cmbbRaca.FormattingEnabled = true;
            this.cmbbRaca.Location = new System.Drawing.Point(352, 79);
            this.cmbbRaca.Name = "cmbbRaca";
            this.cmbbRaca.Size = new System.Drawing.Size(121, 23);
            this.cmbbRaca.TabIndex = 9;
            // 
            // cmbbSexo
            // 
            this.cmbbSexo.FormattingEnabled = true;
            this.cmbbSexo.Location = new System.Drawing.Point(479, 79);
            this.cmbbSexo.Name = "cmbbSexo";
            this.cmbbSexo.Size = new System.Drawing.Size(121, 23);
            this.cmbbSexo.TabIndex = 10;
            // 
            // cmbbMatriz
            // 
            this.cmbbMatriz.FormattingEnabled = true;
            this.cmbbMatriz.Location = new System.Drawing.Point(12, 131);
            this.cmbbMatriz.Name = "cmbbMatriz";
            this.cmbbMatriz.Size = new System.Drawing.Size(121, 23);
            this.cmbbMatriz.TabIndex = 11;
            // 
            // cmbbPadreador
            // 
            this.cmbbPadreador.FormattingEnabled = true;
            this.cmbbPadreador.Location = new System.Drawing.Point(139, 131);
            this.cmbbPadreador.Name = "cmbbPadreador";
            this.cmbbPadreador.Size = new System.Drawing.Size(121, 23);
            this.cmbbPadreador.TabIndex = 12;
            // 
            // cmbbReservado
            // 
            this.cmbbReservado.FormattingEnabled = true;
            this.cmbbReservado.Location = new System.Drawing.Point(266, 131);
            this.cmbbReservado.Name = "cmbbReservado";
            this.cmbbReservado.Size = new System.Drawing.Size(121, 23);
            this.cmbbReservado.TabIndex = 13;
            // 
            // cmbbDono
            // 
            this.cmbbDono.FormattingEnabled = true;
            this.cmbbDono.Location = new System.Drawing.Point(393, 131);
            this.cmbbDono.Name = "cmbbDono";
            this.cmbbDono.Size = new System.Drawing.Size(153, 23);
            this.cmbbDono.TabIndex = 14;
            // 
            // cmbbComprador
            // 
            this.cmbbComprador.FormattingEnabled = true;
            this.cmbbComprador.Location = new System.Drawing.Point(553, 131);
            this.cmbbComprador.Name = "cmbbComprador";
            this.cmbbComprador.Size = new System.Drawing.Size(153, 23);
            this.cmbbComprador.TabIndex = 15;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 61);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Location = new System.Drawing.Point(119, 61);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(35, 15);
            this.lblPorte.TabIndex = 17;
            this.lblPorte.Text = "Porte";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(246, 61);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(71, 15);
            this.lblNascimento.TabIndex = 18;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(350, 61);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(32, 15);
            this.lblRaca.TabIndex = 19;
            this.lblRaca.Text = "Raça";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(479, 61);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(32, 15);
            this.lblSexo.TabIndex = 20;
            this.lblSexo.Text = "Sexo";
            // 
            // lblPedigree
            // 
            this.lblPedigree.AutoSize = true;
            this.lblPedigree.Location = new System.Drawing.Point(606, 61);
            this.lblPedigree.Name = "lblPedigree";
            this.lblPedigree.Size = new System.Drawing.Size(53, 15);
            this.lblPedigree.TabIndex = 21;
            this.lblPedigree.Text = "Pedigree";
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Location = new System.Drawing.Point(12, 113);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(40, 15);
            this.lblMatriz.TabIndex = 22;
            this.lblMatriz.Text = "Matriz";
            // 
            // lblPadreador
            // 
            this.lblPadreador.AutoSize = true;
            this.lblPadreador.Location = new System.Drawing.Point(139, 113);
            this.lblPadreador.Name = "lblPadreador";
            this.lblPadreador.Size = new System.Drawing.Size(61, 15);
            this.lblPadreador.TabIndex = 23;
            this.lblPadreador.Text = "Padreador";
            // 
            // lblReservado
            // 
            this.lblReservado.AutoSize = true;
            this.lblReservado.Location = new System.Drawing.Point(266, 113);
            this.lblReservado.Name = "lblReservado";
            this.lblReservado.Size = new System.Drawing.Size(61, 15);
            this.lblReservado.TabIndex = 24;
            this.lblReservado.Text = "Reservado";
            // 
            // lblDono
            // 
            this.lblDono.AutoSize = true;
            this.lblDono.Location = new System.Drawing.Point(393, 113);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(36, 15);
            this.lblDono.TabIndex = 25;
            this.lblDono.Text = "Dono";
            // 
            // lblComprador
            // 
            this.lblComprador.AutoSize = true;
            this.lblComprador.Location = new System.Drawing.Point(553, 113);
            this.lblComprador.Name = "lblComprador";
            this.lblComprador.Size = new System.Drawing.Size(68, 15);
            this.lblComprador.TabIndex = 26;
            this.lblComprador.Text = "Comprador";
            // 
            // colIdCachorro
            // 
            this.colIdCachorro.HeaderText = "Id";
            this.colIdCachorro.Name = "colIdCachorro";
            this.colIdCachorro.ReadOnly = true;
            this.colIdCachorro.Width = 50;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colPorte
            // 
            this.colPorte.HeaderText = "Porte";
            this.colPorte.Name = "colPorte";
            this.colPorte.ReadOnly = true;
            // 
            // colNascimento
            // 
            this.colNascimento.HeaderText = "Nascimento";
            this.colNascimento.Name = "colNascimento";
            this.colNascimento.ReadOnly = true;
            // 
            // colRaca
            // 
            this.colRaca.HeaderText = "Raça";
            this.colRaca.Name = "colRaca";
            this.colRaca.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colPedigree
            // 
            this.colPedigree.HeaderText = "Pedigree";
            this.colPedigree.Name = "colPedigree";
            this.colPedigree.ReadOnly = true;
            // 
            // colMatriz
            // 
            this.colMatriz.HeaderText = "Matriz";
            this.colMatriz.Name = "colMatriz";
            this.colMatriz.ReadOnly = true;
            // 
            // colPadreador
            // 
            this.colPadreador.HeaderText = "Padreador";
            this.colPadreador.Name = "colPadreador";
            this.colPadreador.ReadOnly = true;
            // 
            // colReservado
            // 
            this.colReservado.HeaderText = "Reservado";
            this.colReservado.Name = "colReservado";
            this.colReservado.ReadOnly = true;
            // 
            // colDono
            // 
            this.colDono.HeaderText = "Dono";
            this.colDono.Name = "colDono";
            // 
            // colComprador
            // 
            this.colComprador.HeaderText = "Comprador";
            this.colComprador.Name = "colComprador";
            // 
            // colCarteiras
            // 
            this.colCarteiras.HeaderText = "";
            this.colCarteiras.Name = "colCarteiras";
            this.colCarteiras.ReadOnly = true;
            this.colCarteiras.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCarteiras.Width = 30;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "";
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEditar.Width = 30;
            // 
            // colDeletar
            // 
            this.colDeletar.HeaderText = "";
            this.colDeletar.Name = "colDeletar";
            this.colDeletar.ReadOnly = true;
            this.colDeletar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDeletar.Width = 30;
            // 
            // frmCachorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 559);
            this.Controls.Add(this.lblComprador);
            this.Controls.Add(this.lblDono);
            this.Controls.Add(this.lblReservado);
            this.Controls.Add(this.lblPadreador);
            this.Controls.Add(this.lblMatriz);
            this.Controls.Add(this.lblPedigree);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblPorte);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.cmbbComprador);
            this.Controls.Add(this.cmbbDono);
            this.Controls.Add(this.cmbbReservado);
            this.Controls.Add(this.cmbbPadreador);
            this.Controls.Add(this.cmbbMatriz);
            this.Controls.Add(this.cmbbSexo);
            this.Controls.Add(this.cmbbRaca);
            this.Controls.Add(this.cmbbPorte);
            this.Controls.Add(this.txtbPedigree);
            this.Controls.Add(this.txtbNascimento);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvCachorros);
            this.Name = "frmCachorro";
            this.Text = "frmCachorro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCachorros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCachorros;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbNascimento;
        private System.Windows.Forms.TextBox txtbPedigree;
        private System.Windows.Forms.ComboBox cmbbPorte;
        private System.Windows.Forms.ComboBox cmbbRaca;
        private System.Windows.Forms.ComboBox cmbbSexo;
        private System.Windows.Forms.ComboBox cmbbMatriz;
        private System.Windows.Forms.ComboBox cmbbPadreador;
        private System.Windows.Forms.ComboBox cmbbReservado;
        private System.Windows.Forms.ComboBox cmbbDono;
        private System.Windows.Forms.ComboBox cmbbComprador;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPedigree;
        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.Label lblPadreador;
        private System.Windows.Forms.Label lblReservado;
        private System.Windows.Forms.Label lblDono;
        private System.Windows.Forms.Label lblComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCachorro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPedigree;
        private System.Windows.Forms.DataGridViewButtonColumn colMatriz;
        private System.Windows.Forms.DataGridViewButtonColumn colPadreador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReservado;
        private System.Windows.Forms.DataGridViewButtonColumn colDono;
        private System.Windows.Forms.DataGridViewButtonColumn colComprador;
        private System.Windows.Forms.DataGridViewButtonColumn colCarteiras;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colDeletar;
    }
}