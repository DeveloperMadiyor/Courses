using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task
            Console.Write("Add first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Add second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Add operation: ");
            char operation = char.Parse(Console.ReadLine());

            switch (operation) 
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
                break;
                
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
                
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
                
                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            
                default: 
                    Console.WriteLine("Неправильное значение");
                break;
            }

            //Second task
            int sum = 0;
            Console.Write("Add number: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i <= input; i++) 
            {
                sum += i;
            }
            Console.WriteLine($"Input = {sum}");

            //Third task
            Console.Write("Add number: ");
            int nums = int.Parse(Console.ReadLine());

            if (nums % 2 == 0) Console.WriteLine("even");
            else Console.WriteLine("odd");
        }
    }
}