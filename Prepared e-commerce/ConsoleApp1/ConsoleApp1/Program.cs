using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Number");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            if (number >= 1 && number <= 10)
            { Console.WriteLine("valid"); }
            else
            {
                Console.WriteLine("invalid"); }
           
        }
    }
}
 