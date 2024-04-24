using System;
using System.Text;


namespace INTERNAL_NAME_ANONYMOUS_TYPE {
    class Solution {
        static void Main(string[] args) {
            var student = new { ID = 1, firstName = "Soumyadip", lastName = "Majumder" };
            Console.WriteLine(student.GetType().ToString());
        }
    }
}