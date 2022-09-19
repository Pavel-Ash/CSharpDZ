int size = 4;
int [,] matrix = new int [size,size];
int counter = 1;

int sign = size%2;
int lastX = 0;
int lastY = -1;

for (int l=size; l>0; l--)
{   
    if (l%2 == sign)
    {
        for (int j=lastY+1; j<size; j++)
        {
            if (matrix[lastX+1,j]!=0)
            {break;}
            matrix[lastX,j] = counter;
            counter++;
            lastY=j;
        }
        for (int i=lastX+1; i<size; i++)
        {
            if (matrix[i,lastY]!=0)
            {break;}
            matrix[i,lastY] = counter;
            counter++;
            lastX=i;
        }
    }
    else
    {
        for (int j=lastY-1; j>=0; j--)
        {
            if (matrix[lastX,j]!=0)
            {break;}
            matrix[lastX,j]=counter;
            counter++;
            lastY=j;
        }
        for (int i=lastX-1; i>=0; i--)
        {
            if (matrix[i,lastY]!=0)
            {break;}
            matrix[i,lastY]=counter;
            counter++;
            lastX=i;
        }
    }
}
Console.WriteLine();
for (int x=0; x<size; x++)
{
    for (int y=0; y<size; y++)
    {
        Console.Write(matrix[x,y]+"\t");
    }
    Console.WriteLine();
}