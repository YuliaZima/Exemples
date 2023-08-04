void Task41()
{
    ﻿void CountPositivNumbers()
    {
        int[] array = UserInputInterface();
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                counter++;
            }
        }
        System.Console.WriteLine($"Кол-во положительных чисел: {counter}");
    }
    int[] UserInputInterface()
    {
        System.Console.WriteLine("Сколько чисел хотите ввести?");
        int M = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[M];
        for (int i = 0; i < arr.Length; i++)
        {
            System.Console.WriteLine("Введите число:");
            int Number = Convert.ToInt32(Console.ReadLine());
            arr[i] = Number;
        }
        return arr;
    }
    CountPositivNumbers();
}

void Task43()
{
    ﻿void UserInput()
{
    System.Console.WriteLine("Введите b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Введите k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Введите b2");
    double b2 = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Введите k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    ThePointOfiIntersectionLogic(b1,k1,b2,k2);
}

void ThePointOfiIntersectionLogic(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/(k1-k2);
    double y = (k2*x) + b2;
    System.Console.WriteLine($"Точка пересечения:X = {x} Y = {y}");
}
UserInput();
}

Task41();
Task43();