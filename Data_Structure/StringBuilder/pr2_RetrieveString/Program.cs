/*
    Retrieve String from StringBuilder
    -------------------------------
    To retrieve a string from a StringBuilder object, you can use the ToString() method. 
    The ToString() method returns a string that represents the current StringBuilder object.
 */

using System;
using System.Text;

namespace RetrieveString {
    class RetrieveStringBuilder {
        static void Main(string[] args) {
            StringBuilder sb = new StringBuilder("Hello Programmer!");
            var greet = sb.ToString();

            Console.WriteLine(greet);
        }
    }
}