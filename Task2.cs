using System;
using System.Linq;
using System.Runtime.Remoting;
class Program
{

    static void Main()
    {
        string name1, name2, name3; //1st 
        int x, y, z, w;
        Console.Write("1st name: ");
        name1 = Console.ReadLine();
        Console.Write("Amount of charkas: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("2nd name: ");    //2nd
        name2 = Console.ReadLine();
        Console.Write("Amount of shkaliks: ");
        y = Convert.ToInt32(Console.ReadLine());

        ReadPerson(out name3, out z, out w);    //3rd
        Console.WriteLine();

        Console.WriteLine($"{name1} drunk {vol(x, 0)} liters.");    //A
        Console.WriteLine($"{name2} drunk {vol(0, y)} liters.");
        Console.WriteLine($"{name3} drunk {vol(z, w)} liters.");
        Console.WriteLine();

        Console.WriteLine("Drunk in diapason 0.5L - 1L: "); //B
        if (diapason(vol(x, 0)))
        {
            Console.WriteLine(name1);
        }
        if (diapason(vol(0, y)))
        {
            Console.WriteLine(name2);
        }
        if (diapason(vol(z, w)))
        {
            Console.WriteLine(name3);
        }
        else
        {
            Console.WriteLine("Nobody drunk in diapason 0.5L - 1L");
        }
        Console.WriteLine();

        Console.WriteLine($"Total volume: {vol(x, 0) + vol(0, y) + vol(z, w)}"); //C


        Console.Write("Maximum vol: "); //D
        Console.WriteLine(maxl(vol(x, 0), vol(0, y), vol(z, w)));
        Console.WriteLine();
    }

    static void ReadPerson(out string name, out int c, out int s)
    {
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Charkas: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Shkaliks: ");
        s = Convert.ToInt32(Console.ReadLine());
    }

    static double vol(int c, int s)
    {
        const double ck = 0.123;
        const double sk = 0.06;
        return ck * c + sk * s;
    }

    static bool diapason(double l)
    {
        if (l >= 0.5 && l <= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static double maxl(double a, double b, double c)
    {
        double[] maxl = { a, b, c };
        return maxl.Max();
    }
}