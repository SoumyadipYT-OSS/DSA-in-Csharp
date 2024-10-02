using System;
using System.Collections;
using System.Collections.Generic;

// For BinarySearchExample 2 it is needed (based on System.Collections)
public class CaseInsensitiveComparer : IComparer {
    public int Compare(object x, object y) {
        return string.Compare(x?.ToString(), y?.ToString(), StringComparison.OrdinalIgnoreCase);
    }
}


// For BinarySearchExample 5
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
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };
        Array.Sort(numbers);

        int valueToFind = 7;

        // BinarySearch(Array, Object, IComparer)
        int index = Array.BinarySearch<int>(numbers, valueToFind);

        if (index >= 0) Console.WriteLine($"Value {valueToFind} Found at index {index}");
        else Console.WriteLine($"Not found. Nearest index: {~index}");
    }

    protected static void BinarySearchExample5() {
        Person[] people = {
            new Person("Subhasis Majee", 22),
            new Person("Dishant Yadav", 21),
            new Person("Soumyadip Majumder", 21),
            new Person("Swarup Karmakar", 20),
            new Person("Sayan Chowdhury", 21),
            new Person("Silad Roy Chowdhury", 22)
        };
        Array.Sort(people, new PersonComparer());

        Person personToFind = new Person("Soumyadip Majumder", 21);

        // BinarySearch(T[], T, IComparer)
        int index = Array.BinarySearch(people, personToFind, new PersonComparer());

        if (index >= 0) Console.WriteLine($"Person {personToFind.Name} found at index {index}");
        else Console.WriteLine($"Not found. Nearest index: {~index}.");
    }




    // Main method
    static void Main(string[] args) {
        BinarySearchExample1();
    }
}