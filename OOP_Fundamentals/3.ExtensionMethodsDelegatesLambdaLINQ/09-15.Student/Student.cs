namespace StudentQuerys
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        public Student(string firstName, string lastName, uint fN, byte groupNumber) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, uint fN, ICollection<Mark> listOfMarks, byte groupNumber) 
            : this(firstName, lastName, fN, groupNumber)
        {
            this.Marks = listOfMarks;
        }

        public Student(string firstName, string lastName, uint fN, string tel, string email, ICollection<Mark> listOfMarks, byte groupNumber)
            : this(firstName, lastName, fN, listOfMarks, groupNumber)
        {
            this.Tel = tel;
            this.Email = email;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public uint FN { get; private set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public ICollection<Mark> Marks { get; set; }
        public byte GroupNumber { get; private set; }

        public string GetMarks()
        {
            return string.Join(", ", this.Marks);
        }
    }
}
