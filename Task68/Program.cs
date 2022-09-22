while (true)
{
    Console.WriteLine("Введите число (M)");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число (N)");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Одно из чисел отрицательное. Повторите ввод");
    }
    else 
    {
        Console.WriteLine($"Значение функции Аккермана для {m} и {n}: {Ackermann(m, n)}");
        break;
    }
}

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    if (n==0)
    {
        return Ackermann(m-1, 1);
    }
    else
    {
        return Ackermann(m-1, (Ackermann(m, n-1)));
    } 
}
