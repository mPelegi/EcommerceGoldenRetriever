
namespace EcommerceGoldenRetriever.MVC.Views.Venda
{
    partial class frmDadosCachorro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDadosCachorro));
            this.lblPedigree = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblPorte = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdCachorro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPedigree
            // 
            this.lblPedigree.AutoSize = true;
            this.lblPedigree.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPedigree.Location = new System.Drawing.Point(12, 143);
            this.lblPedigree.Name = "lblPedigree";
            this.lblPedigree.Size = new System.Drawing.Size(74, 20);
            this.lblPedigree.TabIndex = 16;
            this.lblPedigree.Text = "Pedigree: ";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.Location = new System.Drawing.Point(12, 123);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(48, 20);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo: ";
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRaca.Location = new System.Drawing.Point(12, 103);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(48, 20);
            this.lblRaca.TabIndex = 14;
            this.lblRaca.Text = "Raça: ";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNascimento.Location = new System.Drawing.Point(12, 83);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(95, 20);
            this.lblNascimento.TabIndex = 13;
            this.lblNascimento.Text = "Nascimento: ";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPorte.Location = new System.Drawing.Point(12, 63);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(50, 20);
            this.lblPorte.TabIndex = 12;
            this.lblPorte.Text = "Porte: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(12, 43);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 20);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome: ";
            // 
            // lblIdCachorro
            // 
            this.lblIdCachorro.AutoSize = true;
            this.lblIdCachorro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCachorro.Location = new System.Drawing.Point(12, 9);
            this.lblIdCachorro.Name = "lblIdCachorro";
            this.lblIdCachorro.Size = new System.Drawing.Size(20, 25);
            this.lblIdCachorro.TabIndex = 9;
            this.lblIdCachorro.Text = "-";
            // 
            // frmDadosCachorro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 176);
            this.Controls.Add(this.lblPedigree);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblPorte);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIdCachorro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 215);
            this.MinimumSize = new System.Drawing.Size(320, 215);
            this.Name = "frmDadosCachorro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do Cachorro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPedigree;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdCachorro;
    }
}