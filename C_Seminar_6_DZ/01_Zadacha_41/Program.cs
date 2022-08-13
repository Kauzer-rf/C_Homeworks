/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
Console.Write("Сколько целых чисел Вы хотите ввести? - ");
int m = int.Parse(Console.ReadLine());
int[] numbers = new int[m];
int count = 0;

for (int i = 1; i <= m; i++)
{
    Console.Write("Введите целое число: ");
    numbers[i - 1] = int.Parse(Console.ReadLine());
        if (numbers[i - 1] > 0)
        {
            count++;
        }
}

Console.WriteLine("\nВы ввели следующие числа: [{0} ", String.Join(", ", numbers) + "]");
Console.WriteLine($"\nИз них количество чисел >0: " + count);
Console.WriteLine();



