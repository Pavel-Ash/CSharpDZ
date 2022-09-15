int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);

int [,] matrix = new int [m, n];

for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        matrix[i,j] = new Random().Next(0, 10);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое каждого столбца:");
for (int j=0; j<n; j++)
{
    int sum = 0;
    for (int i=0; i<m; i++)
    {
        sum = sum+matrix[i,j];
    }
    Console.Write(Math.Round(Convert.ToDouble(sum)/m,3)+"\t");
}