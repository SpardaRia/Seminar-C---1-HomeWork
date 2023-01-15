/* Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите первое число: ");
string numberOneUser = Console.ReadLine();
int numberOne = Convert.ToInt32(numberOneUser);

Console.WriteLine("Введите второе число: ");
string numberTwoUser = Console.ReadLine();
int numberTwo = Convert.ToInt32(numberTwoUser);

int square = numberTwo * numberTwo;

if (square == numberOne)
{
    Console.WriteLine($"Число {numberOne} является квадратом число {numberTwo}");
}
else
{
    Console.WriteLine($"Число {numberOne}  не является квадратом число {numberTwo}");
}