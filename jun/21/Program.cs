// Программа проверяет пятизначное число на палиндромом.

bool IsPalendrom(int number)
{
    string num_str = Convert.ToString(number);
    int length = num_str.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (num_str[i] != num_str[length - i - 1]) return false;
    }
    return true;
}

Console.WriteLine(IsPalendrom(12));