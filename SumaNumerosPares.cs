class SumaPar 
{
    public void SumaNumerosPares()
    {
            List<int> numeros = new List<int>();
            int suma = 0;
            while(true){
                Console.WriteLine("Introduce un numero o Enter para terminar: ");
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
            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                    suma += num;
            }

            Console.WriteLine("La suma de los números pares es {0}", suma);
    }
}