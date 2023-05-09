class Ordenar
{
    public void ordenarLista()
    {
            List<string> listaNombres = new List<string>();
            while(true){
                Console.WriteLine("Introduce un nombre o Enter para terminar: ");
                string? nombre = Console.ReadLine();
                if (nombre == "") break;
                else if(nombre !=null) listaNombres.Add(nombre);
            }
            listaNombres.Sort();

            Console.WriteLine("Lista ordenada alfabéticamente:");

            foreach (string nombre in listaNombres)
            {
                Console.WriteLine(nombre);
            }
        }
}