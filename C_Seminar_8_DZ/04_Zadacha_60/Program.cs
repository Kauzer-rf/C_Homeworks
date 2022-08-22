/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)
*/
int[,,] rnd3Darray = new int[3,3,3];
GetArray(rnd3Darray);
PrintArray(rnd3Darray);


int[,,] GetArray(int[,,] array)
{
    int[,,] array2 = new int[array.GetLength(0), array.GetLength(1), array.GetLength(2)];
    int item = 10;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = item;
                item++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine($"\nПлоскость {k} : ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"[{i},{j},{k}] - {array[i, j, k]}" + "\t");
            }
            Console.WriteLine();
        }
    }
}