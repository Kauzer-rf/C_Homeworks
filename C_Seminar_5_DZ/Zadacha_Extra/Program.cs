/*
На вход подается 2 массива, отсортированные по возрастанию. Нужно их объединить в один массив, чтобы значения были по порядку.
[1, 3, 5, 7]
[2, 4, 6, 8]
-> [1, 2, 3, 4, 5, 6, 7, 8]
*/
int[] arr1 = { 1, 3, 5, 7 };
int[] arr2 = { 2, 4, 6, 8 };

int len1 = arr1.Length;
int len2 = arr2.Length;
int len3 = len1 + len2;
int[] sortedArr = new int[len3];

Console.WriteLine();
Console.WriteLine("Заданный первый массив: [{0}", String.Join(", ", arr1) + "]"); 
Console.WriteLine("Заданный второй массив: [{0}", String.Join(", ", arr2) + "]");
Console.WriteLine();

Console.Write("Объединение 2х массивов в один: ");
for (int i = 0; i < arr1.Length; i++)
{
    sortedArr[i] = arr1[i];
}

for (int i = 0; i < arr2.Length; i++)
{
    sortedArr[len1 + i] = arr2[i];
}

Console.WriteLine("[{0}", String.Join(", ", sortedArr) + "]");

for (int i = 0; i < sortedArr.Length; i++)
{
    for (int j = 0; j < sortedArr.Length - 1; j++)
    {
        if (sortedArr[j] > sortedArr[j + 1])
        {
            int num = sortedArr[j];
            sortedArr[j] = sortedArr[j + 1];
            sortedArr[j + 1] = num;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Отсортированный массив: [{0}", String.Join(", ", sortedArr) + "]");
Console.WriteLine();