class Factoriales
{
    public void Factorial()
    {
        int num = 0, factorial = 1;

        Console.Write("Introduce un número entero positivo: ");
        if (int.TryParse(Console.ReadLine(), out num))
        {

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("El factorial de {0} es {1}", num, factorial);
        }
        else
            Console.WriteLine("Número inválido");

        Console.ReadKey();
    }
}