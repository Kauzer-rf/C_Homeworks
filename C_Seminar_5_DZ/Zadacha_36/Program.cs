/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

Console.WriteLine("Сгенерированный массив: [{0}", String.Join(", ", arr) + "]");

int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        res += arr[i];
    }

}
Console.WriteLine("Сумма элементов с нечетными индексами: " + res);