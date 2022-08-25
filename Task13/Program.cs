Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 )
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int result = number%10;
    number = (number-result) / 10;
    while (number > 100)
    {
        result = number%10;
        number = (number-result) / 10;
    }
    Console.WriteLine(result);
}


