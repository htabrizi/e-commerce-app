using System;

namespace ConsoleApp1
{
    class program
    {

        static void Main(string[] args)
        {
            var timeSpan=new TimeSpan(1,2,3);
            var timeSpan1=new TimeSpan(1,2,3);
            var timeSpan2=TimeSpan.FromHours(1);
var start =DateTime.Now;
var end =DateTime.Now.AddMinutes(2);
var duration=end-start;
System.Console.WriteLine( timeSpan.Minutes);
System.Console.WriteLine(timeSpan.TotalMinutes);
System.Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));
System.Console.WriteLine(timeSpan.ToString());
System.Console.WriteLine( TimeSpan.Parse("01:02:03"));
        }
    }
}