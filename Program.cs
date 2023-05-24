class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = m; i <= n; i++)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}

