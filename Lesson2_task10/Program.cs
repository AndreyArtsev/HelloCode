int Prompt(string msg)
{
    Console.Write("msg ");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите трехзначное число");
if (number >= 100 && number < 1000)
{
    int mid = number / 10 % 10;
    System.Console.WriteLine("Вторая цифра числа " + number + " является " + mid);
}
else
    Console.WriteLine("Это число не трехзначное");