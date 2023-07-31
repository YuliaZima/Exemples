void Task34()
{
    ﻿int[] CreateAndFillArray(int Number)
    {
        int [] array = new int [Number];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100,1000);
        }
        return array;
    }
    void ShowArray(int [] array)
    {
        for(int i =0; i<array.Length;i++)
        {
            Console.Write($"{array[i]}  ");

        }
        System.Console.WriteLine();
    }

    void CountOfEvenNumbers(int[] array)
    {
        int count = 0;
        for(int i =0; i<array.Length;i++)
        {
            if(array[i]%2 == 0)
            {
                count++;
            }
        }
        System.Console.WriteLine($"Кол-во четных чисел {count}");
    }

    int[] arr = CreateAndFillArray(10);
    ShowArray(arr);
    CountOfEvenNumbers(arr);
}

void Task36()
{
        ﻿int[] CreateAndFillArray(int Number)
    {
        int [] array = new int [Number];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,6);
        }
        return array;
    }

    void ShowArray(int [] array)
    {
        for(int i =0; i<array.Length;i++)
        {
            Console.Write($"{array[i]}  ");
            
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
    void SumOddNumbers(int[] array)
    {
        int SumOdd  = 0;
        for(int i =0; i<array.Length;i++)
        {
            if(i % 2 != 0)
            {
                SumOdd = SumOdd +array[i];
            }
        }
        System.Console.WriteLine(SumOdd);
    }
    int[] arr = CreateAndFillArray(5);
    ShowArray(arr);
    SumOddNumbers(arr);

}

void Task38()
{
    ﻿double[] CreateAndFillArray(int Number)
{
    double[] array = new double[Number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().NextDouble()), 3);
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");

    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}

void DifferenceMinMaxNumbers(double[] array)
{
    double min = array[0];
    double max = array[1];
    double result;
    for (int i = 0; i < array.Length; i++)
    {
        if (max <= array[i])
        {
            max = array[i];
        }
        
        if (min >= array[i])
        {
            min = array[i];
        }
    }
        result = max - min;
    Console.WriteLine($"{max} - {min} = {result}");
    }

double[] array = CreateAndFillArray(5);
ShowArray(array);
DifferenceMinMaxNumbers(array);
}

Task34();
Task36();
Task38();