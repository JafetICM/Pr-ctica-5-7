using System;
using System.Collections.Generic;

namespace ListarPalabrasPorLetraApp
{
    public class PalabrasPorLetra
    {
        // Diccionario para almacenar palabras por letra inicial
        public Dictionary<char, List<string>> Palabras { get; private set; }

        public PalabrasPorLetra()
        {
            Palabras = new Dictionary<char, List<string>>();
        }

        // Método para agregar una palabra a la lista correspondiente
        public void AgregarPalabra(string palabra)
        {
            if (string.IsNullOrWhiteSpace(palabra))
                return;

            char letraInicial = char.ToUpper(palabra[0]);

            if (!Palabras.ContainsKey(letraInicial))
            {
                Palabras[letraInicial] = new List<string>();
            }

            Palabras[letraInicial].Add(palabra);
        }

        // Método para obtener las listas de palabras agrupadas
        public List<string> ObtenerListasPorLetra()
        {
            List<string> resultado = new List<string>();

            foreach (var grupo in Palabras)
            {
                resultado.Add($"{grupo.Key}: {string.Join(", ", grupo.Value)}");
            }

            return resultado;
        }
    }
}
