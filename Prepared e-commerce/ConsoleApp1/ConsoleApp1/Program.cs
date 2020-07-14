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

            var number = new Random().Next(1, 10);
            
            for (var i = 1; i <= 4; i++)
            {
                Console.Write("Guess the secret number:");
                var guess = Convert.ToInt32(Console.ReadLine());
                if( guess == number){ 
                    Console.WriteLine("won");
                    return;
                }
               
            }Console.WriteLine("Secret is " + number);
              Console.WriteLine("Lost"); 
        }
    }
}