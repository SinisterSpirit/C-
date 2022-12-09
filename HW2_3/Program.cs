Console.WriteLine("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 8)
{
    if (num < 6)
    { 
        Console.WriteLine("будний день ");
    }
    else
    {
        Console.WriteLine("выходной день ");
    }
}
else
{
    Console.WriteLine("несуществующий день ");
}