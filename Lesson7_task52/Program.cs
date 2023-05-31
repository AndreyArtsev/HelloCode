// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,9);
Console.Write($"{randomArray[i,j]} ");
}
Console.WriteLine();
}
}

void sredArif(int m, int n)
{
Console.Write("Среднее арифметическое каждого столбца: ");
int i,j;
Random rand = new Random();
for (j = 0; j < n; j++)
{
double sum = 0;
for (i = 0; i < m; i++)
{
sum = sum + randomArray[i,j];
}
Console.Write($"{sum/(i):F1}; ");
}
}

mas(m,n);
sredArif(m,n);