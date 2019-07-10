using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        // Properties
        public DateTime CreatedOn { get; }
        public string Name { get; }
        public List<Employee> _employees = new List<Employee>();

        // Constructor
        public Company(string name, DateTime dateFounded)
        {
            Name = name;
            CreatedOn = dateFounded;
        }

        // Methods
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public void ListEmployees()
        {
            Console.WriteLine("");
            Console.WriteLine($"{Name} Employees:");
            foreach (Employee employee in _employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} is the {employee.Title} at {Name}...");
            }
        }
    }
}