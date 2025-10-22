using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class PayrollProcessor
    {
        public delegate double SalaryAdjustment(double currentSalary);

        // Events for notifying about each adjustment
        public event SalaryAdjustment? OnTaxApplied;
        public event SalaryAdjustment? OnBonusApplied;
        public event SalaryAdjustment? OnHealthBenefitsApplied;

        public void ProcessSalary(Employee employee)
        {
            double adjustedSalary = employee.BaseSalary;

            // Apply each adjustment and raise corresponding events
            if (OnTaxApplied != null)
            {
                adjustedSalary = OnTaxApplied(adjustedSalary);
            }
            if (OnBonusApplied != null)
            {
                adjustedSalary = OnBonusApplied(adjustedSalary);
            }
            if (OnHealthBenefitsApplied != null)
            {
                adjustedSalary = OnHealthBenefitsApplied(adjustedSalary);
            }

            Console.WriteLine($"Processed Salary for {employee.Name}: {adjustedSalary:C}");
        }
    }
}
