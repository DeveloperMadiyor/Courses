using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //First task
            Console.Write("Add radius: ");
            double Input = Convert.ToDouble(Console.ReadLine());
            double L = 2 * 3.14 * Input;
            double S = 3.14 * Math.Pow(Input, 2);
            Console.WriteLine($"L = {L}");
            Console.WriteLine($"S = {S}");

            //Second task
            Console.WriteLine("1 USD = 12400 SUM");
            Console.Write("Exchange USD: ");
            double input = Convert.ToDouble(Console.ReadLine());
            double sum = input * 12400;
            Console.WriteLine($"Your cash {sum}");
      
            //Third task
            DateTime date = DateTime.Now;
            int yearNow = date.Year;
            Console.Write("Add your birthday: ");
            int birthday = Convert.ToInt32(Console.ReadLine());
            int allDays = yearNow - birthday;
            Console.WriteLine($"Your days {allDays * 365}");
        }
    }
}
