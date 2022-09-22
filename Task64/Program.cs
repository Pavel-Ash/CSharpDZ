Console.WriteLine("Введите число (M)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число (N)");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine(NatNumbers(n, m));
}
else
{
    Console.WriteLine(NatNumbers(m, n));
}

string NatNumbers(int start, int n)
{
    if (start<=n) return $"{start} "+NatNumbers(start+1, n);
    else return String.Empty;
}
