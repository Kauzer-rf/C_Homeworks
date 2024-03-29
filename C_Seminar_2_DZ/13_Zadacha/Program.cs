﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите 3х значное число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.Write("Число не является 3х значным!");
}
else if (num > 999)
{
    Console.Write("Число не является 3х значным!");
}
else
{
    int digit3 = num % 10;
    Console.WriteLine("Третья цифра вашего числа : " + digit3);
}

/* Решение с циклом

{
    Console.Write("Число не является 3х значным");
}
else
{
    while (num > 999)
    {
        num /= 10; // num = num / 10
    }
    num = num % 10;
    Console.WriteLine("Третья цифра вашего числа : " + num);
}
*/