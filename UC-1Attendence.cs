using System;

namespace EmployeeWageComputationUsingOops
{
    internal class Employee
    {
        private bool isPresent;

        public Employee()
        {
            Random random = new Random();
            isPresent = random.Next(0, 2) == 0 ? false : true;
        }

        public void CheckAttendance()
        {
            if (isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Employee employee = new Employee();
            employee.CheckAttendance();
        }
    }
}
