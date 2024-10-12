using System;
using System.Collections.Generic; // Necesario para usar listas
using System.Windows.Forms;

namespace PalindromosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.Trim();

            if (!string.IsNullOrWhiteSpace(palabra))
            {
                if (EsPalindromo(palabra))
                {
                    lblResultado.Text = $"La palabra '{palabra}' es un palíndromo.";
                }
                else
                {
                    lblResultado.Text = $"La palabra '{palabra}' no es un palíndromo.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una palabra válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsPalindromo(string palabra)
        {
            // Convertir la palabra en minúsculas
            string palabraMinusculas = palabra.ToLower();

            // Crear una lista de caracteres a partir de la palabra
            List<char> caracteres = new List<char>(palabraMinusculas.ToCharArray());

            // Crear una lista inversa
            List<char> caracteresInvertidos = new List<char>(caracteres);
            caracteresInvertidos.Reverse(); // Invertir la lista

            // Comparamos las dos listas
            for (int i = 0; i < caracteres.Count; i++)
            {
                if (caracteres[i] != caracteresInvertidos[i])
                {
                    return false; // No es un palíndromo si no coinciden
                }
            }

            return true; // Es un palíndromo si las dos listas coinciden
        }
    }
}
