/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int number = new Random().Next(10, 99999);
Console.WriteLine($"случайное число - {number}");
int res = -1;
while (number > 99)
{
    res = number % 10;
    number = number / 10;
}
if (res > 0)
{
    Console.WriteLine($"третья цифра={res}");
}
else Console.WriteLine("здесь нет третьей цифры");