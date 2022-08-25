Console.WriteLine("Введите число:");
while (true)
{
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Пардон, но число должно быть трехзначным. Повторите ввод:");
    }
    else
    {
        int hundreds = (number - number%100);
        int tens = ((number - hundreds) - (number - hundreds)%10) / 10;
        Console.WriteLine("Result is:"+tens);
        break;
    }
}





