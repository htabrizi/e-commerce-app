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

            var sum = 0;

            while (true)
            {
                Console.Write("write 2 number");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine(sum);
        }
    }
}