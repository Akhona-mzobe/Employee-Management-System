using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagementSystem
{
    public class PartTimeEmployee:Employee
    {
        public PartTimeEmployee(string name, double baseSalary)
                : base(name, baseSalary) { }

        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine($"{Name} \t\t\t{BaseSalary:C}");
        }
    }
}
