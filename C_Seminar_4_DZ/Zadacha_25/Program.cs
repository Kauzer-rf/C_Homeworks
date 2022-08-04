/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

Console.Write("Ведите число A: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Ведите число B: ");
int b = int.Parse(Console.ReadLine());

if (b >= 1)
{
    
Console.WriteLine("Число " + a + " в степени " + b + " = " + Math.Round(Math.Pow(a, b), 3));

}
else
{
    Console.WriteLine("Введено не корреткное число B");
}


