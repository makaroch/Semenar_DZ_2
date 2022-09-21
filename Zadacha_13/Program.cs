/*Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

if (x/100 != 0) {
    while ( x/1000 != 0 ) {
        x = x /10;
    }
    x = x % 10;
    Console.WriteLine(x);
} else
    Console.WriteLine("нет третьей цифры");

