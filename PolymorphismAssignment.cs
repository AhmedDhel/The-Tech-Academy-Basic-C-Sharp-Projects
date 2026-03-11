using System;

namespace PolymorphismAssignment
{
    // This interface defines a contract that any implementing class must follow
    // It requires a method called Quit that returns nothing (void)
    interface IQuittable
    {
        void Quit(); // Method signature with no implementation
    }

    // The Employee class implements the IQuittable interface
    // This means Employee must provide an implementation of Quit()
    class Employee : IQuittable
    {
        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Property to store the employee ID
        public int Id { get; set; }

        // Implementation of the Quit() method required by the IQuittable interface
        public void Quit()
        {
            // Print a message indicating the employee has quit
            Console.WriteLine(FirstName + " " + LastName + " has quit the job.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Employee object
            Employee emp = new Employee();

            // Assign values to the employee properties
            emp.FirstName = "Ahmed";
            emp.LastName = "Dhel";
            emp.Id = 1;

            // Demonstrate polymorphism
            // Create an object of type IQuittable and assign it the Employee object
            IQuittable quittableEmployee = emp;

            // Call the Quit() method using the interface reference
            quittableEmployee.Quit();

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}
