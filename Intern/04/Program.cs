// Найти максимальное из трех чисел

int a = 10;
int b = 13;
int c = 2;
int max = a;
if (a < b) max = b;
if (b < c) max = c;
Console.WriteLine(max);

// OR

int Max(int[] array)
{
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max) max = array [i];
    }
    return max;
}

Console.WriteLine(Max(new int[]{33,44,122,}));

//done