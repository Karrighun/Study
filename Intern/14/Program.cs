// Найти третью цифру числа или сообщить, что её нет

void FindThirdNumber(int number)
{
    int result = Math.Abs(number / 100 % 10);
    if (result == 0)
        Console.WriteLine("Третьей цифры нет.");
    else
        Console.WriteLine(result);
}
FindThirdNumber(42);
//done