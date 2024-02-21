using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
        Console.Write("Enter your name: ");
        string a = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{a}, in next year you will be {age + 1} years old!");
    }
}