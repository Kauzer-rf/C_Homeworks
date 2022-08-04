/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/ 
Console.Write("Введите число, содержащее от 2 цифр и более: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма цифр данного числа = " + GetSum(num));

int GetSum(int number)
{
    int Sum = 0;
    while (number > 0)
    {
        Sum = Sum + number % 10;
        number = number / 10;
    }
    return Sum;

}