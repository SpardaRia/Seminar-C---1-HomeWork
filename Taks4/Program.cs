﻿/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введи первое число: ");
string numberOneUser = Console.ReadLine();
int numberOne = Convert.ToInt32(numberOneUser);

Console.WriteLine("Введите второе число: ");
string numberTwoUser = Console.ReadLine();
int numberTwo = Convert.ToInt32(numberTwoUser);

Console.WriteLine("Введите трертье число: ");
string numberThreeUser = Console.ReadLine();
int numberThree = Convert.ToInt32(numberThreeUser);

if (numberOne > numberTwo)
{
if ( numberOne > numberThree)
{
    Console.WriteLine($"Наибольшее число: {numberOne}");
} 
else
{
    int max = numberThree;
    Console.WriteLine($"Наибольшее число: {numberThree}");
}
}
else if (numberTwo > numberThree)
{
    int max = numberTwo;
    Console.WriteLine($"Наибольшее число: {numberTwo}");
}
else 
{
    int max = numberThree;
    Console.WriteLine($"Наибольшее число: {numberThree}");
}