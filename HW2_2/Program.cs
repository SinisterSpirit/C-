Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("третьей цифры нет ");
}
else
{
    int len = 0;
    int num2 = num;
    while (num2 > 0)
    {
        num2 = num2 / 10;
        len++;
    }
    int result = num / Convert.ToInt32(Math.Pow(10, len - 3)) % 10;
    Console.WriteLine($"третья цифра числа {num} : {result} ");
}