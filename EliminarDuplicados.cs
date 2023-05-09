class Duplicados
{
    public void EliminarDuplicados()
    {
            List<int> numeros = new List<int>();

            List<int> numerosSinDuplicados = new List<int>();
            while(true)
            {
                Console.WriteLine("Introduce un numero o Intro para terminar: ");
                string? numero = Console.ReadLine();
                int numericValue;

                if(numero == "") break;
                else
                {
                    bool isNumber = int.TryParse(numero, out numericValue);
                    if (isNumber == true)
                    {
                        numeros.Add(numericValue);
                    }
                    else Console.WriteLine("El número no es correcto ");
                }
            }
            foreach (int numero in numeros)
            {
                if (!numerosSinDuplicados.Contains(numero))
                {
                    numerosSinDuplicados.Add(numero);
                }
            }

            Console.WriteLine("Números originales: " + string.Join(", ", numeros));
            Console.WriteLine("Números sin duplicados: " + string.Join(", ", numerosSinDuplicados));
        }

}