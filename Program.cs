class Program
{
    static void Main(string[] args)
    {
        int m = 1;
        int n = 5;

        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNumbers(m + 1, n);
        }
    }
}

//////////////////////////////////////////////////////////////////////////////

class Program
{
    static void Main(string[] args)
    {
        int m = 1;
        int n = 15;

        int sum = SumNumbers(m, n); 
        Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}"); 

    static int SumNumbers(int m, int n)
    {
        if (m > n) 
        {
            return 0;
        }
        else 
        {
            int sum = SumNumbers(m + 1, n) + m;
            return sum;
        }
    }
}

////////////////////////////////////////////////////////////////////////////////////////////////////


using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Ackermann(2, 3));
    }
}

