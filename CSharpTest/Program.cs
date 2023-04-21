using System;
using static CSharpTest.WorkDayCalculatorTests;


namespace CSharpTest;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime startDate = new DateTime(2021, 4, 21);
        /*DateTime dateTime2 = DateTime.Today;
        DateTime dateTime1 = DateTime.Now;
        Console.WriteLine(dateTime1);
        Console.WriteLine(dateTime2);
        Console.WriteLine(dateTime1 < dateTime2);*/


        // var dateTime = new DateTime(2021, 4, 21);
        // Console.WriteLine(dateTime.AddDays(5));


        Console.WriteLine(new DateTime(2021, 4, 25).Subtract(new DateTime(2021, 4, 23)));

        Console.WriteLine(startDate.AddDays(7));
    }
}


