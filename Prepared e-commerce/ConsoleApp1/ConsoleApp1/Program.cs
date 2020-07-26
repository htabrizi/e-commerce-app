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

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Efect of Clear()");
            foreach (var n in numbers) { Console.WriteLine(n); }
            //copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var item in another)
                Console.WriteLine(item);

            //sort()
            Array.Sort(numbers);
            Console.WriteLine("effect sort");
            foreach (var n in numbers)
                Console.WriteLine(n);
            //reverse
            Array.Reverse(numbers);
            Console.WriteLine("reverse");
                foreach (var n in numbers)
                Console.WriteLine(n);
            

             
        }
    }
}