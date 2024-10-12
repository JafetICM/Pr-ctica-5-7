public class Nodo
{
    public char Letra { get; set; }
    public Nodo Siguiente { get; set; }

    public Nodo(char letra)
    {
        Letra = letra;
        Siguiente = null;
    }
}
