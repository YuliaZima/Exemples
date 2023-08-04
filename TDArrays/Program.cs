void Task47()
{
    double [,] CreateArray (int n, int m)
    {
    return new double [n,m];
    }

    void FillRealNumbersArray(double [,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = Math.Round(new Random().NextDouble()*20-10, 2);
            }
        }
    }

    void PrintArray(double [,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]}  "); 
            }
            System.Console.WriteLine();
        }
    }
    double[,] arr = CreateArray(3,4);
    FillRealNumbersArray(arr);
    PrintArray(arr);
}
    

void Task50()
{
    int[,] CreateArray(int n, int m)
    {
        return new int[n, m];
    }

    void FillArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }
    void CheckElementByPosition(int row, int col, int[,] array)
    {
        if (row < array.GetLength(0) && col < array.GetLength(1))
        {
            Console.WriteLine(array[row, col]);
        }
        else
        {
            System.Console.WriteLine("Элемента по заданному индексу нет в массиве");
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}  ");
            }
            System.Console.WriteLine();
        }
    }
    int[,] arr = CreateArray(3, 4);
    FillArray(arr);
    PrintArray(arr);
    CheckElementByPosition(0, 0, arr);
    CheckElementByPosition(2, 2, arr);
    CheckElementByPosition(4, 5, arr);
    CheckElementByPosition(6, 7, arr);
}

void Task52()
{
    ﻿int [,] CreateArray (int n, int m)
    {
    return new int [n,m];
    }

    void FillArray(int [,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(1,10);
            }
        }
    }    

    void ColumnGradePointAverage(int[,] array)
    {
        double SumColumnElements  = 0; 
        double GradePointAverage = 0;
        
        for (int i = 0; i < array.GetLength(1); i++)
        {     
            for (int j = 0; j < array.GetLength(0); j++)
            {
                SumColumnElements =(SumColumnElements + array[j,i]);
            }
            GradePointAverage = Math.Round(SumColumnElements/array.GetLength(0),1);
            System.Console.Write($"{GradePointAverage}; ");
            SumColumnElements =0;
        }
        
    }

    void PrintArray(int [,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]}  "); 
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    int[,] arr = CreateArray(3,4);
    FillArray(arr);
    PrintArray(arr);
    ColumnGradePointAverage(arr);
}

Task47();
Task50();
Task52();