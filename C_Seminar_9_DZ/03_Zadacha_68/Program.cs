﻿/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("\nВведите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"\nA(m,n) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return Akkerman(m, n);
}