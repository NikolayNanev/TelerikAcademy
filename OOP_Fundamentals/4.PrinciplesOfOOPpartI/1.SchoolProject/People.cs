namespace SchoolProject
{
    public abstract class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public People(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}