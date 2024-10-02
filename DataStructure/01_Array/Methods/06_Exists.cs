using System;

// For Example 2
public class StringSearcher {
    char firstChar;

    public StringSearcher(char firstChar) {
        this.firstChar = char.ToUpper(firstChar);
    }

    public bool StartsWith(string s) {
        if (string.IsNullOrEmpty(s)) return false;

        if (s.Substring(0, 1).ToUpper() == firstChar.ToString()) return true;
        else return false;
    }
}


class Program {
    protected static void Example1() {
        string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

        Console.WriteLine("One or more planets begin with 'M': {0}", Array.Exists(planets, element => element.StartsWith("M")));
        Console.WriteLine("One or more planets begin with 'T': {0}", Array.Exists(planets, element => element.StartsWith("T")));
        Console.WriteLine("Is Pluto one of the planets? {0}", Array.Exists(planets, element => element == "Pluto"));
    }

    protected static void Example2() {
        string[] names = { "Arjun", "Bheem", "Dishant", "Subhasis", "Soumyadip", "Subhadip", "Ashutosh", "Nikhil", "Aparesh",
                            "Sanjana", "Sriya", "Rosali", "Anandita", "Riya", "Sanket", "Mansish", "Saswat",
                            "Shreyansh", "Uditya", "Himanshu", "Dipanshu", "Harshit", "Yaashi", "Saumyakanti",
                            "Nishant", "Prayash" };

        char[] charsToFind = { 'A', 'P', 'M', 'Y' };

        foreach (var findchar in charsToFind) {
            Console.WriteLine("One or more names begin with {0} : {1}", findchar, Array.Exists(names, (new StringSearcher(charsToFind)).StartsWith);
        }
    }

    protected static void Example3() {
        string[] programmingLanguages = { "C#", "Python", "C++", "TypeScript", "COBOL",
                                            "JavaScript", "Pearl", "Ruby", "R", "C",
                                            "GoLang", "Elixir", "CUDA", "Java", "Solidity" };

        char[] findChars = { 'C', 'E', 'R', 'P' };

        foreach (var cFind in findChars) {
            Console.WriteLine("One or more names begin with {0}: {1}", cFind, Array.Exists(programmingLanguages, s => {
                if (string.IsNullOrEmpty(s))
                    return false;
                if (s.Substring(0, 1).ToUpper())
                    return true;
                else
                    return false;
            }));
        }
    }
}