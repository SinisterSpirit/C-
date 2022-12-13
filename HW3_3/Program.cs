Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{ 
    int result = 0;
    result = i*i*i;
    Console.Write(result);
    Console.Write(" ");
}