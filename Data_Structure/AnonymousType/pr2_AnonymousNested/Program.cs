using System;
using System.Text;

namespace ANONYMOUS_TYPE_NESTED {
    class Solution {
        static void Main(string[] args) {
            var students = new {
                student1 = new { 
                    Id = 1, 
                    firstName = "Soumyadip", 
                    lastName = "Majumder",
                    Address = new {
                        city = "Kolkata",
                        state = "West Bengal",
                        country = "India"
                    }
                },
                student2 = new { Id = 2, 
                    firstName = "Mansish", 
                    lastName = "Mahakul",
                    Address = new {
                        city = "Bhubaneswar",
                        state = "Odisha",
                        country = "India"
                    }
                },
                student3 = new { 
                    Id = 3,
                    firstName = "Subhasis",
                    lastName = "Majee",
                    Address = new {
                        city = "Asansol",
                        state = "West Bengal",
                        country = "India"
                    }
                },
                student4 = new {
                    Id = 4,
                    firstName = "Dishant",
                    lastName = "Yadav",
                    Address = new {
                        city = "Asansol",
                        state = "West Bengal",
                        country = "India"
                    }
                }
            };

            // for loop to print all the students and corresponding address
            // get the length of the students object
#pragma warning disable CS8602
            int length = students.GetType().GetProperties().Length;
            for (int i = 1; i <= length; i++) {
                var student = students.GetType().GetProperty("student" + i).GetValue(students, null);
                Console.WriteLine("Student" + i + ": " + student.GetType().GetProperty("Id").GetValue(student, null) + " " + student.GetType().GetProperty("firstName").GetValue(student, null) + " " + student.GetType().GetProperty("lastName").GetValue(student, null));
                var address = student.GetType().GetProperty("Address").GetValue(student, null);
                Console.WriteLine("Address: " + address.GetType().GetProperty("city").GetValue(address, null) + ", " + address.GetType().GetProperty("state").GetValue(address, null) + ", " + address.GetType().GetProperty("country").GetValue(address, null));
            }
#pragma warning restore CS8602
        }
    }
}