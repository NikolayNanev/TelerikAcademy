namespace SchoolProject
{
    using System.Collections.Generic;

    public class SchoolClass
    {
        public SchoolClass(string identifier, IEnumerable<Teacher> teachers, IEnumerable<Student> students) 
        {
            this.Identifier = identifier;
            this.Teachers = teachers;
            this.Students = students;
        }

        public string Identifier { get; private set; }
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
