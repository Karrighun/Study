// Показать четные числа от 1 до N

void ShowEven(int N)
{
    for (int i = 1; i <= N; i++) 
    {
    if(i % 2 == 0)
    Console.WriteLine(i);
    }
}
ShowEven(100);

//done