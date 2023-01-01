Random rnd = new Random();

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("нажмите enter чтобы продолжить: ");
    string choose = Console.ReadLine();
    Console.WriteLine("для выхода из программы нажмите 0");
    Console.WriteLine("для исполнения задачи 54 введите: 1");
    Console.WriteLine("для исполнения задачи 56 введите: 2");
    Console.WriteLine("для исполнения задачи 58 введите: 3");
    Console.WriteLine("для исполнения задачи 60 введите: 4");
    Console.WriteLine("для исполнения задачи 62 введите: 5");
    choose = Console.ReadLine();
    if (choose == "0")
    {
        Console.WriteLine("программы прервана");
        break;
    }
    if (choose == "1")
    {
        task54();
    }
    if (choose == "2")
    {
        task56();
    }
    if (choose == "3")
    {
        task58();
    }
    if (choose == "4")
    {
        task60();
    }
    if (choose == "5")
    {
        task62();
    }
}


void task54()
{
    int[][] array = createArray(3, 4);
    wrArr(array);
    array = sortAr(array);
    wrArr(array);
}

void task56()
{
    int[][] array = createArray(4, 4);
    wrArr(array);
}

void task58()
{

}

void task60()
{

}


void task62()
{

}


int[][] sortAr(int[][] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(1) - 1; k++)
            {
                if (mass[i][k] < mass[i][k + 1])
                {
                    int temp = mass[i][k + 1];
                    mass[i][k + 1] = mass[i][k];
                    mass[i][k] = temp;
                }
            }
        }
    }
    return mass;
}


int[][] createArray(int len1, int len2)
{
    int[][] mass = new int[len1][];
    {
        for (int i = 0; i < len1; i++)
        {
            mass[i] = new int[len2];
            for (int j = 0; j < len2; j++)
            {
                mass[i][j] = rnd.Next(0, 10);
            }
        }
    }
    return mass;
}

void wrArr(int[][] mass)
{
    int len1 = mass.Length;
    int len2 = mass[0].Length;
    for (int i = 0; i < len1; i++)
    {
        Console.Write("[");
        for (int j = 0; j < len2; j++)
        {
            Console.Write(mass[i][j]);
            if (j < len2 - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
}


int readInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}