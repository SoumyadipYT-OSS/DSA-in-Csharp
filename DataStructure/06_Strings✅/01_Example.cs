using System;


class Program {
    static void Main() {
        string programmingLanguage = "C#";
        string role = "developer";
        string full_role = programmingLanguage + " " + role;
        string full_Concat = string.Concat(programmingLanguage, " ", role);

        Console.WriteLine(full_role);
        Console.WriteLine(full_Concat);
    }
}