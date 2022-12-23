Random rnd = new Random();
int lenM = 0;

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("нажмите enter чтобы продолжить: ");
    string choose = Console.ReadLine();
    Console.WriteLine("для выхода из программы нажмите 0");
    Console.WriteLine("для исполнения задачи 41 введите: 1");
    Console.WriteLine("для исполнения задачи 42 введите: 2");
    choose = Console.ReadLine();
    if (choose == "0")
    {
        Console.WriteLine("программы прервана");
        break;
    }
    if (choose == "1")
    {
        task41();
    }
    if (choose == "2")
    {
        task42();
    }

}

void task41()
{
    lenM = ReadInt("введите желаемую длинну масива: ");
    int[] array = CreateArray();
    int result = SearchElArray(array, 0);
    WrArr(array);
    Console.WriteLine($"количество чисел больше 0: {result}");
}

void task42()
{
    Console.WriteLine("задайте коэффеценты для 2х функций: ");
    Console.WriteLine("y = k1 * x + b1      y = k2 * x + b2");
    int k1 = ReadInt($"ввдите коэффецент k1: ");
    int b1 = ReadInt($"ввдите коэффецент b1: ");
    int k2 = ReadInt($"ввдите коэффецент k2: ");
    int b2 = ReadInt($"ввдите коэффецент b2: ");

    if (k1 != k2)
    {
        float xper = TochPer(k1, k2, b1, b2);
        float yper = k1 * xper + b1;
        Console.Write("точка пересечения {");
        Console.Write($"{xper},{yper}");
        Console.WriteLine("}");
    }
    else
    {
        Console.WriteLine("прямые параллельны");
    }

}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray()
{
    int[] mass = new int[lenM];
    for (int i = 0; i < lenM; i++)
    {
        mass[i] = ReadInt($"ввдите число №{i + 1}: ");
    }
    return mass;
}

float TochPer(int kof1, int kof2, int d1, int d2)
{
    float kof = kof1 - kof2;
    float d = d2 - d1;
    float xisk = d / kof;
    return xisk;
}

int SearchElArray(int[] mass, int border)
{
    int count = 0;
    for (int i = 0; i < lenM; i++)
    {
        if (mass[i] > border)
        {
            count++;
        }
    }
    return count;
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