int m = new Random().Next(2, 5);
int n = new Random().Next(2, 5);

int [,] matrix = new int [m, n];

for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        matrix[i,j] = new Random().Next(-10, 10);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i=0; i<m; i++)
{
    int [] vector = new int [n];
    for (int j=0; j<n; j++)
    {
        vector[j] = matrix[i,j];
    }
    Array.Sort(vector);
    Array.Reverse(vector);
    for (int j=0; j<n; j++)
    {
        Console.Write(vector[j]+"\t");
        matrix[i,j] = vector[j];
    }
    Console.WriteLine(); 
}
