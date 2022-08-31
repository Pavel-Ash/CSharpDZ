Console.WriteLine("Введите пятизначное число");
string x = Console.ReadLine();
int y = Convert.ToInt32(x);
if (x.Length != 5)
{
    Console.WriteLine("Мы так не договаривались. Число не пятизначное");
}
else
{
    if (x[0] == x[4] && x[1] == x[3])
    {
        Console.WriteLine("Опа. Да это ж полиндром");
    }
    else
    {
        Console.WriteLine("На полиндром не похоже");
    }
}

