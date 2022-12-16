while (true)
{
    Console.WriteLine("для выхода из программы нажмите 0");
    Console.WriteLine("для для исполнения задачи 25 нажмите 1");
    Console.WriteLine("для для исполнения задачи 27 нажмите 2");
    Console.WriteLine("для для исполнения задачи 29 нажмите 3");
    string num = Console.ReadLine();
    if (num == "0")
    {
        Console.WriteLine("программы прервана");
        break;
    }
    if (num == "1")
    {
        task25();
    }
    if (num == "2")
    {
        task27();
    }
    if (num == "3")
    {
        task29();
    }
}

//задача25
void task25()
{
    int numA = ReadInt("введите число A: ");
    int numB = ReadInt("введите число B: ");
    int result = numA;
    for (int i = 1; i < numB; i++)
    {
        result = result * numA;
    }
    Console.WriteLine($"{numA} в степени {numB} равно: {result}");
}

//задача27
void task27()
{
    Console.WriteLine("введите число");
    string num1 = Console.ReadLine();
    int len = num1.Length;
    int result = 0;
    int num2 = Convert.ToInt32(num1);
    for (int i = 1; i <= len; i++)
    {
        result = result + num2 / Convert.ToInt32(Math.Pow(10, i - 1)) % 10;
    }
    Console.WriteLine($"сумма цифр числа {num2} равна: {result}");
}

//задача 29
void task29()
{
    Random rnd = new Random();
    int[] array = new int[8];
    Console.Write("[");
    for (int i = 0; i < 8; i++)
    {
        array[i] = rnd.Next(0, 100);
        Console.Write(array[i]);
        if (i < 7)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}