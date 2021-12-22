// Собрать строку с числами от a до b, a ≤ b

string NumbersFor(int a, int b)
{
 string result = String.Empty;
     for (int i = a; i <= b; i++)
      {
    result += $"{i} ";
      }
 return result;
}
Console.WriteLine(NumbersFor(1, 10));

string NumbersRec(int a, int b)
{
 if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
 else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));

// Собрать строку с числами от a до b, a ≥ b

string NumbersFor(int a, int b)
{
 string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
    result += $"{i} ";
    }
 return result;
}
Console.WriteLine(NumbersFor(10, 1));

string NumbersRec(int a, int b)
{
 if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
 else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 10));

// Сумма чисел от 1 до n
int SumFor(int n)
{
 int result = 0;
 for (int i = 1; i <= n; i++) result += i;
 return result;
}
Console.WriteLine(SumFor(10));

int SumRec(int n)
{
 if (n == 0) return 0;
 else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(1));

// Произведение чисел от 1 до n
int FactorialFor(int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) result *= i;
    return result;
}
Console.WriteLine(FactorialFor(10));

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialRec(10));

// Вычислить a^n
int PowerFor(int a, int n)
{    
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
Console.WriteLine(PowerFor(4, 4));

int PowerRec(int a, int n)
{ 
 if (n == 0) return 1;
 else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(4, 4));

// Перебор слов
char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }        
    }
}

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[10]);

// Работа с дирикторией
String adress = "C:/Users/danil/Desktop/Программирование GeekBrains/C#/Intern/Recursion";
DirectoryInfo di = new DirectoryInfo(adress);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for(int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string adress, string indent = "")
{
 DirectoryInfo catalogs = new DirectoryInfo(adress);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
string adress = @"C:\Users\danil\Desktop\Программирование GeekBrains\C#";
CatalogInfo(adress);

// Игра в пирамидки 
void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}
Towers();