Random rnd = new Random();
int lenM1 = 3;
int lenM2 = 4;

while (true)
{
    lenM1 = 3;
    lenM2 = 4;
    Console.WriteLine("");
    Console.WriteLine("нажмите enter чтобы продолжить: ");
    string choose = Console.ReadLine();
    Console.WriteLine("для выхода из программы нажмите 0");
    Console.WriteLine("для исполнения задачи 47 введите: 1");
    Console.WriteLine("для исполнения задачи 50 введите: 2");
    Console.WriteLine("для исполнения задачи 52 введите: 3");
    choose = Console.ReadLine();
    if (choose == "0")
    {
        Console.WriteLine("программы прервана");
        break;
    }
    if (choose == "1")
    {
        task47();
    }
    if (choose == "2")
    {
        task50();
    }
    if (choose == "3")
    {
        task52();
    }
}


void task47()
{
    lenM1 = ReadInt("введите количество массивов: ");
    lenM2 = ReadInt("введите длинну массивов: ");
    int[][] array = createArray(1);
    WrArr(array);
}

void task50()
{
    int[][] array = createArray(2);
    WrArr(array);
    int st = ReadInt("выберите столбик: ");
    int ln = ReadInt("выберите строку: ");
    if (ln <=lenM1 & st<=lenM2 & ln >= 0 & st >= 0)
    {
        Console.WriteLine(array[ln-1][st-1]);
    }
    else
    {
        Console.WriteLine("такого элемента нет");
    }
}

void task52()
{
    int[][] array = createArray(2);
    WrArr(array);
    for (int i = 0; i < lenM1; i++)
    {
        float sredAr = sreAr(array[i]);
        Console.WriteLine($"среднее арифметическое {i+1} строки равно: {sredAr}");
    }
}

float sreAr(int[] mass)
{
    float sred = 0;
    for (int i = 0; i < lenM2; i++)
    {
        sred += mass[i];
    }
    sred = sred / lenM2;
    return sred;
}
int[][] createArray(int scenari)
{
    if (scenari == 1)
    {
        int[][] mass = new int[lenM1][];
        {
            for (int i = 0; i < lenM1; i++)
            {
                mass[i] = new int[lenM2];
                for (int j = 0; j < lenM2; j++)
                {
                    mass[i][j] = rnd.Next(-100, 100);
                }
            }
        }
        return mass;
    }
    else
    {
        int[][] mass = new int[lenM1][];
        {
            for (int i = 0; i < lenM1; i++)
            {
                mass[i] = new int[lenM2];
                for (int j = 0; j < lenM2; j++)
                {
                    mass[i][j] = rnd.Next(0, 10);
                }
            }
        }
        return mass;
    }
    

}

void WrArr(int[][] mass)
{
    for (int i = 0; i < lenM1; i++)
    {
        Console.Write("[");
        for (int j = 0; j < lenM2; j++)
        {
            Console.Write(mass[i][j]);
            if (j < lenM2 - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
    }
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}