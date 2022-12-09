Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 | num > 999)
{
    Console.WriteLine("Это не трёхзначное число, программа сломалась: ");
}
else
{
    int result = (num/10)%10;
    Console.WriteLine($"вторая цифра числа {num} : {result} ");
}