﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число: ");
string numberUser = Console.ReadLine();
int number = Convert.ToInt32(numberUser);

if ( number % 2 == 0)
{
    Console.WriteLine($" {number} чётное число");
}
else
{
    Console.WriteLine($" {number} нечётное число");
}