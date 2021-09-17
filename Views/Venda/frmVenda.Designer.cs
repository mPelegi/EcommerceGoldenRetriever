
namespace EcommerceGoldenRetriever.MVC.Views.Venda
{
    partial class frmVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenda));
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.colIdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCachorro = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colComprador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotaFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblComprador = new System.Windows.Forms.Label();
            this.cmbbComprador = new System.Windows.Forms.ComboBox();
            this.lblCachorrosDisponiveis = new System.Windows.Forms.Label();
            this.cmbbCachorrosDisponiveis = new System.Windows.Forms.ComboBox();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblNotaFiscal = new System.Windows.Forms.Label();
            this.txtbDataCompra = new System.Windows.Forms.TextBox();
            this.txtbDataReserva = new System.Windows.Forms.TextBox();
            this.cmbbStatus = new System.Windows.Forms.ComboBox();
            this.txtbNotaFiscal = new System.Windows.Forms.TextBox();
            this.txtbValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVenda,
            this.colCachorro,
            this.colComprador,
            this.colDataCompra,
            this.colDataReserva,
            this.colStatus,
            this.colValor,
            this.colNotaFiscal,
            this.colEditar,
            this.colCancelar});
            this.dgvVendas.Location = new System.Drawing.Point(14, 163);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.RowTemplate.Height = 25;
            this.dgvVendas.Size = new System.Drawing.Size(752, 386);
            this.dgvVendas.TabIndex = 1;
            this.dgvVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellClick);
            this.dgvVendas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvVendas_CellPainting);
            // 
            // colIdVenda
            // 
            this.colIdVenda.HeaderText = "Id";
            this.colIdVenda.Name = "colIdVenda";
            this.colIdVenda.ReadOnly = true;
            this.colIdVenda.Width = 50;
            // 
            // colCachorro
            // 
            this.colCachorro.HeaderText = "Cachorro";
            this.colCachorro.Name = "colCachorro";
            this.colCachorro.ReadOnly = true;
            this.colCachorro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCachorro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colComprador
            // 
            this.colComprador.HeaderText = "Comprador";
            this.colComprador.Name = "colComprador";
            this.colComprador.Width = 150;
            // 
            // colDataCompra
            // 
            this.colDataCompra.HeaderText = "Data da Compra";
            this.colDataCompra.Name = "colDataCompra";
            this.colDataCompra.ReadOnly = true;
            this.colDataCompra.Width = 130;
            // 
            // colDataReserva
            // 
            this.colDataReserva.HeaderText = "Data da Reserva";
            this.colDataReserva.Name = "colDataReserva";
            this.colDataReserva.ReadOnly = true;
            this.colDataReserva.Width = 130;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colNotaFiscal
            // 
            this.colNotaFiscal.HeaderText = "Nota Fiscal";
            this.colNotaFiscal.Name = "colNotaFiscal";
            this.colNotaFiscal.ReadOnly = true;
            // 
            // colEditar
            // 
            this.colEditar.HeaderText = "";
            this.colEditar.Name = "colEditar";
            this.colEditar.ReadOnly = true;
            this.colEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colEditar.Width = 30;
            // 
            // colCancelar
            // 
            this.colCancelar.HeaderText = "";
            this.colCancelar.Name = "colCancelar";
            this.colCancelar.ReadOnly = true;
            this.colCancelar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCancelar.Width = 30;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::EcommerceGoldenRetriever.MVC.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(714, 82);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(52, 75);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblComprador
            // 
            this.lblComprador.AutoSize = true;
            this.lblComprador.Location = new System.Drawing.Point(198, 64);
            this.lblComprador.Name = "lblComprador";
            this.lblComprador.Size = new System.Drawing.Size(68, 15);
            this.lblComprador.TabIndex = 28;
            this.lblComprador.Text = "Comprador";
            // 
            // cmbbComprador
            // 
            this.cmbbComprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbComprador.FormattingEnabled = true;
            this.cmbbComprador.Location = new System.Drawing.Point(198, 82);
            this.cmbbComprador.Name = "cmbbComprador";
            this.cmbbComprador.Size = new System.Drawing.Size(198, 23);
            this.cmbbComprador.TabIndex = 27;
            // 
            // lblCachorrosDisponiveis
            // 
            this.lblCachorrosDisponiveis.AutoSize = true;
            this.lblCachorrosDisponiveis.Location = new System.Drawing.Point(14, 64);
            this.lblCachorrosDisponiveis.Name = "lblCachorrosDisponiveis";
            this.lblCachorrosDisponiveis.Size = new System.Drawing.Size(124, 15);
            this.lblCachorrosDisponiveis.TabIndex = 29;
            this.lblCachorrosDisponiveis.Text = "Cachorros Disponíveis";
            // 
            // cmbbCachorrosDisponiveis
            // 
            this.cmbbCachorrosDisponiveis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbCachorrosDisponiveis.FormattingEnabled = true;
            this.cmbbCachorrosDisponiveis.Location = new System.Drawing.Point(14, 82);
            this.cmbbCachorrosDisponiveis.Name = "cmbbCachorrosDisponiveis";
            this.cmbbCachorrosDisponiveis.Size = new System.Drawing.Size(178, 23);
            this.cmbbCachorrosDisponiveis.TabIndex = 30;
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(402, 64);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(93, 15);
            this.lblDataCompra.TabIndex = 31;
            this.lblDataCompra.Text = "Data da Compra";
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.Location = new System.Drawing.Point(558, 64);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(90, 15);
            this.lblDataReserva.TabIndex = 32;
            this.lblDataReserva.Text = "Data da Reserva";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(14, 116);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(173, 116);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(33, 15);
            this.lblValor.TabIndex = 34;
            this.lblValor.Text = "Valor";
            // 
            // lblNotaFiscal
            // 
            this.lblNotaFiscal.AutoSize = true;
            this.lblNotaFiscal.Location = new System.Drawing.Point(372, 116);
            this.lblNotaFiscal.Name = "lblNotaFiscal";
            this.lblNotaFiscal.Size = new System.Drawing.Size(65, 15);
            this.lblNotaFiscal.TabIndex = 35;
            this.lblNotaFiscal.Text = "Nota Fiscal";
            // 
            // txtbDataCompra
            // 
            this.txtbDataCompra.Location = new System.Drawing.Point(402, 82);
            this.txtbDataCompra.Name = "txtbDataCompra";
            this.txtbDataCompra.Size = new System.Drawing.Size(150, 23);
            this.txtbDataCompra.TabIndex = 36;
            // 
            // txtbDataReserva
            // 
            this.txtbDataReserva.Location = new System.Drawing.Point(558, 82);
            this.txtbDataReserva.Name = "txtbDataReserva";
            this.txtbDataReserva.Size = new System.Drawing.Size(150, 23);
            this.txtbDataReserva.TabIndex = 37;
            // 
            // cmbbStatus
            // 
            this.cmbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbStatus.FormattingEnabled = true;
            this.cmbbStatus.Location = new System.Drawing.Point(14, 134);
            this.cmbbStatus.Name = "cmbbStatus";
            this.cmbbStatus.Size = new System.Drawing.Size(153, 23);
            this.cmbbStatus.TabIndex = 38;
            // 
            // txtbNotaFiscal
            // 
            this.txtbNotaFiscal.Location = new System.Drawing.Point(373, 134);
            this.txtbNotaFiscal.Name = "txtbNotaFiscal";
            this.txtbNotaFiscal.Size = new System.Drawing.Size(100, 23);
            this.txtbNotaFiscal.TabIndex = 39;
            // 
            // txtbValor
            // 
            this.txtbValor.Location = new System.Drawing.Point(173, 134);
            this.txtbValor.Name = "txtbValor";
            this.txtbValor.Size = new System.Drawing.Size(194, 23);
            this.txtbValor.TabIndex = 40;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 561);
            this.Controls.Add(this.txtbValor);
            this.Controls.Add(this.txtbNotaFiscal);
            this.Controls.Add(this.cmbbStatus);
            this.Controls.Add(this.txtbDataReserva);
            this.Controls.Add(this.txtbDataCompra);
            this.Controls.Add(this.lblNotaFiscal);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataReserva);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.cmbbCachorrosDisponiveis);
            this.Controls.Add(this.lblCachorrosDisponiveis);
            this.Controls.Add(this.lblComprador);
            this.Controls.Add(this.cmbbComprador);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 600);
            this.MinimumSize = new System.Drawing.Size(795, 600);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerência de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVenda;
        private System.Windows.Forms.DataGridViewButtonColumn colCachorro;
        private System.Windows.Forms.DataGridViewButtonColumn colComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotaFiscal;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblComprador;
        private System.Windows.Forms.ComboBox cmbbComprador;
        private System.Windows.Forms.Label lblCachorrosDisponiveis;
        private System.Windows.Forms.ComboBox cmbbCachorrosDisponiveis;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.Label lblDataReserva;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblNotaFiscal;
        private System.Windows.Forms.TextBox txtbDataCompra;
        private System.Windows.Forms.TextBox txtbDataReserva;
        private System.Windows.Forms.ComboBox cmbbStatus;
        private System.Windows.Forms.TextBox txtbNotaFiscal;
        private System.Windows.Forms.TextBox txtbValor;
    }
}