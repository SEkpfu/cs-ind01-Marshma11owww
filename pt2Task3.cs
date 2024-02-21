using System;
using System.Threading;
class Program
{
    static void Main()
    {
        Random rand = new Random();
        Console.Write("Enter arrays size: "); int s = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        double[] a = new double[s];
        for (int i = 0; i < s; i++)
        {
            Console.Write($"Enter {i} element of array a: "); a[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine();

        double[] b = new double[s];
        for (int i = 0; i < s; i++)
        {
            Console.Write($"Enter {i} element of array b: "); b[i] = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine();

        double[] c = new double[s];
        for (int i = 0; i < s; i++)
        {
            c[i] = rand.Next(10);
        }
        Console.WriteLine();

        Console.WriteLine($"Array a: ");
        for (int i = 0; i < s; i++)
        {
            Console.WriteLine($"{i}. {a[i]}");
        }
        Console.WriteLine();

        Console.WriteLine($"Array b: ");
        for (int i = 0; i < s; i++)
        {
            Console.WriteLine($"{i}. {b[i]}");
        }
        Console.WriteLine();

        Console.WriteLine($"Array c: ");
        for (int i = 0; i < s; i++)
        {
            Console.WriteLine($"{i}. {c[i]}");
        }
        Console.WriteLine();

        Console.WriteLine("Generated array: ");
        double[] xx = Func(a, b, c, s);
        for (int i = 0; i < xx.Length; i++)
        {
            Console.WriteLine($"{i}. {xx[i]}");
        }
        Console.WriteLine();
    }

    static public double[] Func(double[] m, double[] n, double[] p, int s)
    {
        double[] x = new double[s * 2];
        for (int i = 0; i < s; i++)
        {
            x[2 * i] = (m[i] + n[i]) / 2.0;
            x[2 * i + 1] = p[i];
        }

        return x;
    }
}
