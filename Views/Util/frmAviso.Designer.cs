
namespace EcommerceGoldenRetriever.MVC.Views.Util
{
    partial class frmAviso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviso));
            this.lblAtencao = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.rtxtbDetalhes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblAtencao
            // 
            this.lblAtencao.AutoSize = true;
            this.lblAtencao.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAtencao.Image = global::EcommerceGoldenRetriever.MVC.Properties.Resources.error;
            this.lblAtencao.Location = new System.Drawing.Point(12, 65);
            this.lblAtencao.Name = "lblAtencao";
            this.lblAtencao.Size = new System.Drawing.Size(106, 128);
            this.lblAtencao.TabIndex = 0;
            this.lblAtencao.Text = "  ";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(150, 26);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(411, 30);
            this.lblErro.TabIndex = 1;
            this.lblErro.Text = "Erro: Ocorreu um erro durante a execução do comando, veja detalhes abaixo\r\n\r\n";
            // 
            // rtxtbDetalhes
            // 
            this.rtxtbDetalhes.Location = new System.Drawing.Point(150, 52);
            this.rtxtbDetalhes.Name = "rtxtbDetalhes";
            this.rtxtbDetalhes.ReadOnly = true;
            this.rtxtbDetalhes.Size = new System.Drawing.Size(450, 197);
            this.rtxtbDetalhes.TabIndex = 2;
            this.rtxtbDetalhes.Text = "";
            // 
            // frmAviso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 261);
            this.Controls.Add(this.rtxtbDetalhes);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblAtencao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAviso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atenção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtencao;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.RichTextBox rtxtbDetalhes;
    }
}