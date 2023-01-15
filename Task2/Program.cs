/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введи первое число: ");
string numberOneUser = Console.ReadLine();
int numberOne = Convert.ToInt32(numberOneUser);

Console.WriteLine("Введите второе число: ");
string numberTwoUser = Console.ReadLine();
int numberTwo = Convert.ToInt32(numberTwoUser);

if (numberOne > numberTwo)
{
    Console.WriteLine($"Число {numberOne} больше {numberTwo}");
}
if (numberTwo > numberOne)
{
    Console.WriteLine($"Число {numberTwo} больше {numberOne}");
}