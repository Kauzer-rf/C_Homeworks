/*
Дополнительное задание:

Напишите программу для вычисления площади круга, прямоугольника и треугольника. Ввод данных осуществляется в диалоговом режиме. 
-На первом шаге у пользователя запрашивается фигура, 
площадь которой нужно вычислить. 
-На втором шаге пользователь вводит параметры, необходимые для рассчета. 
-Затем, выводится результат.
*/
while (true)
{
    Console.WriteLine("Введите тип фигуры (1 - круг, 2-прямоугольник, 3-треуголник): ");
    int type = int.Parse(Console.ReadLine());

    if (type == 1)
    {
        Console.Write("Введите радиус круга: ");
        int r = int.Parse(Console.ReadLine());
        double scircle = 3.14 * Math.Pow(r, 2);
        Console.Write("Площадь круга = " + scircle);
        break;
    }
    else if (type == 2)
    {
        Console.Write("Введите длину прямоугольника: ");
        int shir = int.Parse(Console.ReadLine());
        Console.Write("Введите ширину прямоугольника: ");
        int dlin = int.Parse(Console.ReadLine());

        double spram = shir * dlin;
        Console.Write("Площадь прямоугольника = " + spram);
        break;
    }
    else if (type == 3)
    {
        Console.Write("Введите 1ый катет треуголника: ");
        int kat1 = int.Parse(Console.ReadLine());
        Console.Write("Введите 2ой катет треуголника: ");
        int kat2 = int.Parse(Console.ReadLine());

        double stre = 0.5 * (kat1 * kat2);
        Console.Write("Площадь прямоугольника = " + stre);
        break;
    }
    else
    {
        Console.WriteLine("Такой фигуры нет. Повторите ввод.");
    }
}
