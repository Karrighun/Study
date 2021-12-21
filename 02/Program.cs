// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите два числа, чтобы узнать какое из них больше");
int i = Convert.ToInt32 (Console.ReadLine());
int j = Convert.ToInt32 (Console.ReadLine());
if (i > j) Console.WriteLine($"{i} > {j}");
else Console.WriteLine($"{i} < {j}");

// OR

int ShowLess(int x, int y)
{
    if (x < y) return x;
    else return y;

}

int ShowBiggest(int x, int y)
{
    if (x > y) return x;
    else return y;
}

Console.WriteLine(ShowLess(111, 111));
Console.WriteLine(ShowBiggest(22132, 11113));

//done