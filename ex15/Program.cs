// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели:  (от 1 до 7)");
int numberdayofweek = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сейчас проверим является ли данный день выходным");
if (numberdayofweek <= 0 || numberdayofweek > 7)
{
    Console.WriteLine("введенный номер некорректен");
}
else
{
    if (numberdayofweek == 6 || numberdayofweek == 7) Console.WriteLine("да. это выходной");
    else
    {
        Console.WriteLine("нет. это рабочий день");
    }
}