using System;

namespace Abstract_Classes
{
    public abstract class Employee
    {
        private string _employeeName;
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }
        public abstract void CalculateSalary();
    }
    public class FullTimeEmployee : Employee
    {
        private double _monthlySalary;
        public double MonthlySalary
        {
            get => _monthlySalary;
            set
            {
                if (value > 0) { 
                _monthlySalary = value;
                }
                else
                {
                    Console.WriteLine("Salary cant be negative");
                }
        }
        }
        public FullTimeEmployee(string name, double salary)
        {
            EmployeeName = name;
            MonthlySalary = salary;
        }
        public override void CalculateSalary()
        {
            Console.WriteLine("The salary of " + EmployeeName + " is " + MonthlySalary);
        }
    }
    public class PartTimeEmployee : Employee
    {
        double _hourlyWage;
        int _hours;
        public double HourlyWage
        {
            get { return _hourlyWage; }
            set { _hourlyWage = value; }
        }
        public int Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }
        public PartTimeEmployee(string name, int hours, double wage)
        {
            EmployeeName = name;
            Hours = hours;
            HourlyWage = wage;
        }
        public override void CalculateSalary()
        {
            Console.WriteLine("The salary of " + EmployeeName + " is " + Hours * HourlyWage);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type of Employee");
            Console.WriteLine("1.FullTimeEmployee\n2.PartTimeEmployee");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:Console.WriteLine("Enter name of Employee");
                    string fname=Console.ReadLine();
                    Console.WriteLine("Enter salary");
                    int fsal=Convert.ToInt32(Console.ReadLine());
                    Employee f = new FullTimeEmployee(fname,fsal);
                    f.CalculateSalary();
                    break;
                case 2:Console.WriteLine("Enter name of Employee");
                    string pname = Console.ReadLine();
                    Console.WriteLine("Enter working hours");
                    int hour=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter wage per hour");
                    double wage=Convert.ToDouble(Console.ReadLine());
                    Employee p = new PartTimeEmployee(pname, hour, wage);
                    p.CalculateSalary();
                    break;
            }
        }
    }
}