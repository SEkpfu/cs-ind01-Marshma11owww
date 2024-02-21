using System;
using System.Reflection;
class Program
{
    static void Main()
    {
        int n5555 = 0;
        Len maxLen;
        Len minLen;
        int MinLenInd = 0;
        Random rand = new Random();

        Len[] lens = new Len[100];
        Console.WriteLine("Enter 1st element of array: ");
        lens[0] = new Len();
        lens[0].LenIn();
        for (int i = 1; i < 100; i++)
        {
            lens[i] = new Len();
            lens[i].km = rand.Next(100);
            lens[i].m = rand.Next(999);
            lens[i].cm = rand.Next(99);
            lens[i].mm = rand.Next(9);
        }

        for (int i = 0; i < lens.Length; i++)
        {
            Console.Write($"{i}. ");
            lens[i].LenOut();
            Console.WriteLine();
        }

        maxLen = lens[0];
        minLen = lens[0];
        for (int i = 1; i < 100; i++)
        {
            if (Len.Compare(lens[i], maxLen) == 1)
            {
                maxLen = lens[i];
            }

            if (Len.Compare(lens[i], minLen) == 1)
            {
                minLen = lens[i];
            }
        }

        for (int i = 0; i < 100; i++)
        {
            if (lens[i].km == 5 & lens[i].m == 5 & lens[i].cm == 5 & lens[i].mm == 5)
            {
                n5555++;
            }
        }

        Console.WriteLine();
        Console.Write($"Max length in array: "); maxLen.LenOut(); Console.WriteLine();
        Console.WriteLine($"Index of min length in array: {MinLenInd}");
        Console.WriteLine($"Amount of 5km 5m 5cm 5mm: {n5555}");

    }

}

class Len
{
    public double km, m, cm, mm;
    public void LenIn()
    {
        Console.Write("Km: "); km = Convert.ToDouble(Console.ReadLine());
        Console.Write("M: "); m = Convert.ToDouble(Console.ReadLine());
        Console.Write("Cm: "); cm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Mm: "); mm = Convert.ToDouble(Console.ReadLine());

        if (mm >= 10)
        {
            cm += mm / 10;
            mm = mm % 10;
        }

        if (cm >= 100)
        {
            m += m / 100;
            cm = cm % 100;
        }

        if (m >= 1000)
        {
            km += m / 1000;
            m = m % 1000;
        }

    }
    public void LenOut()
    {
        Console.Write($"{km} km ");
        Console.Write($"{m} m ");
        Console.Write($"{cm} cm ");
        Console.Write($"{mm} mm ");
    }
    public static int Compare(Len a, Len b)
    {
        if (a.km < b.km)
        {
            return -1;
        }
        else if (a.km > b.km)
        {
            return 1;
        }
        else
        {
            if (a.m < b.m)
            {
                return -1;
            }
            else if (a.m < b.m)
            {
                return 1;
            }
            else
            {
                if (a.cm < b.cm)
                {
                    return -1;
                }
                else if (a.cm > b.cm)
                {
                    return 1;
                }
                else
                {
                    if (a.mm < b.mm)
                    {
                        return -1;
                    }
                    else if (a.mm > b.mm)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
