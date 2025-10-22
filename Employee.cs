using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public abstract class Employee
    {
        public string Name { get;  set; }
        public double BaseSalary { get; set; }

        protected Employee(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public abstract void DisplayEmployeeDetails();
    }
}
