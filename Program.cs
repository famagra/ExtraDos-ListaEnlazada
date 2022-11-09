using ListaEnlasada;

internal class Program
{
 
    private static void Main(string[] args)
    {
        facuLinkedList lista = new facuLinkedList();
        lista.add(5);
        lista.add(7);
        lista.add(9);
        lista.add(10);

        lista.addPos(lista.posicion(1), 23);

        lista.delete(lista.posicion(4));

        lista.print();
    }
}