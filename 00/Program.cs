// Вывести квадрат числа

Console.WriteLine("Для продолжения, введите число, которое хотите возвести в квадрат");
int i = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine($"{i} * {i} = {i * i}");

// OR

int Square(int x)
{
    return x * x;
}
Console.WriteLine(Square(2));

//done