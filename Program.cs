using System;

namespace IntroProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("X=");
            string xAsString = Console.ReadLine();
            x = int.Parse(xAsString);

            int y;            
            Console.Write("Y=");
            string yAsString = Console.ReadLine();
            y = int.Parse(yAsString);

            bool isOverflow = ((x + y) < int.MaxValue);
            if (!isOverflow)
            {
                int sum = checked(x + y);
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("Arithmetic overflow");
            }

        }
    }
}
