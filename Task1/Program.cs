/* апишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
на само себя).

Например:
4 -> 16
-3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число: ");
string number = Console.ReadLine(); // 22-> "22" Всегда возвращает строчку/текст
int numbers = Convert.ToInt32(number); // 22 Переводит в числовой формат

int result = numbers * numbers;

Console.WriteLine($"квадрат числа {number} = {result}");

// Другие варианты записи
Console.WriteLine("квадрат числа "+ number + " = " + result);
Console.WriteLine("квадрат числа {0} = {1}", number, result); 