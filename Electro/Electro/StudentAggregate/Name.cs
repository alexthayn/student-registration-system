namespace Electro.StudentAggregate
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public Name(string firstName, string lastName)
        {
            //Check validity of first and last names

            FirstName = firstName;
            LastName = lastName;
        }
    }
}