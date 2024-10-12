public class ListaEnlazada
{
    public Nodo Cabeza { get; private set; }

    public ListaEnlazada()
    {
        Cabeza = null;
    }

    public void Agregar(char letra)
    {
        Nodo nuevoNodo = new Nodo(letra);
        if (Cabeza == null)
        {
            Cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        Cabeza = anterior;
    }

    public string ObtenerPalabraInvertida()
    {
        Nodo actual = Cabeza;
        string resultado = "";
        while (actual != null)
        {
            resultado += actual.Letra;
            actual = actual.Siguiente;
        }
        return resultado;
    }
}
