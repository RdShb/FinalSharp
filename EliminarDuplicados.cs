class Duplicados
{
    public void EliminarDuplicados()
    {
        List<int> numeros = new List<int>() { 10, 20, 30, 20, 50 };

        List<int> numerosSinDuplicados = new List<int>();

        foreach (int numero in numeros)
        {
            if (!numerosSinDuplicados.Contains(numero))
            {
                numerosSinDuplicados.Add(numero);
            }
        }

        Console.WriteLine("Números originales: " + string.Join(", ", numeros));
        Console.WriteLine("Números originales: " + string.Join(", ", numeros));

    }

}