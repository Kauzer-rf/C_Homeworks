﻿/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
int[,] array = 
{
    {1, 4, 7, 2,},
    {5, 9, 2, 3,},
    {8, 4, 2, 4,}
};

Console.WriteLine("\nЗадан следующий массив: ");
PrintArray(array);

SortedArray(array);
Console.WriteLine("\nУпорядоченный по убыванию (построчно) массив: ");
PrintArray(array);

void PrintArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void SortedArray(int[,]array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
        
      }
    }
  }
}