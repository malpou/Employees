using System;

namespace Employees
{
    public class SalaryToLowOrHigh: Exception
    {
        public SalaryToLowOrHigh() : base("The salary is to low or high...") { }
    }
}
