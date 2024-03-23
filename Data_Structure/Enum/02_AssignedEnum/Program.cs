using System;

namespace AssignedEnumValues {
    enum Categories {
        Electronics = 1,
        Food = 5,
        Automotive = 6,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15,
        WomanFashion = 15
    }


    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Electronics: " + (int)Categories.Electronics);
            Console.WriteLine("Food: " + (int)Categories.Food);
            Console.WriteLine("Automotive: " + (int)Categories.Automotive);
            Console.WriteLine("Arts: " + (int)Categories.Arts);
            Console.WriteLine("BeautyCare: " + (int)Categories.BeautyCare);
            Console.WriteLine("Fashion: " + (int)Categories.Fashion);
            Console.WriteLine("WomanFashion: " + (int)Categories.WomanFashion);
        }
    }
}