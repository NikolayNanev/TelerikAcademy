namespace SchoolProject
{
    using System.Collections.Generic;

    public class Teacher : People
    {
        public Teacher(string firstName, string lastName, IEnumerable<Disipline> disiplines) 
            : base(firstName, lastName) 
        {
            this.Disiplines = disiplines;
        }

        public IEnumerable<Disipline> Disiplines { get; private set; }
    }
}