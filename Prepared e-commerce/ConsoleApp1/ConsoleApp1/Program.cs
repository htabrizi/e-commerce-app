using System;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Number");
            var input1 = Console.ReadLine();
            var numberA = Convert.ToInt32(input1);
            var input2 = Console.ReadLine();
            var numberB = Convert.ToInt32(input2);
             
            var max=(numberA > numberB)?numberA: numberB;
                        
                Console.WriteLine("max"+ max);
        }
           
        }
    }

 