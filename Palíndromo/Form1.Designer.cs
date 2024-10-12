namespace PalindromosApp
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
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
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(230, 38);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 23);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar Palíndromo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(20, 80);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(110, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado: ------------";
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(20, 20);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(46, 13);
            this.lblPalabra.TabIndex = 3;
            this.lblPalabra.Text = "Palabra:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(354, 150);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtPalabra);
            this.Name = "Form1";
            this.Text = "Verificar Palíndromos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPalabra;
    }
}
