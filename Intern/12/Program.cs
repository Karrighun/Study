// Удалить вторую цифру трёхзначного числа
void DeleteSecondSymbol(int number)
{
    Console.WriteLine((number / 100) * 10 + (number % 10));
}
DeleteSecondSymbol(543);

//done