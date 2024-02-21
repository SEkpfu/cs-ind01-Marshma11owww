using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter num [2;...]: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine("Incorrect input!");
            return;
        }
        for (int i = 2; i <= n; i++)
        {
            int k = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    k += 1;
                }
            }
            if (k == 1)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }
}
