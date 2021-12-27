// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

bool IsWeekend(int number)
{
    if ((number == 6) || (number == 7))
        return true;
    else
        return false;
}

if (IsWeekend(4))
Console.WriteLine("Выходной");
else
Console.WriteLine("Будни");

// done