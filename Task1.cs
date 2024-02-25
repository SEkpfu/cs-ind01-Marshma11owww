//using System;
//class Program
//{
//    static void Main()
//    {
//        double[] x = new double[15];
//        double[] fx = new double[15];

//        for (int i = 0; i < 15; i++) //Задание Х
//        {
//            Console.Write($"Enter x[{i}]: ");
//            x[i] = Convert.ToDouble(Console.ReadLine());
//            fx[i] = Fx(x[i]);   //Просчет Fx
//        }

//        for (int i = 0; i < 15; i++) //Вывод
//        {
//            Console.WriteLine($"{i}. x = {x[i].ToString("#.##")}; F(x{i.ToString("#.##")}) = {fx[i].ToString("#.##")}");
//        }
//        Console.WriteLine();

//        int k = 0; //Точки вне закрашенной области
//        Console.WriteLine("Points isnt in marked area: ");
//        for (int i = 0; i < 15; i++)
//        {
//            if (IsInArea(x[i], fx[i]) == false)
//            {
//                Console.WriteLine($"{i}. [{x[i].ToString("#.##")};{fx[i].ToString("#.##")}] Dist (0, 0) = {Dist0(x[i], fx[i]).ToString("#.##")}");
//                k++;
//            }
//        }
//        if (k == 0)
//        {
//            Console.WriteLine("All points are in marked area!");
//        }

//        double a = 0, b = 0;
//        int m = 0;
//        double MaxDist = 0;     //Точки в 3 четверти
//        for (int i = 0; i < 15; i++)
//        {
//            if (x[i] < 0 & fx[i] < 0)
//            {
//                if (Dist0(x[i], fx[i]) > MaxDist)
//                {
//                    MaxDist = Dist0(x[i], fx[i]);
//                    a = x[i];
//                    b = fx[i];
//                }
//                m += 1;
//            }
//        }

//        if (m == 0)
//        {
//            Console.WriteLine("There's no points in III quarter!");
//        }
//        else
//        {
//            Console.WriteLine($"Point in III quarter with largest distance to (0, 0): [{a}, {b}] Dist = {MaxDist.ToString("#.##")}");
//        }

//    }



//    static double Fx(double x)
//    {
//        if (x < -1)
//        {
//            return (Math.Pow(Math.Cos(x), 2) * (Math.Pow(x, 2) + 2));
//        }
//        else if (x >= -1 || x < 3 * Math.PI)
//        {
//            return ((Math.Pow(x, 3) + 3) / (2 * x - (1 / (x + 2))) * (x / (1 + x)));
//        }
//        else
//        {
//            return 7.0 + 5.0 / 9.0;
//        }
//    }
//    static bool IsInArea(double x, double y)
//    {
//        if ((Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) <= 10 & y >= -5 & y <= 0) | (x >= 0 & y >= 0 & y <= -x + 10) | (x >= 5 & x <= 0 & y >= 0 & y <= 10))
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//    static double Dist0(double x, double y)
//    {
//        return (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
//    }
//}
