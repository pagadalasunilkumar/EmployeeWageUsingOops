using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    internal class UC_5WorkingHours
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

            public double CalculateWages(int totalHours, int totalDays)
            {
                int workingDays = 20;  // Assuming 20 working days in a month
                int maxHours = 100;    // Assuming 100 working hours in a month

                double hourlyWage = wage / 8;  // Assuming 8 working hours per day

                double totalWage = 0;
                int hoursWorked = 0;
                int daysWorked = 0;

                while (hoursWorked < totalHours && daysWorked < totalDays && hoursWorked < maxHours && daysWorked < workingDays)
                {
                    totalWage += hourlyWage;
                    hoursWorked += 8;
                    daysWorked++;
                }

                return totalWage;
            }
        }
    }
}
