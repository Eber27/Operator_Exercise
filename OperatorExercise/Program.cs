using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            a = 17;
            b = 4;

            int sum = a + b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder} and sum is {sum}:");
            Console.Write("Which is the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(radius));
        }

        static double AreaOfCircle (double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}