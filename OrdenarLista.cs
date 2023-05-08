class Ordenar
{
    public void ordenarLista()
    {
        string[] nombres = { "Juan", "Maria", "Ana", "Pedro" };

        Array.Sort(nombres);

        Console.WriteLine("Lista ordenada alfabéticamente:");

        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}