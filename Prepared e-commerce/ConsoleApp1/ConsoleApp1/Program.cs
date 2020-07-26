using System;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
    class program
    {
       
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 5, 7, 9, 11, 2, 3, 5 };
            Console.WriteLine("length: " + numbers.Length);
            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index 3: " + index);
        }
    }
}