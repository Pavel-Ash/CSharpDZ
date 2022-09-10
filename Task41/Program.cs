Console.WriteLine("Введите ваши числа через запятую и пробел");
string? stroka = Console.ReadLine();
if (stroka == null || stroka.Length < 1)
{
    Console.WriteLine("Вы ничего не ввели((");
}
else
{
    char[] separators = new char[] { ' ', ',' };
    string[] subs = stroka.Split(separators, StringSplitOptions.RemoveEmptyEntries);

    int posCounter = 0;
    foreach (var sub in subs)
    {
        if (Convert.ToInt32(sub) > 0)
        {
            posCounter++;
        }
    }
    Console.WriteLine($"Количество положительных чисел в строке: {posCounter}");
}




