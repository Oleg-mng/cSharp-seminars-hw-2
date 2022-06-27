// Задача 13: Напишите программу, которая выводит третью 
//цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int numberthreedigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"введено число: {numberthreedigit}");
if (numberthreedigit <= 99 && numberthreedigit >= -99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра данного числа: {numberthreedigit % 10}");
}