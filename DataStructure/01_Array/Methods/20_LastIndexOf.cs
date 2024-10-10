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
        Console.WriteLine("Last index of target tree starting from index 4: " + index);

        // Display the details of the found tree
        if (index ! = -1) {
            Console.WriteLine($"Found {forect[index].Name}, Height: {forest[index].Height} at index {index}");
        } else {
            Console.WriteLine("Tree not found.");
        }
    }



    // Main method
    static void Main() {
        Console.WriteLine("__Example 1__");
        Example1();
        Console.WriteLine("__Example 2__");
        Example2();
    }
}