using System;

class Problem7
{
    static void Main(string[] args)
    {
        Console.Write("Enter exam score: ");
        double score = Convert.ToDouble(Console.ReadLine());

        string result = (score >= 50) ? "Passed" : "Failed";

        Console.WriteLine(result);
    }
}
