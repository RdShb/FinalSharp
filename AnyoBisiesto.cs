class Anyo
{    
    public void AnyoBisiesto()
    {
        Console.Write("Ingrese un año: ");
        int anio = 0;
        if (int.TryParse(Console.ReadLine(), out anio))

            if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
            {
                Console.WriteLine(anio + " es un año bisiesto");
            }
            else
            {
                Console.WriteLine(anio + " no es un año bisiesto");
            }
        else
            Console.WriteLine("Ha entrado un año incorrecto");
    }
}