// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int Quarter(int x, int y)
{
    if (x < 0 && y < 0) return 4;
    if (x < 0 && y > 0) return 1;
    if (x > 0 && y > 0) return 2;
    if (x > 0 && y < 0) return 3;
    return 0;
}

Console.WriteLine(Quarter(10, -1));