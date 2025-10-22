using EmployeeManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee fte1 = new FullTimeEmployee("Akhona Mzobe", 55000);
        FullTimeEmployee fte2 = new FullTimeEmployee("Isabella Mogor", 69000);
        FullTimeEmployee fte3 = new FullTimeEmployee("Erick Mogor", 40000);


        PartTimeEmployee pte1 = new PartTimeEmployee("Nhlaka Zulu", 65000);
        PartTimeEmployee pte2 = new PartTimeEmployee("Sbahle Mzobe", 63000);
        PartTimeEmployee pte3 = new PartTimeEmployee("Olwam Nyakata", 53000);

        
        Console.WriteLine("Full Time Employees:");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Employee Name \t\t\tSalary");
        Console.WriteLine("---------------------------------------------");
        fte1.DisplayEmployeeDetails();
        fte2.DisplayEmployeeDetails();
        fte3.DisplayEmployeeDetails();
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Part-Time Employees:");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Employee Name \t\t\tSalary");
        Console.WriteLine("---------------------------------------------");
        pte1.DisplayEmployeeDetails();
        pte2.DisplayEmployeeDetails();
        pte3.DisplayEmployeeDetails();
        Console.WriteLine("");
        Console.WriteLine("");

        PayrollProcessor payrollProcessor = new PayrollProcessor();

        // Subscribe adjustment methods to events
        payrollProcessor.OnTaxApplied += SalaryAdjustments.ApplyTax;
        payrollProcessor.OnBonusApplied += SalaryAdjustments.ApplyBonus;
        payrollProcessor.OnHealthBenefitsApplied += SalaryAdjustments.ApplyHealthBenefits;


        //PayrollProcessor payrollProcessor = new PayrollProcessor();

        Console.WriteLine("Process Full-Time Employee Salaries: ");
        Console.WriteLine("");
        payrollProcessor.ProcessSalary(fte1);
        payrollProcessor.ProcessSalary(fte2);
        payrollProcessor.ProcessSalary(fte3);
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Process Part-Time Employee Salaries: ");
        Console.WriteLine("");
        payrollProcessor.ProcessSalary(pte1);
        payrollProcessor.ProcessSalary(pte2);
        payrollProcessor.ProcessSalary(pte3);

        Console.ReadLine();
    }
}
