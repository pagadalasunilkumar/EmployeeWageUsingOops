using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    internal class UC_2Random
    {
        protected bool isPresent;
        protected int wagePerHour;

        public Employee()
        {
            Random random = new Random();
            isPresent = random.Next(0, 2) == 0 ? false : true;
            wagePerHour = 10; // Assuming the wage per hour is $10
        }

        public virtual void CalculateDailyWage()
        {
            int workingHours = 8; // Assuming the employee works 8 hours a day

            if (isPresent)
            {
                int dailyWage = wagePerHour * workingHours;
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Daily Wage: $" + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine("Daily Wage: $0");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Employee employee = new Employee();
            employee.CalculateDailyWage();
        }
    }
}
