using System;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for(var i=1; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;

                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }
    }
}