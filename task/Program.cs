﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
int number = new Random().Next(100, 999);
int res = ((number % 10 - number % 100) / 10) * -1;
Console.WriteLine($"случайное число:{number},второе число:{res}");