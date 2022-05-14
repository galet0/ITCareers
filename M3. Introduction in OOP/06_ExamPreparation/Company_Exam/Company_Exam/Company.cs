using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Exam
{
    class Company
    {
        private string name;
        private string city;
        private List<Employee> employees;

        public Company(string name, string city)
        {
            Name = name;
            City = city;
            this.employees = new List<Employee>();
        }

        public string Name
        {
            get { return name; }
            private set { 
                if(value.Length < 3)
                {
                    throw new ArgumentException("Invalid company name");
                }
                name = value; }
        }
        public string City
        {
            get { return city; }
            private set {
                if(value.Length < 5 && value[0].ToString() != value[0].ToString().ToUpper())
                {
                    throw new ArgumentException("Invalid city");
                }
                city = value; }
        }

        public void HireEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public void FireEmployee(string id)
        {
            Employee employee = this.GetEmployeeById(id);
            if(employee != null)
            {
                this.employees.Remove(employee);
            }
        }

        public void IncreaseSalaries(double amount)
        {
            foreach (var employee in this.employees)
            {
                employee.ReceiveBonus(amount);
            }
        }

        public void DecreaseSalaries(double amount)
        {
            foreach (var employee in this.employees)
            {
                employee.Amercement(amount);
            }
        }

        public Employee GetMostHighPaidEmployee()
        {
            return this.employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        }

        public List<Employee> GetTopThreeMostHighPaidEmployees()
        {
            return this.employees.OrderByDescending(p => p.Salary).Take(3).ToList();
        }

        public bool CheckEmployeeIsPresent(string id)
        {
            return this.GetEmployeeById(id) != null ? true : false;
        }

        public double GetAverageEmployeeSalary()
        {
            return this.employees.Average(e => e.Salary);
        }
        private Employee GetEmployeeById(string id)
        {
            return this.employees.Where(e => e.Id.Equals(id)).FirstOrDefault();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Company {this.Name} from {this.City} has the following employees:");
            foreach (var employee in employees)
            {
                sb.AppendLine();
                sb.Append($"-->{employee}");
            }
            return sb.ToString();
        }
    }
}
