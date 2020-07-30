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
         var numbers = new List<int>(){1,2,23,4};
         numbers.Add(1);
         numbers.AddRange(new int[3]{3,3,3});
         foreach (var number in numbers)
             Console.WriteLine(number);

         Console.WriteLine();
         Console.WriteLine(numbers.IndexOf(1));
         Console.WriteLine(numbers.LastIndexOf(1));
         Console.WriteLine(numbers.Count);
         numbers.Remove(1);
         foreach (var number in numbers)
             Console.WriteLine(number);


        }

    }
}