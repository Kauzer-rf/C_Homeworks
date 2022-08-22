/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
int[,] array = new int[4, 4];
int[,] array2 = new int[4, 4];

CreateArray(array);
CreateArray(array2);
Console.WriteLine("\nСгенерирована первая матрица: ");
PrintArray(array);
Console.WriteLine("\nСгенерирована вторая матрица: ");
PrintArray(array2);

MultiArray(array, array2);
Console.WriteLine("\nПроизведение матриц записано в массив: ");
PrintArray(MultiArray(array, array2));

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}
int[,] MultiArray(int[,] array1, int[,] array2)
{
    int[,] multiplyArray = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            multiplyArray[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return multiplyArray;
}