using System;

namespace EmployeeComparisonApp
{
    // Define the Employee class
    class Employee
    {
        // Properties for Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects by their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null (or both are the same instance)
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // Check if one object is null and the other is not
            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            // Return true if the Ids are equal, otherwise false
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator to complement the '==' operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Simply return the opposite of the '==' comparison
            return !(emp1 == emp2);
        }

        // Override the 'Equals' method to ensure it works with the '==' operator
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and compare the Ids
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Override the 'GetHashCode' method as it should be consistent with 'Equals'
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded '==' operator
            if (employee1 == employee2)
            {
                Console.WriteLine("The employees are equal.");
            }
            else
            {
                Console.WriteLine("The employees are not equal.");
            }

            // Compare the two Employee objects using the overloaded '!=' operator
            if (employee1 != employee2)
            {
                Console.WriteLine("The employees are not equal.");
            }
            else
            {
                Console.WriteLine("The employees are equal.");
            }

            // Pause the console to see the results
            Console.ReadLine();
        }
    }
}
