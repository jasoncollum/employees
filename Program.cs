using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company musicStore = new Company("Music Store", DateTime.Now);

            musicStore.AddEmployee(new Employee() { FirstName = "Nate", LastName = "Fleming", Title = "Master of Percussion" });
            musicStore.AddEmployee(new Employee() { FirstName = "Fred", LastName = "Rogers", Title = "Friend of Pianos" });
            musicStore.AddEmployee(new Employee() { FirstName = "Bertha", LastName = "Triangle", Title = "Assistant to Master of Percussion" });

            musicStore.ListEmployees();
        }
    }
}
