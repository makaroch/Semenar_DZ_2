﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1  */

int x = new Random().Next(100, 1000);
Console.WriteLine(x);
x = x % 100;
x = x / 10; // x - int поэтому у нас дробной части нет, остаётся только целое число
Console.WriteLine(x);  