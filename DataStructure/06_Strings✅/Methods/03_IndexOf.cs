using System;


class Program {
    static void Main() {
        string str = "fruit";
        int index = str.IndexOf('u');

        string str2 = "vegetable";
        int index2 = str2.IndexOf('e');     // takes the first occur letter


        Console.WriteLine(index);
        Console.WriteLine(index2);
    }
}