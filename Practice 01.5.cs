using System;

class Problem8
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Circle Calculator ---");
        Console.WriteLine("[A] Compute Area");
        Console.WriteLine("[P] Compute Perimeter");
        Console.WriteLine("[X] Exit");
        Console.Write("Choose an option (A, P, X): ");

        char choice = Convert.ToChar(Console.ReadLine().ToUpper());

        if (choice == 'X')
        {
            Console.WriteLine("Application Closed.");
        }
        else if (choice == 'A')
        {
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine("Area: " + area);
        }
        else if (choice == 'P')
        {
            Console.Write("Enter the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine("Perimeter: " + perimeter);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
