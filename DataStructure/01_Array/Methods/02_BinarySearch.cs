using System;
using System.Collections;
using System.Collections.Generic;

// For BinarySearchExample 2 it is needed (based on System.Collections)
public class CaseInsensitiveComparer : IComparer {
    public int Compare(object x, object y) {
        return string.Compare(x?.ToString(), y?.ToString(), StringComparison.OrdinalIgnoreCase);
    }
}


// For BinarySearchExample 4
public class Car {
    public string Make { get; }
    public int Year { get; }

    public Car(string make, int year) {
        Make = make;
        Year = year;
    }
}
public class CarComparer : CaseInsensitiveComparer {
    public int Compare(object x, object y) {
        if (x == null  ||  y == null) {
            return 0;
        }
        return ((Car)x).Make.CompareTo(((Car)y).Make);
    }
}


// For BinarySearchExample 6
public class Person {
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
}
public class PersonComparer : IComparer<Person> {
    public int Compare(Person x, Person y) {
        if (x == null  ||  y == null) {
            return 0;
        }
        return x.Name.CompareTo(y.Name);
    }
}



class BinarySearchMethods {
    protected static void BinarySearchExample1() {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };
        Array.Sort(numbers);

        int valueToFind = 7;

        // BinarySearch(Array, Object)
        int index = Array.BinarySearch(numbers, valueToFind);

        if (index >= 0) Console.WriteLine($"Value {valueToFind} found at index {index}.");
        else Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");

    }

    protected static void BinarySearchExample2() {
        string[] fruits = { "Apple", "Banana", "Cherry", "Dates", "Fig", "Grape" };
        Array.Sort(fruits);

        string valueToFind = "Dates";

        // BinarySearch(Array, Object, IComparer)
        int index = Array.BinarySearch(fruits, valueToFind, new CaseInsensitiveComparer());

        if (index >= 0) Console.WriteLine($"Value: {valueToFind} found at index {index}.");
        else Console.WriteLine($"Value: {valueToFind} not found. Nearest index: {~index}.");
    }

    protected static void BinarySearchExample3() {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        Array.Sort(numbers);

        int startIndex = 0;
        int length = 5;

        int valueToFind = 11;

        // BinarySearch(Array, Int32, Int32, Object)
        int index = Array.BinarySearch(numbers, startIndex, length, valueToFind);

        if (index >= 0) Console.WriteLine($"Value {valueToFind} found at index {index}.");
        else Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");
    }

    protected static void BinarySearchExample4() {
        Car[] cars = {
            new Car("Toyota", 2015),
            new Car("Tata", 2016),
            new Car("Eicher", 2012),
            new Car("Mahindra", 2018),
            new Car("BMW", 2020),
            new Car("Aston Martin", 2022)
        };
        Array.Sort(cars, new CarComparer());

        int startIndex = 1;
        int length = 3;

        Car carToFind = new Car("Aston Martin", 2022);

        // BinarySearch(Array, Int32, Int32, Object, IComparer)
        int index = Array.BinarySearch(cars, startIndex, length, carToFind, new CarComparer());

        if (index >= 0) Console.WriteLine($"Car {carToFind.Make} found at index {index}.");
        else Console.WriteLine($"Car {carToFind.Make} not found. Nearest index: {~index}.");
    }

    protected static void BinarySearchExample5() {
        // Create and sort an array of integers
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };
        Array.Sort(numbers);

        // Value to search for
        int valueToFind = 7;

        // BinarySearch(T[], T)
        int index = Array.BinarySearch<int>(numbers, valueToFind);

        // Check the result
        if (index >= 0) Console.WriteLine($"Value {valueToFind} found at index {index}.");
        else Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");
    }

    protected static void BinarySearchExample6() {

    }


    // Main method
    static void Main(string[] args) {
        BinarySearchExample1();
    }
}