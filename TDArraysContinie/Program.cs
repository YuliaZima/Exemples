void Task54()
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
    void SortElementsByRow(int[,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = array.GetLength(1) - 1; j > 0; j--)
            {
                for (int k = 0; k < j; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
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
        System.Console.WriteLine();
    }
    int[,] arr = CreateArray(3, 4);
    FillArray(arr);
    SortElementsByRow(arr);
    PrintArray(arr);
}

void Task56()
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
    int[] SumElementsInRow(int[,] array)
    {
        int[] row = new int[array.GetLength(0)];
        int index = 0;
        int SumElements = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                SumElements = SumElements + array[i, j];
                
            }
        row[index] = SumElements;
        index++;
        SumElements =0;
        
        }
        return row;
    }
    void PrintOneStringArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write($"{array[i]} ");
        }

    }
    int MinElementInArray(int [] array)
    {   int Index =0;
        int Min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if(Min>array[i])
            {
                Min = array[i];
                Index = i;
            }
            
        }
        System.Console.WriteLine();
        System.Console.WriteLine(Index);
        return Index;
    }
    void PrintStringByIndex(int[,] array, int Index)
    {
        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[Index, j]}  ");
            }
            
        
        System.Console.WriteLine();
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
        System.Console.WriteLine();
    }
    int[,] arr = CreateArray(3, 5);
    FillArray(arr);
    PrintArray(arr);
    int[] OneStrArray = SumElementsInRow(arr);
    PrintOneStringArray(OneStrArray);
    int NumberOfString = MinElementInArray(OneStrArray);
    PrintStringByIndex(arr, NumberOfString );
}

void Task58()
{
    int[,] CreateArray(int n, int m)
    {
        return new int[n, m];
    }
    void FillArray(int[,] array)
    {   
        int Number = 1;
        int size = array.GetLength(0);
        for (int i = 0; i < size / 2; i++)
        {
            for (int j = i; j < size - i; j++)
            {
                array[i, j] = Number;
                Number++;
            }

            for (int j = i + 1; j < size - i; j++)
            {
                array[j, size - i - 1] = Number;
                Number++;
            }

            for (int j = size - i - 2; j > i - 1; j--)
            {
                array[size - i - 1, j] = Number;
                Number++;
            }

            for (int j = size - i - 2; j > i; j--)
            {
                array[j, i] = Number;
                Number++;
            }
            
        }
    }
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}   ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
    int[,] arr = CreateArray(4, 4);
    FillArray(arr);
    PrintArray(arr);
}

Task54();
Task56();
Task58();