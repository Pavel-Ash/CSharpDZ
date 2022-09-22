Console.WriteLine("Введите число (M)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (N)");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: {sumNatNumbers(n, m, n)}");
}
else
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n}: {sumNatNumbers(m, n, m)}");
}

int sumNatNumbers(int start, int finish, int sum)
{
    if (start != finish)
    {
        sum = sum + start + 1;
        start = start+1;
        return sumNatNumbers(start, finish, sum);
    }
    else return sum;
}

