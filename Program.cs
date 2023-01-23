Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int num2 = num % 10;
if (num > 99)
{
    num = num / 10;
    Console.WriteLine(num2);
}
else
if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}