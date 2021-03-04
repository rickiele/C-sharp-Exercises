using System;
using System.Collections.Generic;

namespace Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            DateTime date = new DateTime(1999, 12, 1);
            Company happybabiesco = new Company("Happy Babies Co.", date);


            // Create three employees
            Employee hannah = new Employee()
            {
                FirstName = "Hannah",
                LastName = "Banana",
                Title = "Baby Feeder",
                StartDate = new DateTime(1928, 11, 2)

            };

            Employee pedro = new Employee()
            {
                FirstName = "Pedro",
                LastName = "Parsnip",
                Title = "Baby Burper",
                StartDate = new DateTime(1928, 11, 2)

            };

            Employee rachel = new Employee()
            {
                FirstName = "Rachel",
                LastName = "Rutabaga",
                Title = "Baby Cuddler",
                StartDate = new DateTime(1928, 11, 2)

            };

            // New list, and assign employees inside
            List<Employee> assignEmployees = new List<Employee>()
            {
                hannah, pedro, rachel

            };


            // Assign the employees to the company
            // You need get the company you're using 'happybabiesco'
            // and use Company's CurrentEmployees property to set the list of assignEmployees (which contains hannah, pedro, rachel)
            happybabiesco.CurrentEmployees = assignEmployees;



            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            foreach (Employee person in happybabiesco.CurrentEmployees)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} works for {happybabiesco.Name} as a {person.Title} since {person.StartDate}.");
            }

            happybabiesco.ShowEmployees(assignEmployees);

        }
    }

}
