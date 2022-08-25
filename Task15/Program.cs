Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Это не день недели (1-7)");
}
else
{
    if (number > 5)
    {Console.WriteLine("да");}
    else
    {Console.WriteLine("нет");}
}
