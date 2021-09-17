
namespace EcommerceGoldenRetriever.MVC.Views.Util
{
    partial class frmLogger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogger));
            this.rtxtbLogs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtbLogs
            // 
            this.rtxtbLogs.Location = new System.Drawing.Point(12, 12);
            this.rtxtbLogs.Name = "rtxtbLogs";
            this.rtxtbLogs.ReadOnly = true;
            this.rtxtbLogs.Size = new System.Drawing.Size(776, 314);
            this.rtxtbLogs.TabIndex = 0;
            this.rtxtbLogs.Text = "";
            // 
            // frmLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.rtxtbLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs do Banco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtbLogs;
    }
}