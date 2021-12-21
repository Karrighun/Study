// Выяснить является ли число чётным

Console.WriteLine("Введите число, чтобы узнать являеется ли оно четным");
int i = Convert.ToInt32 (Console.ReadLine());
int number = 0;
if(number == i % 2) Console.WriteLine($"{i} = четное число");
else Console.WriteLine($"{i} = нечетное число");

// OR

bool IsEven(int x)
{
    if(x % 2 == 0) return true;
    return false;
}

Console.WriteLine(IsEven(10));
//done