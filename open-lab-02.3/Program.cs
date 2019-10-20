using System;

namespace open_lab_02._3
{
    class Program
    {
       public static double Remainder(double n1, double n2)
        {
            return(n1%n2);
        }
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double remainder;

            Console.WriteLine("Enter first number.");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            n2 = int.Parse(Console.ReadLine());

            remainder = Remainder(n1, n2);
            Console.WriteLine($"Remainder is {remainder}");


        }
    }
}
