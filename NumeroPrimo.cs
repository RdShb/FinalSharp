class NumPrim
{
    public void NumeroPrimo()
    {
        int num = 0, i;
        bool esPrimo = true;

        Console.Write("Introduce un número entero positivo: ");
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Número invalido");
            return;
        }

        for (i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
            Console.WriteLine("{0} es un número primo", num);
        else
            Console.WriteLine("{0} no es un número primo", num);
    }
}