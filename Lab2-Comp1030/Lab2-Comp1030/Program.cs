using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Comp1030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lab 2 - COMP 1030 Programming Fundamentals

            /* STEP 1: Create string variables for each of the following */
            string weatherCondition = "Sunny";
            string precipitation = "20%";
            string wind = "15 km/h with gusts to 30 km/h";
            string dailyHigh = "25°C";
            string dailyLow = "12°C";
            string uvIndex = "6 or high";

            // STEP 2: Assemble all variables into one string
            string weatherReport = $"Today's weather is {weatherCondition} with a {precipitation} chance of rain. " +
                                   $"Winds are {wind}. The high will be {dailyHigh} and the low will be {dailyLow}. " +
                                   $"UV Index: {uvIndex}.";

            // STEP 3: Output the sentence to the console
            Console.WriteLine(weatherReport);
        }
    }
}
