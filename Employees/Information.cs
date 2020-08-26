using System;

namespace Employees
{
    public class Information
    {
        public Jobs Job { get; set; }
        public decimal Salary { get; set; }
        public DateTime Hired { get; set; }

        public Information() 
        {
            Job = Jobs.Unknown;
            Salary = 0;
            Hired = DateTime.Now;
        }

        public Information(Jobs job, decimal salary, DateTime hired)
        {
            Job = job;
            if (CheckSalary(salary)) Salary = salary;
            else throw new SalaryToLowOrHigh();
            Hired = hired;
        }

        public enum Jobs
        {
            Manager,
            Seller,
            Production,
            Student,
            Unknown
        }

        private bool CheckSalary(decimal salary)
        {
            return salary >= 5000 && salary <= 200000;
        }
    }
}
