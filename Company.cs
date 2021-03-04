using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some read only properties (let's talk about gets, baby)
        public DateTime Founded { get; }
        public string Name { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> CurrentEmployees { get; set; }


        /*
    Create a constructor method that accepts two arguments:
        1. The name of the company
        2. The date it was created

    The constructor will set the value of the public properties
*/
        public Company(string nameOfCompany, DateTime dateFounded)
        {
            Name = nameOfCompany;
            Founded = dateFounded;

        }

        // Show Employees with a method
        public void ShowEmployees(List<Employee> CurrentEmployees)
        {
            Console.WriteLine($"{CurrentEmployees}");
        }



    }
}