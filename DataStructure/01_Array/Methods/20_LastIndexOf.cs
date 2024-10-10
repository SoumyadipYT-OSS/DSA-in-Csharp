using System;

/* Used for example 1*/
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
        return GetHashCode().Combine(Name, Age);
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
    }
}