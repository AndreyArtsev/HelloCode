// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длинна которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Сколько элементов Вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
int length = 3;
int position = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= length)
    {
        arrayStrings[position] = element;
        position++;
    }
}
Console.WriteLine();
PrintArray(arrayStrings);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
