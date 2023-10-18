// Задача №7. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числпа.
// 456-> 6
// 782-> 2
// 918-> 8


Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <=999)
{
int digitLast = number % 10;
System.Console.WriteLine(digitLast);
}
else
{
    System.Console.WriteLine("Введите трехзначное число");
}