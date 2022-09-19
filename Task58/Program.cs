int l = new Random().Next(2, 5);    // rows of matrix A
int m = new Random().Next(2, 5);    // columns of matrix A and rows of matrix B
int n = new Random().Next(2, 5);    // columns of matrix B

int [,] matrixA = new int [l, m];
int [,] matrixB = new int [m, n];
int [,] matrixAB = new int [l, n];

for (int i=0; i<l; i++)
{
    for (int j=0; j<m; j++)
    {
        matrixA[i,j] = new Random().Next(0, 5);
        Console.Write(matrixA[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        matrixB[i,j] = new Random().Next(0, 5);
        Console.Write(matrixB[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i=0; i<l; i++)
{
    for (int j=0; j<n; j++)
    {
        for (int k=0; k<m; k++)
        {
            matrixAB[i,j] = matrixAB[i,j]+matrixA[i,k]*matrixB[k,j];
        }
        Console.Write(matrixAB[i,j]+"\t");
    }
    Console.WriteLine();
}