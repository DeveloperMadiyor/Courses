using System;
using System.Reflection.Metadata.Ecma335;
namespace BasicsRepeat
{
    class Program
    {
        static void Main()
        {
            //First task
            string str = "telePhone";
            string output;
            Console.Write("Add number: ");
            int num1 = int.Parse(Console.ReadLine());
            if(str.Length < num1)
            {
                output = str.ToUpper();
                Console.WriteLine(output);
            }
            else
            {
                output = str.ToLower();
                Console.WriteLine(output);
            }

            //Second task
            int x = 15;
            int y = 15;
            if(x > y) Console.WriteLine("x is greater than y");
            else if(x < y) Console.WriteLine("x is less than y");
            else Console.WriteLine("x is equal than y");
        
            //Third task
            Console.Write("Add days: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "dushanba":
                System.Console.WriteLine("monday");
                break;
                case "seshanba":
                System.Console.WriteLine("tuesday");
                break;
                case "chorshanba":
                System.Console.WriteLine("wednesday");
                break;
                case "payshanba":
                System.Console.WriteLine("thursday");
                break;
                case "juma":
                System.Console.WriteLine("friday");
                break;
                case "shanba":
                System.Console.WriteLine("saturday");
                break;
                case "yakshanba":
                System.Console.WriteLine("sunday");
                break;
                default:
                System.Console.WriteLine("default");
                break;
            }
        }
    }
}