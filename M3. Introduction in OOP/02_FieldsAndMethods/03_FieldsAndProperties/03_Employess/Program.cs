using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Employess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pesho 120.00 Dev Development pesho@abv.bg 28
            int employeesCount = int.Parse(Console.ReadLine());
            Employee employee = null;
            Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < employeesCount; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                double salary = double.Parse(info[1]);
                string position = info[2];
                string department = info[3];

                if (info.Length == 6)
                {
                    employee = new Employee(name, salary, position, department, info[4], int.Parse(info[5]));
                }
                else if (info.Length == 5)
                {
                    //Toncho 333.33 Manager Marketing 33
                    //Ivan 840.20 ProjectLeader Development ivan @ivan.com

                    int age;
                    bool result = int.TryParse(info[4], out age);
                    if(result)//true
                    {
                        employee = new Employee(name, salary, position, department, age);
                    }
                    else
                    {
                        employee = new Employee(name, salary, position, department, info[4]);
                    }
                }
                else
                {
                    employee = new Employee(name, salary, position, department);
                }
                if (!employees.ContainsKey(department))
                {
                    employees.Add(department, new List<Employee>());
                }
                employees[department].Add(employee);
            }

            var sorted = employees.OrderByDescending(x => x.Value.Average(e => e.Salary)).FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {sorted.Key}");

            foreach (var emp in sorted.Value
                .Where(k => k.Department == sorted.Key)
                .OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(emp);
            }
        }
    }
}
