// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Random3dArray(int field, int rows, int columns) // создаем 3х мерный массив
{
    int[,,] newArray = new int[field, rows, columns]; 
    for (int i = 0; i < field; i++) // прохождение по строкам 
    {
        for (int j = 0; j < rows; j++) // прохождение по столбцам 
        {
            for (int k = 0; k < columns; k++) { newArray[i, j, k] = i + j + k; }
        }
    }
    return newArray;
}
void Show3dArray(int[,,] array) // показываем массив 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ")" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите количество полей: "); 
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну строк: "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество солбцов: "); 
int l = Convert.ToInt32(Console.ReadLine());
int[,,] array = Random3dArray(m, n, l);
Show3dArray(array);