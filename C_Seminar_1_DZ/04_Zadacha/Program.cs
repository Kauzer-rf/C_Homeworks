/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Ведите 1ое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ведите 2ое число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Ведите 3eе число: ");
int num3 = int.Parse(Console.ReadLine());
int max = 0;

if (num1 > num2)
max = num1;
else max = num2;

if (max > num3)
Console.WriteLine($"Максимальное число: {max} ");
else 
Console.WriteLine($"Максимальное число: {num3}");
    
