class Media
{
        public void MediaLista()
    {
            List<int> listaNumeros = new List<int>();
            while(true){
                Console.WriteLine("Introduce un numero o enter para terminar: ");
                string? numero = Console.ReadLine();
                int numericValue;

                if(numero == "") break;
                else{
                    if(int.TryParse(numero, out numericValue)) listaNumeros.Add(numericValue);
                    else Console.WriteLine("El número no es correcto ");
                } 
            }
            Console.WriteLine("La media es: " + listaNumeros.Average());
        }
}
