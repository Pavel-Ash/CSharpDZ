Console.WriteLine("Введите элементы массива, используя / в качестве разделителя элементов");
string? stroka = Console.ReadLine();
if (stroka == null || stroka.Length < 1)
{
    Console.WriteLine("Вы ничего не ввели((");
}
else
{
    string[] subs = stroka.Split('/');
    var res = from s in subs where s.Length <=3 select s;
    Console.WriteLine("Итоговый массив:");
    Console.Write("[ ");
    foreach (string s in res)
        {
            Console.Write('"'+s+'"');
            Console.Write(" ");
        }
    Console.Write("]");
}