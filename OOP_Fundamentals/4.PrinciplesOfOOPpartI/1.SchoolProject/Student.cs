namespace SchoolProject
{
    using System.Linq;
    using System.Collections.Generic;

    public class Student : People
    {
        public Student(string firstName, string lastName, uint studentID, Gender gender)
            : base(firstName,lastName)
        {
            this.StudentID = studentID;
            this.Gender = gender;
        }

        //public dynamic OrderStudents(IEnumerable<Student> unorderdStudents) 
        //{
        //    dynamic orderdStudents = 
        //        from student in unorderdStudents
        //        orderby

        //    return orderdStudents;
        //}

        public uint StudentID { get; private set; }
        public Gender Gender { get; private set; }       
    }
}