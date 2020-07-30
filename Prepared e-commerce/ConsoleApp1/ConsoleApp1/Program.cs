using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
    class program
    {

        static void Main(string[] args)
        {

            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter Number:");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                numbers.Add(Convert.ToInt32(input));
            }
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if(!uniques.Contains(number))
                    uniques.Add(number);

            }

            Console.WriteLine("uniqe");
            foreach (var unique in uniques)
            {
                Console.WriteLine(unique);
            }

            
        }
    }
}