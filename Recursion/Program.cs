void Task66()
{
        int SumElements(int M, int N)
    {
        if (M<N)
        {
            M += SumElements(M+1, N);
        }
        return M;
    }
    System.Console.WriteLine(SumElements(1,9));
    System.Console.WriteLine(SumElements(13,20));
    System.Console.WriteLine(SumElements(5,7));
}

void task68()
{
        ﻿static int AckermannFunc(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if ((m > 0) && (n == 0))
        {
            return AckermannFunc(m - 1, 1);
        }
        else if ((m > 0) && (n > 0))
        {
            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
        }
        else
            return n + 1;
    }
    Console.WriteLine(AckermannFunc(3,2));
    Console.WriteLine(AckermannFunc(2,3));
    Console.WriteLine(AckermannFunc(0,3));
    Console.WriteLine(AckermannFunc(4,0));
}

void Task64()
{
        int MultipleOfFhree (int M, int N)
    {
        
        if (M<N)
        {   
            if (M%3 == 0)
            {
                Console.WriteLine(M);    
            }
            M = MultipleOfFhree(M+1, N);
        }
        return M;
    }
    System.Console.WriteLine(MultipleOfFhree(1,9));
    
}

Task66();
task68();
Task64();