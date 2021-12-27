// Найти расстояние между точками в пространстве 2D/3D

double GetDistance(int dim, int[] point_1, int[] point_2)
{
    double sum = 0;
    for (int i = 0; i < dim; i++)
    {
        sum += Math.Pow(point_1[i] - point_2[i], 2);
    }
    return Math.Sqrt(sum);
}

Console.WriteLine(GetDistance(3, new int[] { 6, 10, 100 }, new int[] { 54, 5, 1 }));
