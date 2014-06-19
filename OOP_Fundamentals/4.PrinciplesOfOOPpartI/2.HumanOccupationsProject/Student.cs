namespace HumanOccupations
{
    using System;
    
    public class Student : Human
    {
        private byte grade;

        public Student(string firstName, string lastName, byte grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public byte Grade 
        {
            get { return this.grade; }
            private set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentException("Invalid grade");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
