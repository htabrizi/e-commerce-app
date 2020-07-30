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

            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if(elements.Length>=5)
                        break;
                }

                Console.WriteLine("invalid List");
            }


        }
    }
}