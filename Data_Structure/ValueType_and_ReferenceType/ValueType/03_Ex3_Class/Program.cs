using System;

// Here, we change class type using value type concept

namespace Example3_Class 
{
    public class MyClass {
#pragma warning disable CS8618
        public string str;
#pragma warning restore CS8618
    }


    class Solution {
        protected static void ChangeClassValue(MyClass my_class) {
            my_class.str = "New class value";
            Console.WriteLine(my_class.str);
        }

        // Main Method
        static void Main(string[] args) {
            MyClass obj = new MyClass();

            obj.str = "Old class value";

            Console.WriteLine(obj.str);

            ChangeClassValue(obj);

            Console.WriteLine(obj.str);
        }
    }
}
