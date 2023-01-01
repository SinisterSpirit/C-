Random rnd = new Random();
int count = 0;
int count2 = 0;
int result = 0;
start();
void start()
{
    Console.WriteLine("");
    Console.WriteLine("нажмите enter чтобы продолжить: ");
    string choose = Console.ReadLine();
    Console.WriteLine("для выхода из программы нажмите 0");
    Console.WriteLine("для исполнения задачи 64 введите: 1");
    Console.WriteLine("для исполнения задачи 66 введите: 2");
    Console.WriteLine("для исполнения задачи 68 введите: 3");
    choose = Console.ReadLine();
    if (choose == "0")
    {
        Console.WriteLine("программы прервана");
    }
    if (choose == "1")
    {
        task64();
    }
    if (choose == "2")
    {
        task66();
    }
    if (choose == "3")
    {
        task68();
    }
    if (choose != "0")
    {
        start();
    }

}


void task64()
{
    count = ReadInt("введите число N: ");
    if (count >= 1)
    {
        printNel();
    }
    else
    {
        task64();
    }
}

void task66()
{
    result = 0;
    count = ReadInt("введите число N: ");
    count2 = ReadInt("введите число M: ");
    if (count <= count2)
    {
        printSum();
    }
    else
    {
        task66();
    }
}

void task68()
{
    result = 0;
    count = ReadInt("введите число N: ");
    count2 = ReadInt("введите число M: ");
    result = ack(count2, count);
    Console.WriteLine(result);
}

int ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return ack (m - 1, 1);
  else return ack(m - 1, ack(m, n - 1));
}

void printNel()
{
    if (count != 0)
    {
        Console.Write($"{count} ");
        count--;
        printNel();
    }
    else
    {
        start();
    }
}

void printSum()
{
    if (count != count2 + 1)
    {
        result += count;
        count++;
        printSum();
    }
    else
    {
        Console.WriteLine(result);
        start();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
