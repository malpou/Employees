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

        public Name(string firstName) 
        {
            if (CheckNameLenght(firstName)) FirstName = firstName;
            else throw new NameToLongOrShort();
            LastName = "N/A";
        }

        public Name(string firstName, string lastName)
        {
            if (CheckNameLenght(firstName) && CheckNameLenght(lastName))
            {
                FirstName = firstName;
                LastName = lastName;
            }
            else
            {
                throw new NameToLongOrShort();
            }
        }

        private bool CheckNameLenght(string name)
        {
            return name.Length >= 2 && name.Length <= 35;
        }
    }
}
