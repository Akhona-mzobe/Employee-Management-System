using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public static class SalaryAdjustments
    {
        public static double ApplyTax(double salary)
        {
            return salary * 0.80; // 20% tax deduction
        }

        public static double ApplyBonus(double salary)
        {
            return salary + 1500; // Bonus of R1500
        }

        public static double ApplyHealthBenefits(double salary)
        {
            return salary - 1300; // Deduction for health benefits
        }
    }
}
