using System;
using System.Text;

namespace LINQ_AnonymousType {
    class Solution {
        static void Main(string[] args) {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "Soumyadip", age = 20 },
                new Student() { StudentID = 2, StudentName = "Subhasis", age = 21 },
                new Student() { StudentID = 3, StudentName = "Mansish", age = 20 }
            };

            var students = from s in studentList
                           select new {
                               id = s.StudentID,
                               name = s.StudentName
                           };

            foreach (var stud in students)
                Console.WriteLine(stud.id + " " + stud.name);
        }
    }


    public class Student {
        public int StudentID { get; set; }
#pragma warning disable CS8618  // CS8618 Non-nullable field is uninitialized. Consider declaring as nullable.
        public string StudentName { get; set; }
#pragma warning restore CS8618
        public int age { get; set; }
    }
}