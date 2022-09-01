Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());

double [] array= new double [n];
double maximum = 0;
double minimum = 10;


for (int i=0; i<n; i++)
{
    array[i] = new Random().NextDouble()*10;
    if (array[i]>maximum)
    {
        maximum = array[i];
    }
    else
    if (array[i]< minimum)
    {
        minimum = array[i];
    }
}

Console.WriteLine(String.Join(";", array));
Console.WriteLine($"Разницу между максимальным и минимальным элементами массива: {maximum-minimum}");
