Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int y = Convert.ToInt32(Console.ReadLine());

string Power (int x, int y)
{
    return Convert.ToString(Math.Pow(x, y));
}

Console.WriteLine("Получилось "+Power(x, y));