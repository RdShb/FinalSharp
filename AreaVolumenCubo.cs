class Cubo 
{
    public void AreaVolumenCubo()
    {
        double lado = 0, area, volumen;

        Console.Write("Introduce el valor del lado del cubo: ");
        if (!double.TryParse(Console.ReadLine(), out lado))
        {
            Console.WriteLine("Lado invalido");
            return;
        }

        area = 6 * Math.Pow(lado, 2);
        volumen = Math.Pow(lado, 3);

        Console.WriteLine("El área del cubo es {0}", area);
        Console.WriteLine("El volumen del cubo es {0}", volumen);

        Console.ReadKey();
    }
}