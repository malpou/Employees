using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Employee e4 = new Employee();

            e1.ChangeJob(Information.Jobs.Production);

            try { e2 = new Employee("Malthe", "Poulen"); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try { e3 = new Employee("Jane", Information.Jobs.Manager, 60000.50m, new DateTime(2008, 5, 20)); }
            catch (Exception e) { Console.WriteLine(e.Message); }
            try { e4 = new Employee("M", Information.Jobs.Student, 250000, new DateTime(2012, 1, 5)); }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine(e1.ToString() + "\n");
            Console.WriteLine(e2.ToString() + "\n");
            Console.WriteLine(e3.ToString() + "\n");
            Console.WriteLine(e4.ToString());
        }
    }
}
