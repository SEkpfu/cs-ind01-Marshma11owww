using System;
class Program
{
    static void Main()
    {
        double a = 0;
        double b = 0.9;
        double c = (a + b) / 2;
        while (Math.Abs(F(c)) > 0.001)
        {
            if (F(c) * F(a) > 0)
            {
                a = c;
            }
            else if (F(c) * F(b) > 0)
            {
                b = c;
            }
            c = (a + b) / 2;
        }
        Console.WriteLine($"X = {c.ToString("0.###")} +- 0.001");
    }
    static double F(double x)
    {
        return Math.Log10(x * x - 3 * x + 2);
    }

}
