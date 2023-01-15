/* Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число");
string numberUser = Console.ReadLine();
int number = Convert.ToInt32(numberUser);

int square = number * number;
Console.WriteLine(square);