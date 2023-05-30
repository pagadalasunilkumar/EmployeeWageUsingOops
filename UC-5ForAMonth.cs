using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    internal class UC_5ForAMonth
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

            public double CalculateMonthlyWage()
            {
                int workingDays = 20;  // Assuming 20 working days in a month
                double monthlyWage = wage * workingDays;
                return monthlyWage;
            }
        }

        
    }
}
