Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=x; i++)
{
    Console.Write(Convert.ToString(Math.Pow(i, 3)));
    if (i != x)
    {
        Console.Write(", ");
    }
}

