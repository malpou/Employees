namespace Employees
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Name() 
        {
            FirstName = "N/A";
            LastName = "N/A";
        }

        public Name(string firstName) : this()
        {
            if (CheckNameLenght(firstName)) FirstName = firstName;
            else throw new NameToLongOrShort();
        }

        public Name(string firstName, string lastName) : this(firstName)
        {
            if (CheckNameLenght(lastName)) LastName = lastName;
            else throw new NameToLongOrShort();
        }

        private bool CheckNameLenght(string name)
        {
            return name.Length >= 2 && name.Length <= 35;
        }
    }
}
