using System;

namespace ParameterizedConstructor_on_Csharp {
    struct Student {
        public int registrationNumber;
        public string studentName;
        public int rollNumber;

        public Student(int regdNo, string name, int rollNo) {
            this.registrationNumber = regdNo;
            this.studentName = name;
            this.rollNumber = rollNo;
        }
    }

    public class Solution {
        static void Main(string[] args) {
            Student s1 = new Student(5896412, "Chulbul", 1);
            Student s2 = new Student(8651233, "Sephali", 2);

            Console.WriteLine("_Student 1_");
            Console.WriteLine("Name: " + s1.studentName);
            Console.WriteLine("Registration Number: " + s1.registrationNumber);
            Console.WriteLine("Roll Number: " + s1.rollNumber);

            Console.WriteLine("\n_Student 2_");
            Console.WriteLine("Name: " + s2.studentName);
            Console.WriteLine("Registration Number: " + s2.registrationNumber);
            Console.WriteLine("Roll Number: " + s2.rollNumber);
        }
    }
}