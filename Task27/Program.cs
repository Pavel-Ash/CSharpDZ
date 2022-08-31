Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

string Counter (int x)
{
    int sum = 0;
    while (x>0)
    {
        sum = sum + x%10;
        x = (x - x%10) / 10;
    }
    return Convert.ToString(sum);
}

Console.WriteLine("Получилось "+Counter(x));
