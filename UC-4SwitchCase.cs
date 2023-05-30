using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    internal class UC_4SwitchCase
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
                double payment = 0;
                switch (hours)
                {
                    case 8:
                        payment = wage * hours;
                        break;
                    case 6:
                        payment = wage * hours * 0.8;  // Assuming 80% payment for 6 hours
                        break;
                    case 4:
                        payment = wage * hours * 0.6;  // Assuming 60% payment for 4 hours
                        break;
                    default:
                        Console.WriteLine("Invalid number of hours.");
                        break;
                }
                return payment;
            }
        }

        // Example usage
        PartTimeEmployee employee = new PartTimeEmployee();
        employee.Name = "John";  // Setting the name of the employee
employee.Wage = 10;     // Setting the wage of the employee

double payment8Hours = employee.CalculatePayment(8);  // Calculating the payment for 8 hours
        Console.WriteLine($"Payment for {employee.Name} (8 hours): {payment8Hours}");

double payment6Hours = employee.CalculatePayment(6);  // Calculating the payment for 6 hours
        Console.WriteLine($"Payment for {employee.Name} (6 hours): {payment6Hours}");

double payment4Hours = employee.CalculatePayment(4);  // Calculating the payment for 4 hours
        Console.WriteLine($"Payment for {employee.Name} (4 hours): {payment4Hours}");

    }
}
