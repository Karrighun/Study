// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int GetBiggestNumber(int number)
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;
    if (firstNumber > secondNumber)
        return firstNumber;
    else
        return secondNumber;
}
Console.WriteLine(GetBiggestNumber(78));

//done