int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);

double [,] matrix = new double [m, n];

for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
        Console.Write(Math.Round(matrix[i,j], 2)+"\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номера строки и столбца через пробел");
bool notEnd = true;
while (notEnd)
{
    string[] subs = Console.ReadLine().Split(' ');
    if (subs.Length < 2)
    {
        Console.WriteLine("Введено только одно значение. Повторите ввод");
    }
    else if (subs.Length > 2)
    {
        Console.WriteLine("Введено больше одного значения. Повторите ввод");
    }
    else if (Int32.TryParse(subs[0], out int row) && Int32.TryParse(subs[1], out int column))
    {
        if (row > 0 && row < m && column > 0 && column < n)
        {
            Console.WriteLine($"Значение элемента в строке {row} и столбце {column} равно {matrix[row-1, column-1]}");
        }
        else
        {Console.WriteLine("Такого числа в массиве нет");}
        notEnd = false;
    }
    else
    {
        Console.WriteLine("Введено не целое число. Повторите ввод");
    }
}




