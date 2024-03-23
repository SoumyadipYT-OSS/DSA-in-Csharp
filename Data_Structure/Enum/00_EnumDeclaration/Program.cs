using System;

/*
    In C#, an enum is a value type data type. It is used to declare a list of named 
    integer constants. It can be defined using the enum keyword directly inside a 
    namespace, class, or structure.

    An enum can be declared outside or inside a class, but not in a method.

    By default, the first enumerator has the value 0, and the value of each successive
    enumerator is increased by 1.

    You can also customize the value of enum elements. In the following example,
    Sunday is 0, Monday is 1, and so on.


    Enum is used when we know all possible values at compile time, such as choices on a menu,
     command line flags, etc. It is the best way to create a group of related constants.
 */

namespace Enum_declaration {
    enum WeekDays {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    public class Solution {
        static void Main(string[] args) {
            Console.WriteLine("Monday: " + (int)WeekDays.Monday);
            Console.WriteLine("Tuesday: " + (int)WeekDays.Tuesday);
            Console.WriteLine("Wednesday: " + (int)WeekDays.Wednesday);
            Console.WriteLine("Thursday: " + (int)WeekDays.Thursday);
            Console.WriteLine("Friday: " + (int)WeekDays.Friday);
            Console.WriteLine("Saturday: " + (int)WeekDays.Saturday);
            Console.WriteLine("Sunday: " + (int)WeekDays.Sunday);
        }
    }
}