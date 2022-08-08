/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());

double[] arr = GetArray(len);

double[] GetArray(int n)
{
    double[] arr = new double[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble();
    }
    return arr;
}

void PrintArr(double[] arr)
{
    for (int i = 0; arr.Length > i; i++)
    {
        System.Console.Write(Math.Round(arr[i], 2) + " | ");
    }
    System.Console.WriteLine();
    return;
}
Console.WriteLine();
Console.Write("Получился массив: ");
PrintArr(arr);

double min = arr[0];
double max = arr[0];

for (int i = 1; arr.Length > i; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }

    if (arr[i] < min)
    {
        min = arr[i];
    }
}
double res = max - min;

Console.WriteLine("\nMax значение массива: " + Math.Round(max, 2) + " \nMin значение массива: " + Math.Round(min, 2) + " \n\nРазница между Max и Min составляет: " + Math.Round(res, 2));
Console.WriteLine();