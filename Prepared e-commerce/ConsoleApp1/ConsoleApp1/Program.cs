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
            Console.WriteLine("your name?");

            var name = Console.ReadLine();
            var array=new char[name.Length];
            for (var i = name.Length; i > 0; i--) 
            array[name.Length - i] = name[i - 1];
            var reversed = new string(array);
            Console.WriteLine("reversed name:"+reversed);



        }
    }
}