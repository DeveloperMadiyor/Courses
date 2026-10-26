using System;
namespace BasicsRepeat
{
    class Program
    {
        static void Main()
        {
            //First task
            Console.Write("Add minutes: ");
            int num1 = int.Parse(Console.ReadLine());
            TimeOnly time = TimeOnly.MinValue.AddMinutes(num1);
            Console.WriteLine(time);
        
            //Second task
            Console.Write("Add your age: ");
            int age = int.Parse(Console.ReadLine());
            if(age == 0 || age <= 12)
            {
                Console.WriteLine("Child");
            }
            else if(age == 13 || age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if(age == 20 || age <= 59)
            {
                Console.WriteLine("Adolt");
            }
            else
            {
                Console.WriteLine("Older");
            }

            //Third task
            int sum = 0;
            int output = 0;
            for(int i = 1; i <= 3; i++)
            {
                Console.Write("Add your ball: ");
                int ball = int.Parse(Console.ReadLine());
                output += ball;
                sum = output / 3;
            }
            
            if(sum == 80 && sum <= 100)
            {
                Console.WriteLine("straight");
            }
            else if(sum == 60 && sum <= 79)
            {
                Console.WriteLine("well");
            }
            else if(sum == 40 && sum <= 59)
            {
                Console.WriteLine("so so");
            }
            else
            {
                Console.WriteLine("bad");
            }

            //Fourth task
            int random = Random.Shared.Next(1, 101);
            Console.Write("Add number: ");
            int num2 = int.Parse(Console.ReadLine());
            if(num2 == random)
            {
                Console.WriteLine("Equal");
            }
            else if(num2 < random)
            {
                Console.WriteLine("less");
            }
            else
            {
                Console.WriteLine("Gritter");
            }
        }
    }
}