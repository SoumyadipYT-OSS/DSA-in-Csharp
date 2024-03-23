using System;

namespace Enum_By_type {
    enum Categories : byte {
        Electronics = 1,
        Food = 5,
        Automotive = 6,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15
    }


    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Electronics: " + (byte)Categories.Electronics);
            Console.WriteLine("Food: " + (byte)Categories.Food);
            Console.WriteLine("Automotive: " + (byte)Categories.Automotive);
            Console.WriteLine("Arts: " + (byte)Categories.Arts);
            Console.WriteLine("BeautyCare: " + (byte)Categories.BeautyCare);
            Console.WriteLine("Fashion: " + (byte)Categories.Fashion);
        }
    }
}


/*
    'byte' is used to specify the underlying data type of the enum.
    By default, the underlying data type for the enum is int.
    You can specify another integral numeric type by using a colon after the enum name.
    In the above example, we have specified the underlying data type of the enum as 'byte'.
 */