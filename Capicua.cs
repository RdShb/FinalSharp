class Capic
{
  public void Capicua() 
  {
    Console.Write("Ingresa un número: ");
    int num = 0;
    if (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Número invalido");
        return;
    }
    int originalNum = num;
    int reversedNum = 0;

    while (num > 0)
    {
        int digit = num % 10;
        reversedNum = (reversedNum * 10) + digit;
        num /= 10;
    }

    if (originalNum == reversedNum)
    {
        Console.WriteLine("El número es capicúa.");
    }
    else
    {
        Console.WriteLine("El número no es capicúa.");
    }
  }
}