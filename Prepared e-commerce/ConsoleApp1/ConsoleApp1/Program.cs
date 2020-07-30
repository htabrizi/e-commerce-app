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
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter Number:");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("you're previous entered" + number);
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}