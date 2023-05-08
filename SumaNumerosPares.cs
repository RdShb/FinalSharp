class SumaPar 
{
    public void SumaNumerosPares()
    {
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int suma = 0;

        foreach (int num in numeros)
        {
            if (num % 2 == 0)
                suma += num;
        }

        Console.WriteLine("La suma de los números pares es {0}", suma);

        Console.ReadKey();
    }
}