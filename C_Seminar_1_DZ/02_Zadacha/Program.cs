/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Ведите 1ое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ведите 2ое число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2 ){
    Console.WriteLine("Число 1 больше, чем число 2");
}
else Console.WriteLine("Число 2 больше, чем число 1");