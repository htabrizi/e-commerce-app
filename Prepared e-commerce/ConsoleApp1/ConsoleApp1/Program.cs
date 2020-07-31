using System;

namespace ConsoleApp1
{
    class program
    {

        static void Main(string[] args)
        {
           var dateTime = new DateTime(2015,1,1);
           var now = DateTime.Now;
           var today = DateTime.Today;
           
           Console.WriteLine("hi"+now.Hour);
           var yesterday = now.AddDays(-1);
           Console.WriteLine(now.ToLongDateString());
           Console.WriteLine(now.ToShortDateString());
           Console.WriteLine(now.ToLongTimeString());
           Console.WriteLine(now.ToShortTimeString());
           Console.WriteLine(now.ToString());
        }
    }
}