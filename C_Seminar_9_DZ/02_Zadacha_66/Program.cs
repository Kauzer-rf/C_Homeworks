/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("\nВведите начальное число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите конечное число N: ");
int N = int.Parse(Console.ReadLine());

int NaturalNum(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    
    return start + NaturalNum(++start, end);
}
Console.Write($"\nСумма чисел от {M} до {N} = {NaturalNum(M, N)}");
