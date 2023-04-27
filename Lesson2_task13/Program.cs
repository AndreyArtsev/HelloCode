int Prompt(string msg)
{

System.Console.Write("msg ");
return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");

int fnumber(int number)
{
while (number > 999)
{
number /= 10;
}
return number % 10;
}

bool check(int number)
{
if (number < 100)
return false;
else return true;
}

if (check(number) != true)
System.Console.WriteLine("Третьей цифры нет");
else
System.Console.WriteLine("Третья цифра числа " + number + " является " + fnumber(number));
