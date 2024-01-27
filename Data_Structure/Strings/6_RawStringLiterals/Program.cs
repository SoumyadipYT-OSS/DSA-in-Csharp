using System;

namespace pr6
{
    class q6
    {
        static void Main(string[] args)
        {
            // CS8999: Line does not start with the same whitespace as the closing line
            // of the raw string literal
            Console.WriteLine("__Example 1__");
            var noOutdenting = """
                        A line of text.
                    Trying to outdent the second line.
                """;
            Console.WriteLine($"No outdenting: {noOutdenting}\n");

//------------------------------------------------------------------------------------------------------------

            Console.WriteLine("\n__Example 2__");
            string jsonString = """ 
            {
                "Date": "2024-Jan-27; Time: 10:00-16:00",
                "TemperatureCelsius": 25,
                "Summary": "Normal",
                "DatesAvailable": [
                    "2024-01-27T10:00-16:00",
                    "2024-01-28T10:00-16:00"
                ],
                "TemperatureRanges": [
                    "Cold": {
                        "High": 20,
                        "Low": -10
                    },
                    "Normal": {
                        "High": 28,
                        "Low": 21
                    },
                    "Hot": {
                        "High": 60
                        "Low": 29
                    }
                   ],
                "SummaryWords": [
                    "Cool",
                    "Windy",
                    "Humid"
                   ]
            }
            """;
            Console.WriteLine($"Json String: \n{jsonString}");


            //----------------------------------------------------------------------------


            Console.WriteLine("\n__Example 3__");
            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");

            // Output:
            // Jupiter Hammon was an African American poet born in 1711.
            // He was first published in 1761 at the age of 50.
            // He'd be over 300 years old today
        }
    }
}
