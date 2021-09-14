
namespace EcommerceGoldenRetriever.MVC
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCachorros = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCachorros
            // 
            this.btnCachorros.Location = new System.Drawing.Point(42, 40);
            this.btnCachorros.Name = "btnCachorros";
            this.btnCachorros.Size = new System.Drawing.Size(116, 41);
            this.btnCachorros.TabIndex = 0;
            this.btnCachorros.Text = "Cachorros";
            this.btnCachorros.UseVisualStyleBackColor = true;
            this.btnCachorros.Click += new System.EventHandler(this.btnCachorros_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(42, 102);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(116, 41);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.Location = new System.Drawing.Point(12, 9);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(189, 15);
            this.lblNomeProjeto.TabIndex = 2;
            this.lblNomeProjeto.Text = "Ecommerce Golden Retriever MVC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 159);
            this.Controls.Add(this.lblNomeProjeto);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnCachorros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCachorros;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Label lblNomeProjeto;
    }
}

