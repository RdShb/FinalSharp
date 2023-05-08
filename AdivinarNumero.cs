class Adivinar
{
    public void AdivinarNumero()
    {

        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int intentos = 0;
        int numeroUsuario = 0;

        while (numeroUsuario != numeroAleatorio)
        {
            Console.WriteLine("Adivina el número (entre 1 y 100):");
            if (!int.TryParse(Console.ReadLine(), out numeroUsuario))
            {
                Console.WriteLine("Número invalido");
                continue;
            }
            intentos++;

            if (numeroUsuario < numeroAleatorio)
            {
                Console.WriteLine("El número introducido es menor que el número aleatorio.");
            }
            else if (numeroUsuario > numeroAleatorio)
            {
                Console.WriteLine("El número introducido es mayor que el número aleatorio.");
            }
        }

        Console.WriteLine("¡Has acertado el número en " + intentos + " intentos!");
    }

}
