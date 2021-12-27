// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool CheckStatement(bool X, bool Y)
{
    if (!(X || Y) == (!X && !Y))
        return true;
    else
        return false;
}

if (CheckStatement(false, false) && CheckStatement(true, false) && CheckStatement(false, true) && CheckStatement(true, true))
Console.WriteLine("Да");
else
Console.WriteLine("нет");