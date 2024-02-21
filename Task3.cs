using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your birtday:");
        Console.Write("Day: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Month: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        DateTime bd = new DateTime(y, m, d);
        TimeSpan dif = DateTime.Now - bd;
        double days = dif.TotalDays;
        double age = Convert.ToDouble(days) / 365.0;
        int years = Convert.ToInt32(age);
        string stryears = Convert.ToString(years);

        if (stryears[stryears.Length - 1] == '1')
        {
            Console.WriteLine($"Вам {years} год");
        }
        else if (stryears[stryears.Length - 1] == '2' | stryears[stryears.Length - 1] == '3' | stryears[stryears.Length - 1] == '4')
        {
            Console.WriteLine($"Вам {years} года");
        }
        else
        {
            Console.WriteLine($"Вам {years} лет");
        }
        Console.WriteLine();
    }
}
