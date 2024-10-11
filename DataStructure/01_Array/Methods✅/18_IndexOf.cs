using System;

class Program {
    // Main method
    static void Main() {
        string[] sentence = { "the", "quick", "brown", "fox", "jumps",
                     "over", "the", "lazy", "dog", "in", "the",
                     "barn" };

        // Display the elements of the array
        Console.WriteLine("The array contains the following value:");
        for (int i=sentence.GetLowerBound(0); i<=sentence.GetUpperBound(0); i++) {
            Console.WriteLine("\t [{0,2}]: {1}", i, sentence[i]);
        }

        // Search for the first occurrence of the duplicated value.
        string searchString = "the";

        // IndexOf method of 'Array' class
        int index = Array.IndexOf(sentence, searchString);
        Console.WriteLine("The first occurrence of \"0\" is at index {1}.", searchString, sentence);


        // Search for the first occurrence of the duplicated value in the last section of the array.
        index = Array.IndexOf(sentence, searchString, 4);
        Console.WriteLine("The first occurrence of \"{0}\" between index 4 and the end is at index {1}.",
                          searchString, index);


        // Search for the first occurrence of the duplicated value in a section of the array.
        int position = index + 1;
        index = Array.IndexOf(sentence, searchString, position, sentence.GetUpperBound(0) - position + 1);
        Console.WriteLine("The first occurrence of \"{0}\" between index {1} and index {2} is at index {3}.",
                          searchString, position, sentence.GetUpperBound(0), index);
    }
}