class Pal
{
    public void palindromo()
    {
        Console.Write("Ingrese una palabra o frase: ");
        string? texto = Console.ReadLine();
        if (texto == null)
        {
            Console.Write("Texto invalido");
            return;
        }
        texto = texto.ToLower().Replace(" ", "");
        bool palindromo = true;
        for (int i = 0; i < texto.Length / 2; i++)
        {
            if (texto[i] != texto[texto.Length - 1 - i])
            {
                palindromo = false;
                break;
            }
        }

        if (palindromo)
        {
            Console.WriteLine("La cadena es un palíndromo");
        }
        else
        {
            Console.WriteLine("La cadena no es un palíndromo");
        }

    }
}