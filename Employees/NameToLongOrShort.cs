using System;
namespace Employees
{
    public class NameToLongOrShort : Exception
    {
        public NameToLongOrShort() : base("The name is to short or long...") { }
    }
}
