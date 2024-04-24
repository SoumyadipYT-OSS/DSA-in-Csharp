using System;
using System.Text;

namespace ANONYMOUS_TYPE_INITIALIZATION {
    class Solution {
        static void Main(string[] args) {
            var student = new { Id = 1, firstName = "Soumyadip", LastName = "Majumder" };
            Console.Write(student.Id+" "+student.firstName+" "+student.LastName);

            // student.Id = 2; // Error: Property or indexer 'AnonymousType<int, string, string>.Id' cannot be assigned to -- it is read only
            // student.firstName = "TeamIND S"; // Error: Property or indexer 'AnonymousType<int, string, string>.firstName' cannot be assigned to -- it is read only
        }
    }
}