// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите N: ");
//         int n = int.Parse(Console.ReadLine());

//         for (int i = m; i <= n; i++)
//         {
//             Console.WriteLine(i);
//         }

//         Console.ReadLine();
//     }
// }

//////////////////////////////////////////////////////////////////////////////

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите N: ");
//         int n = int.Parse(Console.ReadLine());

//         int sum = 0;
//         for (int i = m; i <= n; i++)
//         {
//             sum += i;
//         }

//         Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {sum}");

//         Console.ReadLine();
//     }
// }

////////////////////////////////////////////////////////////////////////////////////////////////////

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);

        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");

        Console.ReadLine();
    }
}
