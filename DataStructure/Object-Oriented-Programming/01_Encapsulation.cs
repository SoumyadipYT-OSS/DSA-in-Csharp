using System;

namespace EncapsulationTopic {
    // Base class
    class Person {
        private string name;    // Private field - accessible only within this class
        // Public property - accessible from outside the class
        public string Name {
            get { return name; }
            set { name = value; }
        }
        protected int age;  // Protected field - accessible within this class and derived class
        internal string Address { get; set; }   // Internal field - accessible within the same assembly
        protected internal string PhoneNumber { get; set; }     // Protected internal field - accessible within the same assembly or derived class
        private protected string Email { get; set; }    // Private protected field - accessible within this class or derived classes in the same assembly


        // Public method - accessible from outside the class
        public void DisplayInfo() {
            Console.WriteLine($"Name: {Name}, Age: {age}, Address: {Address}, Phone: {PhoneNumber}, Email: {Email}");
        }
    }


    // Derived class
    class Employee : Person {
        // Public method to set protected field
        public void SetAge(int empAge) {
            age = empAge;   // Accessing protected field
        }

        // Public method to set private protected field
        public void SetEmail(string employeeEmail) {
            Email = employeeEmail;  // Accessing private protected field
        }
    }



    class Program {
        static void Main() {
            // Create an object of the Person class
            Person person = new Person();
            person.Name = "John Doe";
            person.Address = "123 Main St";
            person.PhoneNumber = "555-1234";

            // Create an object of the Employee class
            Employee employee = new Employee();
            employee.Name = "Jane Smith";
            employee.Address = "456 Elm St";
            employee.PhoneNumber = "555-5678";
            employee.SetAge(30);
            employee.SetEmail("jane.smith@example.com");

            // Display information
            person.DisplayInfo();
            employee.DisplayInfo();
        }
    }
}
