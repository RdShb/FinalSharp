class NumPosNeg 
{

    public void NumeroPositivoNegativoCero()
    {

        int num;

        Console.Write("Introduce un número entero: ");
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Número invalido");
            return;
        }

        if (num > 0)
            Console.WriteLine($"{num} es un número positivo", num);
        else if (num < 0)
            Console.WriteLine($"{num} es un número negativo", num);
        else
            Console.WriteLine($"{num} es cero", num);

        Console.ReadKey();
    }
}