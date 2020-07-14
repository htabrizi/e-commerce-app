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

            var sum = 1;
Console.Write("write number");
                var number = Convert.ToDouble(Console.ReadLine());

           for (var i = 1; i <= number; i++)
            {
                sum *= i;
            }
            Console.WriteLine("{0}!={1}",number,sum);
        }
    }
}