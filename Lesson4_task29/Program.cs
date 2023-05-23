// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
Console.Write("[ ");
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 9);
    Console.Write(randomArray[i] + " ");
}
Console.Write("]");

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
