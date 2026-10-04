// Use Console to show messages.
using System;

namespace EmployeeComparison
{
    // Store employee details here.
    public class Employee
    {
        // Store the employee's ID and name.
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        // Check if two employees have the same ID.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // The same object, or two null values, are equal.
            if (object.ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // They are not equal if only one is null.
            if (object.ReferenceEquals(employee1, null) ||
                object.ReferenceEquals(employee2, null))
            {
                return false;
            }

            // Compare the employee IDs.
            return employee1.Id == employee2.Id;
        }

        // Check if the employees are not equal.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        // Use the same rule for the Equals method.
        public override bool Equals(object obj)
        {
            return this == (obj as Employee);
        }

        // Use the ID for the hash code.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Run the console app.
    class Program
    {
        // The app starts here.
        static void Main(string[] args)
        {
            // Create the first employee.
            Employee employee1 = new Employee();
            employee1.Id = 101;
            employee1.FirstName = "Ibrar";
            employee1.LastName = "Ali";

            // Create the second employee with the same ID.
            Employee employee2 = new Employee();
            employee2.Id = 101;
            employee2.FirstName = "Ali";
            employee2.LastName = "Raza";

            // Show the results of both comparisons.
            Console.WriteLine("Are employees equal? " +
                (employee1 == employee2));

            Console.WriteLine("Are employees different? " +
                (employee1 != employee2));

            // Change the second employee's ID.
            employee2.Id = 102;

            // Show the results again with different IDs.
            Console.WriteLine("After changing the second employee's ID:");

            Console.WriteLine("Are employees equal? " +
                (employee1 == employee2));

            Console.WriteLine("Are employees different? " +
                (employee1 != employee2));

            // Wait for a key before closing.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}