//using System;
//class Program
//{
//    static void Main()
//    {

//        double minvol = Double.MaxValue;
//        double sqsum = 0;
//        int volless10 = 0;
//        Cylinder cylinder = new Cylinder();
//        for (int i = 0; i < 3; i++)
//        {
//            cylinder.CylIn();
//            Console.WriteLine($"Vol: {cylinder.vol().ToString("#.##")} SideSquare: {cylinder.side().ToString("#.##")}");
//            sqsum += cylinder.side();
//            if (cylinder.vol() < 10)
//            {
//                volless10++;
//            }
//            if (cylinder.vol() < minvol)
//            {
//                minvol = cylinder.vol();
//            }
//            Console.WriteLine();
//        }
//        Console.WriteLine();

//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Min volume: {minvol.ToString("#.##")}");
//        Console.WriteLine($"Sum of sidesquares: {sqsum.ToString("#.##")}");
//        Console.WriteLine($"Amount of cylinders with volume less 10: {volless10}");
//        Console.ResetColor();

//    }
//}

//class Cylinder
//{
//    public double h, r;

//    public double vol()
//    {
//        return Math.PI * Math.Pow(r, 2) * h;
//    }

//    public double side()
//    {
//        return (2 * Math.PI * r);
//    }

//    public void CylIn()
//    {
//        Console.Write("Enter R: "); r = Convert.ToDouble(Console.ReadLine());
//        if (r < 0)
//        {
//            Console.WriteLine("Incorrect input!");
//            Environment.Exit(0);
//        }
//        Console.Write("Enter H: "); h = Convert.ToDouble(Console.ReadLine());
//        if (h < 0)
//        {
//            Console.WriteLine("Incorrect input!");
//            Environment.Exit(0);
//        }
//    }
//}

