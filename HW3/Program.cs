Console.WriteLine("введите число: ");
int num = int.Parse(Console.ReadLine());

int test = num % 2;

if (test != 0)
{
    Console.WriteLine($"{num} не чётное");
}
else
{
    Console.WriteLine($"{num} чётное");
}