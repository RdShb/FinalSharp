using static System.Console;
int var = 0;
do
{
    Clear();
    Console.WriteLine("Escriba 1 para acceder a Menor y Mayor");
    Console.WriteLine("Escriba 2 para acceder a Impar y Par");
    Console.WriteLine("Escriba 3 para acceder a Año Biciesto");
    Console.WriteLine("Escriba 4 para acceder a Palindromo");
    Console.WriteLine("Escriba 5 para acceder a Ordenar Lista");
    Console.WriteLine("Escriba 6 para acceder a Factorial");
    Console.WriteLine("Escriba 7 para acceder a Numero Primo");
    Console.WriteLine("Escriba 8 para acceder a Cubo");
    Console.WriteLine("Escriba 9 para acceder a Suma Numeros Pares");
    Console.WriteLine("Escriba 10 para acceder a Positivo, Negativo o Cero");
    Console.WriteLine("Escriba 11 para acceder a Media Lista");
    Console.WriteLine("Escriba 12 para acceder a Adivinar Numero");
    Console.WriteLine("Escriba 13 para acceder a Anagrama");
    Console.WriteLine("Escriba 14 para acceder a Eliminar Duplicados");
    Console.WriteLine("Escriba 15 para acceder a Capicua");
    int caso = 0;
    if (Int32.TryParse(Console.ReadLine(), out caso))
    {
        if (caso > 15)
            Console.WriteLine("El valor introducido es mayor a 15. ");
        else
            switch (caso)
            {
                case 1:
                    new MenMay().MenorMayor();
                    break;
                case 2:
                    new ParOIpmar().ParImpar();
                    break;
                case 3:
                    new Anyo().AnyoBisiesto();
                    break;
                case 4:
                    new Pal().palindromo();
                    break;
                case 5:
                    new Ordenar().ordenarLista();
                    break;
                case 6:
                    new Factoriales().Factorial();
                    break;
                case 7:
                    new NumPrim().NumeroPrimo();
                    break;
                case 8:
                    new Cubo().AreaVolumenCubo();
                    break;
                case 9:
                    new SumaPar().SumaNumerosPares();
                    break;
                case 10:
                    new NumPosNeg().NumeroPositivoNegativoCero();
                    break;
                case 11:
                    new Media().MediaLista();
                    break;
                case 12:
                    new Adivinar().AdivinarNumero();
                    break;
                case 13:
                    new Anagram().Anagrama();
                    break;
                case 14:
                    new Duplicados().EliminarDuplicados();
                    break;
                case 15:
                    new Capic().Capicua();
                    break;
            }
        Console.WriteLine("Desea acceder a otra aplicacion? Y/N ");
        string? sino = Console.ReadLine();
        if (sino != "Y")
            {var = 1;
            Console.WriteLine("Hasta luego");
            Console.ReadLine();
            }
        else
        {
            var = 0;
            Console.WriteLine("Enter para Continuar: ");
            Console.ReadLine();
        }
    }
    else
        WriteLine("Opcion invalida");
}
while (var == 0);