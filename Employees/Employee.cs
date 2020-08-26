using System;

namespace Employees
{
    class Employee
    {
        public Name Name { get; set; }
        public Information Info { get; set; }

        public Employee() 
        {
            Name = new Name();
            Info = new Information();
        }

        public Employee(string firstName, string lastName) : this()
        { 
            Name = new Name(firstName, lastName);
        }

        public Employee(string firstName, string lastName, Information.Jobs job, decimal salary, DateTime hired) : this(firstName, lastName)
        {
            Info = new Information(job, salary, hired);
        }

        public void ChangeJob(Information.Jobs job)
        {
            Info.Job = job;
        }

        public override string ToString()
        {
            return $"{Name.FirstName} {Name.LastName}\nJob: {Info.Job}\nSalary: {Info.Salary:C2}\nSeniority: {Seniority(Info.Hired)} years";
        }

        private int Seniority(DateTime hired)
        {
            return DateTime.Now.Year - hired.Year;
        }
    }
}
