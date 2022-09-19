int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);

int [,] matrix = new int [m, n];
int  [] sums = new int[m];

for (int i=0; i<m; i++)
{
    int sum = 0;
    for (int j=0; j<n; j++)
    {
        matrix[i,j] = new Random().Next(-10, 10);
        Console.Write(matrix[i,j]+"\t");
        if (j==0)
        {
            sum = matrix[i,j];
        }
        else
        {
            sum=sum+matrix[i,j];
        }
    }
    sums[i]=sum;
    // Console.Write("\t Сумма: "+sums[i]+"\t");
    Console.WriteLine();
}
Console.WriteLine();
int idx = Array.IndexOf(sums, sums.Min());
Console.WriteLine( $"Наименьшая сумма {sums[idx]} в строке номер {idx+1}" );
