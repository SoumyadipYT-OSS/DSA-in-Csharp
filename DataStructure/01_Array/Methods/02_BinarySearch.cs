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


// For BinarySearchExample 6 and BinarySearchExample 8
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
        Person[] people = {
            new Person("Subhasis Majee", 22),
            new Person("Dishant Yadav", 21),
            new Person("Soumyadip Majumder", 21),
            new Person("Silad Roy Chowdhury", 22),
            new Person("Swarup Karmakar", 21),
            new Person("Sayan Chowdhury", 21),
            new Person("Shubhomoy Kumar Roy", 29),
            new Person("Subhajit Paul", 27),
            new Person("Shivpatta Naik", 28)
        };
        Array.Sort(people, new PersonComparer());

        Person personToFind = new Person("Sayan Chowdhury", 21);
        int index = Array.BinarySearch(people, personToFind, new PersonComparer());

        if (index >= 0) Console.WriteLine($"Person {personToFind.Name} found at index {index}.");
        else Console.WriteLine($"Person {personToFind.Name} not found. Nearest index: {~index}.");
    }

    protected static void BinarySearchExample7() {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        Array.Sort(numbers);

        // Define the range to search within
        int startIndex = 2; // Starting index of the range
        int length = 5;     // Number of elements in the range

        // Value to search for
        int valueToFind = 11;

        // BinarySearch(T[], Int32, Int32, T)
        int index = Array.BinarySearch<int>(numbers, startIndex, length, valueToFind);

        // Check the result
        if (index >= 0) Console.WriteLine($"Value {valueToFind} found at index {index}.");
        else Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");
    }

    protected static void BinarySearchExample8() {
        Person[] footballers = {
            new Person("Sunil Chhetri", 37),
            new Person("Subhasis Bose", 30),
            new Person("Manvir Singh", 25),
            new Person ("Pritam Kotal", 26),
            new Person("Gurpreet Singh Sandhu", 29),
            new Person("Udanta Singh", 24),
            new Person("Ashique Kuruniyan", 23),
            new Person("Anirudh Thapa", 23),
            new Person("Suresh Singh Wangjam", 21)
        };
        Array.Sort(footballers, new PersonComparer());

        int startIndex = 1; // Starting index of the range
        int length = 3;     // Number of elements in the range

        Person personToFind = new Person("Charlie", 35);

        // BinarySearch(T[], Int32, Int32, T, IComparer)
        int index = Array.BinarySearch(people, startIndex, length, personToFind, new PersonComparer());

        // Check the result
        if (index >= 0) Console.WriteLine($"Person {personToFind.Name} found at index {index}.");
        else Console.WriteLine($"Person {personToFind.Name} not found. Nearest index: {~index}.");
    }



    // Main method
    static void Main(string[] args) {
        Console.WriteLine("----Binary Search Examples----");
        Console.WriteLine("BinarySearch(Array, Object)");
        BinarySearchExample1();
        Console.WriteLine("\nBinarySearch(Array, Object, IComparer)");
        BinarySearchExample2();
        Console.WriteLine("\nBinarySearch(Array, Int32, Int32, Object)");
        BinarySearchExample3();
        Console.WriteLine("\nBinarySearch(Array, Int32, Int32, Object, IComparer)");
        BinarySearchExample4();
        Console.WriteLine("\nBinarySearch(T[], T)");
        BinarySearchExample5();
        Console.WriteLine("\nBinarySearch(T[], T, IComparer)");
        BinarySearchExample6();
        Console.WriteLine("\nBinarySearch(T[], Int32, Int32, T)");
        BinarySearchExample7();
        Console.WriteLine("\nBinarySearch(T[], Int32, Int32, T, IComparer)");
        BinarySearchExample8();
    }
}