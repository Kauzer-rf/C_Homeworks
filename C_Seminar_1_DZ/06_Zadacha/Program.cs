/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Ведите число: ");
double num = double.Parse(Console.ReadLine());
if (num % 2 == 0)
Console.WriteLine($"Число: {num} четное.");
else 
Console.WriteLine($"Число: {num} не четное.");