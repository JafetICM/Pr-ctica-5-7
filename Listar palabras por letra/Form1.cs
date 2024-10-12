using System;
using System.Windows.Forms;

namespace ListarPalabrasPorLetraApp
{
    public partial class Form1 : Form
    {
        private PalabrasPorLetra palabrasPorLetra;

        public Form1()
        {
            InitializeComponent();
            palabrasPorLetra = new PalabrasPorLetra();
        }

        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (!string.IsNullOrWhiteSpace(palabra))
            {
                palabrasPorLetra.AgregarPalabra(palabra);
                MostrarListas();
                txtPalabra.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una palabra válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarListas()
        {
            lstPalabras.Items.Clear();

            var listas = palabrasPorLetra.ObtenerListasPorLetra();
            foreach (var lista in listas)
            {
                lstPalabras.Items.Add(lista);
            }
        }
    }
}
