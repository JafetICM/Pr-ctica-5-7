namespace ListarPalabrasPorLetraApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnAgregarPalabra = new System.Windows.Forms.Button();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(20, 40);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(200, 20);
            this.txtPalabra.TabIndex = 0;
            // 
            // btnAgregarPalabra
            // 
            this.btnAgregarPalabra.Location = new System.Drawing.Point(230, 38);
            this.btnAgregarPalabra.Name = "btnAgregarPalabra";
            this.btnAgregarPalabra.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarPalabra.TabIndex = 1;
            this.btnAgregarPalabra.Text = "Agregar Palabra";
            this.btnAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnAgregarPalabra.Click += new System.EventHandler(this.btnAgregarPalabra_Click);
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(20, 90);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(310, 160);
            this.lstPalabras.TabIndex = 2;
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(20, 20);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(43, 13);
            this.lblPalabra.TabIndex = 3;
            this.lblPalabra.Text = "Palabra";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(354, 271);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.lstPalabras);
            this.Controls.Add(this.btnAgregarPalabra);
            this.Controls.Add(this.txtPalabra);
            this.Name = "Form1";
            this.Text = "Listar Palabras por Letra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnAgregarPalabra;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Label lblPalabra;
    }
}
