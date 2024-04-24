/*
 If you assign a class object to the dynamic type, then the compiler would not check correct methods
and properties name of a dynamic type that holds the custom class object.
*/


namespace DYNAMIC_TYPE_METHODS_PARAMETERS {
    class Solution {
        static void Main(string[] args) {
            dynamic stud = new Student();

            // stud.DisplayStudentInfo("Soumyadip", 25);  This will throw runtime error because of wrong method name
        }
    }

    public class Student {
        public static void DisplayStudentInfo(string name, int age) {
            Console.WriteLine("Name: {0}, Age: {1}", name, age);
        }
    }
}