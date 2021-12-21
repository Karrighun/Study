// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите два числа, которые хотите проверить");
int i = Convert.ToInt32 (Console.ReadLine());
int j = Convert.ToInt32 (Console.ReadLine());
if(i == j * j) Console.WriteLine($"{i} Являеется квадратом числа {j}");
 else Console.WriteLine($"{i} Не являеется квадратом числа {j}");

// OR

bool IsSquare(int x, int y)
{
    if (x == y * y) return true;
    else
        return false;
}
Console.WriteLine(IsSquare(25, 5));

//done