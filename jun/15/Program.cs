// Дано число. Проверить кратно ли оно 7 и 23

bool IsMultipleSevenAndTwentyThree(int number)
{
    if ((number % 7 == 0) && (number % 23 == 0))
        return true;
    else
        return false;
}

if (IsMultipleSevenAndTwentyThree(23))
Console.WriteLine("Делиться");
else
Console.WriteLine("Не делиться");

// done