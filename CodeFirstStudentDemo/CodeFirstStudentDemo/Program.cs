using System;
using System.Collections.Generic;

namespace CodeFirstStudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var students = new List<Student>()
                {
                    new Student { StudentName = "Ahmed Ali" },
                    new Student { StudentName = "Sarah Johnson" },
                    new Student { StudentName = "Michael Smith" },
                    new Student { StudentName = "Emily Davis" }
                };

                context.Students.AddRange(students);
                context.SaveChanges();

                Console.WriteLine("Students added successfully!");
            }

            Console.ReadLine();
        }
    }
}
