using System;
using System.Windows.Forms;

namespace InvertirPalabrasApp
{
    public partial class Form1 : Form
    {
        private ListaEnlazada listaPalabra;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (!string.IsNullOrWhiteSpace(palabra))
            {
                // Inicializamos la lista enlazada
                listaPalabra = new ListaEnlazada();

                // Agregamos cada letra de la palabra a la lista
                foreach (char letra in palabra)
                {
                    listaPalabra.Agregar(letra);
                }

                // Invertimos la lista
                listaPalabra.Invertir();

                // Mostramos la palabra invertida
                lblResultado.Text = $"Palabra invertida: {listaPalabra.ObtenerPalabraInvertida()}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una palabra válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
