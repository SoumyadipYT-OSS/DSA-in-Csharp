/*
    A class is a blueprint for creating objects. 
    It defines properties and methods that the objects created 
    from the class will have. An object is an 
    instance of a class.
*/


using System;

namespace ClassesAndObjects {
    // Define a class named 'Car'
    class Car {
        // Fields (or properties) of the class
        public string make;
        public string model;
        public int year;

        // Method of a class
        public void DisplayInfo() {
            Console.WriteLine($"Car: {year} {make} {model}");
        }
    }


    class Program {
        static void Main(string[] args) {
            // Create an object of the 'Car' class
            Car myCar = new Car();

            // Set the fields of the object
            myCar.make = "Toyota";
            myCar.model = "Corolla";
            myCar.year = 2020;

            // Call the method of the object
            myCar.DisplayInfo();




            // Create another object of the 'Car' class
            Car anotherCar = new Car();

            // Set the fields of the object
            anotherCar.make = "TATA";
            anotherCar.model = "Exter";
            anotherCar.year = 2022;

            // Call the method of the second object
            anotherCar.DisplayInfo();
        }
    }
}