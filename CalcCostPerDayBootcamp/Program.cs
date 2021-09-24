using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
         
            // My Solution
            int Cost = 15500;
            int Duration = 65;
            Console.WriteLine($"The Bootcamp is {Duration} days long and costs ${Cost / Duration} per day.");

            
            /* Greg's Solution

            var CostOfBootcamp = 15500;
            var NumberofDays = 65;
            var PricePerDay = CostOfBootcamp / NumberofDays;
            Console.WriteLine($"The Bootcamp costs ${PricePerDay} per day");

            */
            //Greg's Enhancements - easier to round a single variable! scalable in business solutions
            // This is a comment ...


            var CostOfBootcamp = 15500m;
            var NumberofDays = 65;
            var PricePerDay = CostOfBootcamp / NumberofDays;
            var PreMessage = "The Bootcamp costs";
            var PostMessage = " per day.";
            Console.WriteLine($"{PreMessage} ${PricePerDay} {PostMessage}");

            // Parth's Solution was to use Math.Round  - could potentially cause errors, but gets it in decimal format, use Greg's enhancement/version
            /*
            int Cost = 15500;
            int Duration = 65
            Console.WriteLine($"The Bootcamp is {Duration} days long and costs ${Cost / Duration} per day.");
            */
        }
    }
}
/* 65 days in bootcamp, $15500 total, new project, calculate how much it costs per day = 238.46*/







