/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine());

int[] arr = GetArray(len);

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

Console.WriteLine("Сгенерированный массив: [{0}", String.Join(", ", arr) + "]");

int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        res++;
    }

}
Console.WriteLine("Количество четных чисел в массиве: " + res);
