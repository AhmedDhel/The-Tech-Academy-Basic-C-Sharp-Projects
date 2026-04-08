using System;

namespace MethodsAndObjectsApp
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        // Declare a void method Quit() that must be implemented by any class that implements this interface
        void Quit();
    }

    // Person class from the previous assignment
    class Person
    {
        // Properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to print full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }

    // Employee class inherits from Person and implements IQuittable
    class Employee : Person, IQuittable
    {
        // Additional property specific to Employee
        public int Id { get; set; }

        // Implement the Quit() method from IQuittable
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Employee Quit Interface Demo");

            // Instantiate an Employee object with sample data
            Employee employee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 101
            };

            // Call the SayName() method inherited from Person
            employee.SayName();

            // Polymorphism: assign Employee object to IQuittable variable
            IQuittable quittableEmp = employee;

            // Call the Quit() method using the interface type
            quittableEmp.Quit();

            // Pause the console so the user can see the results
            Console.ReadLine();
        }
    }
}
