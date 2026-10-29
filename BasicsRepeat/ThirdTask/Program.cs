using System;
using System.ComponentModel;
using System.Collections.Generic;
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
            int num1;
            List<int> ints = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Add number: ");
                num1 = int.Parse(Console.ReadLine());
                ints.Add(num1);
            }
            ints.Sort();
            foreach(var input in ints)
            {
                Console.WriteLine(input);
            }
            ints.Reverse();
            foreach(var input in ints)
            {
                Console.WriteLine(input);
            }

            //Fourth task
            Dictionary<string, int> dicWord = new Dictionary<string, int>();
            string words;
            string word;
            Console.Write("Write your text: ");
            words = Console.ReadLine();
            for(int i = 0; i < words.Length; i++)
            {
                word = Convert.ToString(words[i]);
                if (!dicWord.ContainsKey(word))
                {
                    dicWord.Add(word, 1);
                }
                else
                {
                    dicWord[word]++;
                }
            }
            foreach(var input in dicWord)
            {
                Console.WriteLine($"{input.Key} = {input.Value}");
            }
        }
    }
}