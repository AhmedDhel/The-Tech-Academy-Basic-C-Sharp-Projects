using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message for the shipping company
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // Check if the package is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program
            }

            // Ask the user for the package width, height, and length
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // Check if the total dimensions exceed 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program
            }

            // Calculate the shipping quote: (width * height * length * weight) / 100
            decimal quote = (width * height * length * weight) / 100m;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("F2"));
            Console.WriteLine("Thank you!");
            Console.ReadLine();
            // ==========================================================================

            // ===================== Employee Class Test =====================
            Console.WriteLine("\n=== Employee Operator Test ===");

            // Instantiate the first Employee object and assign properties
            Employee employee1 = new Employee
            {
                Id = 1,
                FirstName = "Ahmed",
                LastName = "Dhel"
            };

            // Instantiate the second Employee object and assign properties
            Employee employee2 = new Employee
            {
                Id = 2,
                FirstName = "Ali",
                LastName = "Hassan"
            };

            // Compare the two Employee objects using overloaded "==" operator
            Console.WriteLine($"employee1 == employee2? {employee1 == employee2}");

            // Compare the two Employee objects using overloaded "!=" operator
            Console.WriteLine($"employee1 != employee2? {employee1 != employee2}");

            Console.WriteLine("Press any key to exit Employee test...");
            Console.ReadKey();
            // ==================================================================
        }
    }

    // ===================== Employee Class =====================
    class Employee
    {
        public int Id { get; set; }           // Employee's unique identifier
        public string FirstName { get; set; } // Employee's first name
        public string LastName { get; set; }  // Employee's last name

        // Overload "==" operator to compare Employee objects by Id
        public static bool operator ==(Employee e1, Employee e2)
        {
            // If both are null, they are equal
            if (ReferenceEquals(e1, null) && ReferenceEquals(e2, null))
                return true;

            // If one is null, they are not equal
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null))
                return false;

            // Compare the Id properties
            return e1.Id == e2.Id;
        }

        // Overload "!=" operator (must be paired with "==")
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2); // Negate the "==" result
        }

        // Override Equals method to match operator behavior
        public override bool Equals(object obj)
        {
            return this == obj as Employee;
        }

        // Override GetHashCode method to match Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

