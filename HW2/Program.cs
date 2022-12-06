Console.WriteLine("введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите третие число: ");
int num3 = int.Parse(Console.ReadLine());
int max = num1;

if (num2 > num1 && num2 > num3)
{
    max = num2;
}
if (num3 > num2 && num3 > num1)
{
    max = num3;
}

Console.WriteLine($"наибольшее число: {max}");