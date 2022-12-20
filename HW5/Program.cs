Random rnd = new Random();
int lenM = 10;

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("нажмите enter чтобы продолжить: ");
    string choose = Console.ReadLine();
    Console.WriteLine("для выхода из программы нажмите 0");
    Console.WriteLine("для исполнения задачи 34 введите: 1");
    Console.WriteLine("для исполнения задачи 36 введите: 2");
    Console.WriteLine("для исполнения задачи 38 введите: 3");
    Console.WriteLine("для изменение длинны массива в задачах (стандартоно 10) введите: len");
    choose = Console.ReadLine();
    if (choose == "0")
    {
        Console.WriteLine("программы прервана");
        break;
    }
    if (choose == "1")
    {
        task34();
    }
    if (choose == "2")
    {
        task36();
    }
    if (choose == "3")
    {
        task38();
    }
    if (choose == "len")
    {
        lenM = ReadInt("введите желаемую длинну масива: ");
    }
}
void task34()
{
    int[] array = createArray("трёхзначное");
    WrArr(array);
    int count = 0;
    for (int i = 0; i < lenM; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"количество чётных чисел: {count}");
    

}

void task36()
{
    int[] array = createArray("вещественное");
    WrArr(array);
    int sum = 0;
    for (int i = 1; i < lenM; i+=2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"сумма чисел на нечётных позициях массива: {sum}");
}

void task38()
{
    int[] array = createArray("вещественное");
    WrArr(array);
    int max = searchElemnt("max",array);
    int min = searchElemnt("min",array);
    int razn = max - min;
    Console.WriteLine($"разница между максимальным и минимальным элементов массива: {razn}");
}

int[] createArray(string razryad)
{
    int[] mass = new int[lenM];
    if (razryad == "трёхзначное")
    {
        for (int i = 0; i < lenM; i++)
        {
            mass[i] = rnd.Next(100, 999);
        }
    }
    else
    {
        for (int i = 0; i < lenM; i++)
        {
            mass[i] = rnd.Next(-100, 100);
        }
    }
    return mass;
    

}

void WrArr(int[] mass)
{
    Console.Write("[");
    for (int i = 0; i < lenM; i++)
    {
        Console.Write(mass[i]);
        if (i < lenM - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int searchElemnt(string searchSetup,int[] mass)
{
    int count = mass[0];
    if (searchSetup == "min")
    {
        for (int i = 0; i < lenM; i++)
        {
            if (mass[i] < count)
            {
                count = mass[i];
            }
        }
    }
    if (searchSetup == "max")
    {
{
        for (int i = 0; i < lenM; i++)
        {
            if (mass[i] > count)
            {
                count = mass[i];
            }
        }
    }
    }
    return count;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}