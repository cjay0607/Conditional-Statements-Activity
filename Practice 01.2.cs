using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number >= 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is negative.");
        }
    }
}
