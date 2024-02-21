using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        int NSq10 = 0;
        double Sqcloseto10 = Double.MaxValue;
        string x = "";
        while (x != "q")
        {

            Triangle T = new Triangle();
            T.TRIn();

            if (T.Check() != true)
            {
                Console.WriteLine("Incorrect input!");
                break;
            }

            Console.WriteLine();
            Console.WriteLine($"Triangle area: {T.Area()}");

            if (Triangle.Sq10(T.Area()))
            {
                NSq10++;
            }
            if (Math.Abs(10 - T.Area()) < Sqcloseto10)
            {
                Sqcloseto10 = T.Area();
            }
            Console.Write("[Q] to break / [Enter] to continue >>> ");
            x = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine($"Triangles with area > 10: {NSq10}");
        Console.WriteLine($"Triangle area closest to 10: {Sqcloseto10}");
    }


}
class Triangle
{
    public double x1, y1, x2, y2, x3, y3;
    public void TRIn()
    {
        Console.Write("Enter x1: "); x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: "); y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: "); x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: "); y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x3: "); x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y3: "); y3 = Convert.ToDouble(Console.ReadLine());
    }

    public double Dist(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }

    public double Area()
    {
        double a = Dist(x1, y1, x2, y2);
        double b = Dist(x2, y2, x3, y3);
        double c = Dist(x3, y3, x1, y1);
        double p = (a + b + c) / 2;
        return (Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }

    public bool Check()
    {
        double a = Dist(x1, y1, x2, y2);
        double b = Dist(x2, y2, x3, y3);
        double c = Dist(x3, y3, x1, y1);
        return ((a + b) > c & (b + c) > a & (a + c) > b);
    }

    public static bool Sq10(double x)
    {
        return (x > 10);
    }
}

