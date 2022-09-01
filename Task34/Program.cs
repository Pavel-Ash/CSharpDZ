Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array= new int [n];
int Counter = 0;


for (int i=0; i<n; i++)
{
    array[i] = new Random().Next(100, 999);
    if (array[i]%2==0)
    {
        Counter++;
    }
}

Console.WriteLine(String.Join(";", array));
Console.WriteLine($"Четных чисел в массиве: {Counter} ");
