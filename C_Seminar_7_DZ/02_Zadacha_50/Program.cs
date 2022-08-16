/*
Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет
*/

int[,] array =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};
Console.WriteLine("Задан двумерный массив чисел:");
PrintArray(array);
Console.Write("Ведите через пробел индексы искомого элемента: ");
string[] input = Console.ReadLine().Split();


if (DoExistValue(input, array))
{
    Console.WriteLine("По данным индексам находится элемент: " + "[" + GetValue(input, array) + "]");
}
else
{
    Console.WriteLine("Такого числа нет в массиве!");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int GetValue(string[] input, int[,] numbers)
{
    int row = int.Parse(input[0]);
    int column = int.Parse(input[1]);
    int value = numbers[row, column];
    return value;
}
bool DoExistValue(string[] input, int[,] numbers)
{
    int row = int.Parse(input[0]);
    int column = int.Parse(input[1]);
    if (row < numbers.GetLength(0) && column < numbers.GetLength(1))
    {
        return true;
    }
    return false;
} 
