using System;
using System.ComponentModel;
namespace BasicRepeat
{
    class Program
    {
        static void Main()
        {
            //First task
            string input1 = "";
            Console.Write("Add word: ");
            string input2 = Console.ReadLine();
            for(var i = 0; i < input2.Length; i++)
            {
                input1 = input2[i] + input1;
            }
            if(input1 == input2)
            {
                Console.WriteLine("Palidrom");
            }
            else
            {
                Console.WriteLine("Not Palidrom");
            }

            //Second task
            Console.Write("Add celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenhtein = (celsius * 9/5) + 32;
            double kelvin = celsius + 273.15;
            System.Console.WriteLine(fahrenhtein);

            //Third task
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Add number: ");
                
            }
        }
    }
}