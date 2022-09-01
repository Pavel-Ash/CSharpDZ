Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());

int [] array= new int [n];
int oddSum = 0;


for (int i=0; i<n; i++)
{
    array[i] = new Random().Next(1, 9);
    if (i%2==0)
    {
        oddSum = oddSum+array[i];
    }
}

Console.WriteLine(String.Join(";", array));
Console.WriteLine($"Сумма нечетных элементов: {oddSum}");