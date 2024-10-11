using System;

/* Used for Example 1*/
class Person {
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age) {
        Name = name;
        Age = age;
    }

    // Override Equals method to compare Person objects based on Name and Age
    public override bool Equals(object obj) {
        if (obj is Person other) {
            return Name == other.Name && Age == other.Age;
        }
        return false;
    }

    // Override GetHashCode method to ensure consistency with Equals
    public override int GetHashCode() {
        return (Name, Age).GetHashCode();
    }
}


/* Used for Example 2*/
class Tree {
    public string Name { get; }
    public int Height { get; }

    public Tree(string n, int h) {
        Name = n;
        Height = h;
    }

    // Override Equals method to compare Tree objects based on Name and Height
    public override bool Equals(object obj) {
        if (obj is Tree other) {
            return Name == other.Name && Height == other.Height;
        }
        return false;
    }

    // Override GetHashCode method to ensure consistency with Equals
    public override int GetHashCode() {
        return (Name, Height).GetHashCode();
    }
}


/* Used for Example 6 */
class TATA_Motors {
    public string Model { get; }
    public int Year { get; }

    public TATA_Motors(string m, int y) {
        Model = m;
        Year = y;
    }

    // Override Equals method to compare TATA Motors objects based on Model and Year
    public override bool Equals(object obj) {
        if (obj is TATA_Motors other) {
            return Model == other.Model && Year == other.Year;
        }
        return false;
    }

    // Override GetHashCode method to ensure consistency with Equals
    public override int GetHashCode() {
        return (Model, Year).GetHashCode();
    }
}




class Program {
    protected static void Example1() {
        Person[] people = {
            new Person("Ashutosh", 21),
            new Person("Prayash", 22),
            new Person("Mansish", 21),
            new Person("Soumyadip", 20),
            new Person("Subhasis", 22),
            new Person("Dishant", 21)
        };

        // Define the target
        Person target = new Person("Soumyadip", 20);

        int index = Array.LastIndexOf(people, target);
        Console.WriteLine("Last index of target person: " + index);

        // Display the details of the found person
        if (index != -1) {
            Console.WriteLine($"Found {people[index].Name}, Age: {people[index].Age} at index {index}");
        } else {
            Console.WriteLine("Person not found!");
        }
    }

    protected static void Example2() {
        Tree[] forest = {
            new Tree("Oak", 50),
            new Tree("Pine", 30),
            new Tree("Birch", 20),
            new Tree("Oak", 40),
            new Tree("Maple", 60),
            new Tree("Oak", 50)
        };

        // Define the target
        Tree target = new Tree("Maple", 60);

        int index = Array.LastIndexOf(forest, target, 4);
        Console.WriteLine("Last index of target tree starting from index: " + index);

        // Display the details of the found tree
        if (index != -1) {
            Console.WriteLine($"Found {forest[index].Name}, Height: {forest[index].Height} at index {index}");
        } else {
            Console.WriteLine("Tree not found.");
        }
    }

    protected static void Example3() {
        int[] num = { 1, 2, 3, 4, 3, 2, 1 };

        // Find the last occurrence of 3, starting from index 4 and searching 4 elements
        int index = Array.LastIndexOf(num, 3, 4, 4);
        Console.WriteLine("Last index of 3 starting from index 4 and searching 4 elements: " + index); // Output: 2
    }

    protected static void Example4() {
        string[] fruits = { "apple", "banana", "cherry", "apple", "date", "banana", "apple" };

        // Find the last occurrence of "apple"
        int index = Array.LastIndexOf(fruits, "apple");
        Console.WriteLine("Last index of 'apple': " + index);   // Output: 6
    }

    protected static void Example5() {
        string[] fruitBasket = { "apple", "guava", "pineapple", "cherry", "apple", "dates", "pineapple", "apple" };

        // Find the last occurrence of 'pineapple', starting from index 5 (it will take less time for  backward iteration)
        /*
            apple guava pineapple cherry apple dates 
                          ||*||  <-- cherry <-- apple <-- dates <-- itr begins()
         */
        int index = Array.LastIndexOf(fruitBasket, "pineapple", 5);
        Console.WriteLine($"Last index of 'pineapple' starting from index 5: {index}");
    }

    protected static void Example6() {
        TATA_Motors[] cars = {
            new TATA_Motors("Nexon", 2022),
            new TATA_Motors("Harrier", 2021),
            new TATA_Motors("Safari", 2023),
            new TATA_Motors("Nexon", 2020),
            new TATA_Motors("Altroz", 2022),
            new TATA_Motors("Nexon", 2022),
            new TATA_Motors("Punch", 2021)
        };

        // Define target
        TATA_Motors target = new TATA_Motors("Nexon", 2022);

        // Find the last occurrence of the target TataMotors, starting from index 6 and searching 5 elements
        int index = Array.LastIndexOf(cars, target, 6, 5);
        Console.WriteLine("Last index of target car starting from index 6 and searching 5 elements: " + index);

        if (index != -1) Console.WriteLine($"Found {cars[index].Model}, Year: {cars[index].Year} at index {index}");
        else Console.WriteLine("Car not found!");
    }



    // Main method
    static void Main() {
        Console.WriteLine("__Example 1__");
        Example1();
        Console.WriteLine("\n__Example 2__");
        Example2();
        Console.WriteLine("\n__Example 3__");
        Example3();
        Console.WriteLine("\n__Example 4__");
        Example4();
        Console.WriteLine("\n__Example 5__");
        Example5();
        Console.WriteLine("\n__Example 6__");
        Example6();
    }
}