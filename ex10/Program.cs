// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите 3-х значное число:");
int numberthreedigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"введено число: {numberthreedigit}");
int m=numberthreedigit/10;
if (numberthreedigit>999 || numberthreedigit<100) 
{
Console.WriteLine("Некорректно введено число");
}
else 
{
    Console.WriteLine($"Вторая цифра данного числа: {m % 10}");
}