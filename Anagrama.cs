class Anagram
{
    public void Anagrama()
    {
        Console.WriteLine("Escriba una palabra");
        string? palabra1 = Console.ReadLine();
        Console.WriteLine("Escriba otra palabra");
        string? palabra2 = Console.ReadLine();
        if (String.IsNullOrEmpty(palabra1) || String.IsNullOrEmpty(palabra2))
        {
            Console.WriteLine("Una de las palabras introducidas no es valida");
        }
        else
        {
            char[] letras1 = palabra1.ToLower().ToCharArray();
            char[] letras2 = palabra2.ToLower().ToCharArray();

            Array.Sort(letras1);
            Array.Sort(letras2);

            bool sonAnagramas = letras1.SequenceEqual(letras2);

            if (sonAnagramas)
            {
                Console.WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
            }
            else
            {
                Console.WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
            }
        }
    }
}

