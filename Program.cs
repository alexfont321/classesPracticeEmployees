using System;
using System.Collections.Generic;

namespace classes{

    public class Company {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        public List<Employee> EmployeeList = new List<Employee>();

        // public void ListEmployees (List<Employee> employee) {
        //     Console.WriteLine(employee);
        // }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public Company (string CompanyName, DateTime DateCreated) {
            Name = CompanyName;
            CreatedOn = DateCreated;
        }
    }

    public class Employee {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public DateTime StartDate { get; set; }

    }
    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.

            Company nashSS = new Company("Church of NSS", DateTime.Now); 

            // Create three employees

            Employee Alejandro = new Employee();
            Alejandro.FirstName = "Alejandro";
            Alejandro.LastName = "Font";
            Alejandro.Title = "Messanger Boy";
            Alejandro.StartDate = new DateTime(2018, 10, 04);

            Employee Jonathan = new Employee();
            Jonathan.FirstName = "Jonathan";
            Jonathan.LastName = "Edwards";
            Jonathan.Title = "Bag Boy";
            Jonathan.StartDate = DateTime.Now;

            Employee Streator = new Employee();
            Streator.FirstName = "Streator";
            Streator.LastName = "Ward";
            Streator.Title = "Ball Boy";
            Streator.StartDate = DateTime.Now;

            // Assign the employees to the company

            nashSS.EmployeeList.Add(Streator);
            nashSS.EmployeeList.Add(Alejandro);
            nashSS.EmployeeList.Add(Jonathan);




            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

foreach (Employee employee in nashSS.EmployeeList) {
            Console.WriteLine($"{employee.FirstName} fucking {employee.LastName} the king {employee.Title} joined on {employee.StartDate}");

}


        }
    }
}