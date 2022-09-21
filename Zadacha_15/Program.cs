/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());

if (x <= 0 ){
    Console.WriteLine("введте цифру от 1 до 7 включительно");
}else if (x <= 5 ) {
    Console.WriteLine("не выхоной");
}else if (x <= 7) {
    Console.WriteLine("выхоной");
} else if (x >= 8) 
    Console.WriteLine("введте цифру от 1 до 7 включительно");
    