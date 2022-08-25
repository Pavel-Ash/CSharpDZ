Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 2)
{
    Console.WriteLine("Показать нечего((");
}
else
{
    int output = 2;
    while (output < number)
    {
        if ((output+2) < number)
        {Console.Write(Convert.ToString(output)+',');}
        else
        {Console.Write(Convert.ToString(output));}
      output=output+2;
    }
}
