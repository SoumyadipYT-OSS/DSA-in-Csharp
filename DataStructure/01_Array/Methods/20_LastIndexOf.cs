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



    // Main method
    static void Main() {
        Console.WriteLine("__Example 1__");
        Example1();
    }
}