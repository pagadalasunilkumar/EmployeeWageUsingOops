using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    internal class UC_3PartTime
    {
        public class PartTimeEmployee
        {
            private string name;
            private double wage;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public double Wage
            {
                get { return wage; }
                set { wage = value; }
            }

            public double CalculatePayment(int hours)
            {
                return wage * hours;
            }
        }

        // Example usage
        PartTimeEmployee employee = new PartTimeEmployee();
        employee.Name = "John";  // Setting the name of the employee
employee.Wage = 10;     // Setting the wage of the employee

double payment = employee.CalculatePayment(8);  // Calculating the payment for 8 hours
        Console.WriteLine($"Payment for {employee.Name}: {payment}");
    }
}
