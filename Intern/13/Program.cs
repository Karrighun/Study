// Выяснить, кратно ли число заданному, если нет, вывести остаток.
void IsMultipe(int number, int remainder)
{
    int result = number % remainder;
    if(result == 0)
    {
        Console.WriteLine($"Число {number} делится на число {remainder} без остатка");
    }
    else
    {
        Console.WriteLine($"Число {number} делится на число {remainder} с остатком: {result}");
    }

}
IsMultipe(18, 5);

//done