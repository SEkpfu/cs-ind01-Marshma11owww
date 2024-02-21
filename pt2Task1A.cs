using System;
class Program
{
    static void Main()
    {

        string x = " ";
        int amount = 0;
        double svol = 0;
        int vol10 = 0;
        double maxvol = 0;
        int imaxvol = 0;

        while (x != "q")
        {
            Console.WriteLine("Enter barrel info: ");
            Console.Write("Enter high: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double vol = Math.PI * r * r * h;
            Console.Write("Volume: ");
            Console.WriteLine(vol.ToString("#.###"));
            Console.WriteLine();

            if (vol > 10)
            {
                vol10++;
            }

            if (vol > maxvol)
            {
                maxvol = vol;
                imaxvol = amount + 1;
            }
            amount++;
            svol += vol;
            Console.Write("[Q] to break / [Enter] to continue >>> ");
            x = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Sum of volumes of barrels: ");
        Console.WriteLine(svol.ToString("#.###"));
        Console.Write("Barrels with volume > 10: ");
        Console.WriteLine(vol10.ToString("#.###"));
        Console.Write("Barrel with max volume: ");
        Console.WriteLine($"[{imaxvol}] {maxvol.ToString("#.###")}");
        Console.WriteLine();
    }
}
