using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task
            Console.Write("Add Letter: ");
            char letter1 = char.Parse(Console.ReadLine());
            bool Bool = false;
            for (char i = 'A'; i <= 90; i++)
            {
                if (i == letter1)
                {
                    Bool = true;
                }
            }
            if (Bool) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            //Second task
            Console.Write("Add Letter: ");
            char letter2 = char.Parse(Console.ReadLine());
            if (letter2 == 'H' || letter2 == 'h') Console.WriteLine("Exactly");
            else Console.WriteLine("Unfortunatelly");

            //Third task
            Console.Write("Add your name: ");
            string name = Console.ReadLine();
            char letter3 = name[0];
            Console.WriteLine(letter3);
        }
    }
}