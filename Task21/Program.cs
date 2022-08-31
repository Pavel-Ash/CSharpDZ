Console.WriteLine("Введите Х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));
result = Math.Round(result, 2);
Console.WriteLine("Результат "+Convert.ToString(result));