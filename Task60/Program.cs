int l = 2;
int m = 2;
int n = 2;

int [,,] matrix = new int [l, m, n];
int[] setting = new int [l*m*n];

for (int i=0; i<l*m*n; i++)
{
    while (true)
    {
        int candidate = new Random().Next(10, 100);
        if (setting.Contains(candidate))
        {
            // Console.Write(candidate+" is skipped\t");
            continue;
        }
        else
        {
            setting[i] = candidate;
            Console.Write(setting[i]+"\t");
            break;
        }
    }
}
Console.WriteLine();
int counter = 0;
for (int i=0; i<l; i++)
{
    for (int j=0; j<m; j++)
    {
        for (int k=0; k<n; k++)
        {
            matrix[i,j,k]=setting[counter];
            counter++;
            Console.Write( $"{matrix[i,j,k]} ({i},{j},{k})" );
        }
        Console.WriteLine();
    }
}

