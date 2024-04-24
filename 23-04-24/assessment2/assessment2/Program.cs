using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeID = 1, Name = "Jim Carry", Salary = 7000 },
            new Employee { EmployeeID = 2, Name = "Tom", Salary = 5500 },
            new Employee { EmployeeID = 3, Name = "Tobey Magure", Salary = 8000 },
            new Employee { EmployeeID = 4,  Name = "Depp", Salary = 7500 }
        };

        //Salary(employees);
        //Salary2(employees);

        NameValidation(employees);
        //NameValidation2(employees);
    }

    static void Salary(List<Employee> employees)
    {
        var result = from employee in employees
                     where employee.Salary >= 6000 && employee.Salary <= 8000
                     select employee;

        Console.WriteLine("Employees whose salary is between 6000 and 8000:");
        foreach (var employee in result)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
        }

    }

    static void Salary2(List<Employee> employees)
    {
        var result = employees.Where(employee => employee.Salary > 6000 && employee.Salary < 8000);

        Console.WriteLine("Employees whose salary is between 6000 and 8000:");
        foreach (var employee in result)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }

    static void NameValidation(List<Employee> employees)
    {
        var result = from employee in employees
                     where employee.Name.Length < 4
                     select employee;

        Console.WriteLine("Employees whose name contains less than 4 characters:");
        foreach (var employee in result)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");

        }


    }

    static void NameValidation2(List<Employee> employees)
    {
        var result = employees.Where(employee => employee.Name.Length < 4);

        Console.WriteLine("Employees whose name contains less than 4 characters:");
        foreach (var employee in result)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}

class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
