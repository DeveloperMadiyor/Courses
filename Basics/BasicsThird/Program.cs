using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task
            Console.Write("Add number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");

            //Second task
            Console.Write("Add number: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= 10; i++)
            {
                if (num2 % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Third task
            Console.Write("Add number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Add degree: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(num3, num4));

            //Fourth task
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Add number: ");
                int num5 = int.Parse(Console.ReadLine());
                sum += num5;
            }
            Console.WriteLine(sum);

            //Fifth task
            double sum1 = 0;
            Console.Write("Add Armstrong number: ");
            string? num6 = Console.ReadLine();
            double sum2 = Convert.ToDouble(num6);
            for (int i = 0; i < num6.Length; i++)
            {
                double input = char.GetNumericValue(num6[i]);
                sum1 += Math.Pow(input, 3);
            }
            if (sum1 == sum2) Console.WriteLine("Armstrong numbers");
            else Console.WriteLine("Not Armstrong numbers");

            //Sixth task
            Console.Write("Add numbers: ");
            int num7 = int.Parse(Console.ReadLine());
            for(int i = 1; i < num7; i++)
            {
                if(num7 % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}