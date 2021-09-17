
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnCachorros = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.btnLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCachorros
            // 
            this.btnCachorros.Location = new System.Drawing.Point(88, 119);
            this.btnCachorros.Name = "btnCachorros";
            this.btnCachorros.Size = new System.Drawing.Size(116, 41);
            this.btnCachorros.TabIndex = 0;
            this.btnCachorros.Text = "Cachorros";
            this.btnCachorros.UseVisualStyleBackColor = true;
            this.btnCachorros.Click += new System.EventHandler(this.btnCachorros_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Location = new System.Drawing.Point(88, 182);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(116, 41);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeProjeto.Location = new System.Drawing.Point(27, 31);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(230, 60);
            this.lblNomeProjeto.TabIndex = 2;
            this.lblNomeProjeto.Text = "Ecommerce\r\nGolden Retriever MVC";
            this.lblNomeProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogs
            // 
            this.btnLogs.Image = global::EcommerceGoldenRetriever.MVC.Properties.Resources.log;
            this.btnLogs.Location = new System.Drawing.Point(236, 12);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(36, 36);
            this.btnLogs.TabIndex = 3;
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.lblNomeProjeto);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.btnCachorros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecommerce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCachorros;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Button btnLogs;
    }
}

