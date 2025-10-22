using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class FullTimeEmployee:Employee
    {
        public FullTimeEmployee(string name, double baseSalary)
        : base(name, baseSalary) { }

        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"{Name} \t\t\t{BaseSalary:C}");
        }
    }
}
