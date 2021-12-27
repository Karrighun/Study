// Задать номер четверти, показать диапазоны для возможных координат

string QuaterRange(int quarter)
{
    string[] range = new string[] { "X in (-inf, 0); Y in (0, +inf)", "X in (0, +inf); Y in (0, +inf)", "X in (0, +inf); Y in (-inf, 0)", "X in (-inf, 0); Y in (-inf, 0)" };
    return range[quarter - 1];
}
Console.WriteLine(QuaterRange(1));