// По двум заданным числам проверять является ли одно квадратом другого

bool IsSquare(int x, int y)
{
    if (x == y * y)
        return true;
    else
        return false;
}

 if (IsSquare(36, 6))
Console.WriteLine("Да");
else
Console.WriteLine("нет");
