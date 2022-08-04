/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

*/ 

Console.WriteLine("Для вывода массива, требуется ввести его элементы.");
int[] ArrayElement = new int[8];

for (int i = 0; i < 8; i++)
{
    Console.Write("Введите элемент c индексом " + i + ": ");
    ArrayElement[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Получился массив: [{0}", String.Join(",", ArrayElement) + "]");
