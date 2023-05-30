using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    internal class UC_7Computation
    {
        public class PartTimeEmployee
        {
            private static int workingDaysPerMonth = 20;
            private static int workingHoursPerMonth = 100;

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

            public static double ComputeEmployeeWage()
            {
                double hourlyWage = workingHoursPerMonth > 0 ? wage / workingHoursPerMonth : 0;
                double totalWage = hourlyWage * workingHoursPerMonth;
                return totalWage;
            }
        }

    }
}
