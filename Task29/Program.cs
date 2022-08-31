int [] Arr (int size)
{
    int [] result = new int [size];
    for (int i=0; i<size; i++)
    {
        result[i] = new Random().Next(0, 50);
    }
    return result;
}

void PtintArray(int[] array)
{
int count = array.Length;
Console.Write("[");
for (int i = 0; i < count; i++)
{
    Console.Write(array[i]);
    if (i < count-1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");
}

PtintArray(Arr(8));

