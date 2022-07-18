/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/


while (true)
{
    Console.Write("Введите пятизначное число: ");
    int number = int.Parse(Console.ReadLine());

    if (number <= 99999 && number >= 10000) // или <100000 и >9999
    {
        if (number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10)
        {
            Console.WriteLine("Число " + number + " ЯВЛЯЕТСЯ палиндромом.");
        }
        else
        {
            Console.WriteLine("Число " + number + " НЕ является палиндромом.");
        }
        break;
    }
    else
        Console.WriteLine("Ошибка. Неправильное число.");
}
