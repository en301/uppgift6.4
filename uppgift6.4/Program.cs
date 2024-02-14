using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace uppgift_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal du vill höja upp, till exempel 5^2");
            string texttal = Console.ReadLine();
            string[] texttalarray = texttal.Split('^');
            double bas = double.Parse(texttalarray[0]);
            double potens = double.Parse(texttalarray[1]);
            Console.WriteLine("Produkten blir "+ Potens(potens, bas));
            Console.ReadKey();
        }
        static double Potens(double potens, double bas)
        {
            double sum = 1;
            for (int i = 0; i < potens; i++)
            {
                sum *= bas;
            }
            return sum;
        }
    }
}
