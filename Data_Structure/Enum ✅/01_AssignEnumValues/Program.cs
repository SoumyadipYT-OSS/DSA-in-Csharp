using System;

namespace AssignValues_to_Enum_Members {
    enum Categories {
        Electronics,
        Food,
        Automative = 6,
        Arts,
        BeautyCare,
        Fashion
    }


    public class Solution {
        static void Main(string[] args) {
            Console.WriteLine("Electronics: " + (int)Categories.Electronics);
            Console.WriteLine("Food: " + (int)Categories.Food);
            Console.WriteLine("Automative: " + (int)Categories.Automative);
            Console.WriteLine("Arts: " + (int)Categories.Arts);
            Console.WriteLine("BeautyCare: " + (int)Categories.BeautyCare);
            Console.WriteLine("Fashion: " + (int)Categories.Fashion);
        }
    }
}