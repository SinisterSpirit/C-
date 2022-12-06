Console.WriteLine("введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"большее число: {num1} меньшее число:  {num2}");
}
else
{
    Console.WriteLine($"большее число: {num2} меньшее число:  {num1}");
}