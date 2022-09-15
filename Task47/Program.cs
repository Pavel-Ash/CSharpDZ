Console.WriteLine("Введите число строк в массиве (m)");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов в массиве (n)");
int n = Convert.ToInt32(Console.ReadLine());

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