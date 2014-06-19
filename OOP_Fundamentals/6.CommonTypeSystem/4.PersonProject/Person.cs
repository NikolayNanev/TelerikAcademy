namespace PersonProject
{
    using System;

    public class Person
    {
        public string name;
        public byte? age;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, byte? age) 
            :this(name)
        {
            this.age = age;
        }

        public override string ToString()
        {
            string age = this.age.ToString();

            if (this.age == null)
            {
                age = "Null";
            }

            return String.Format("Name:{0}\nAge:{1}\n", this.name, age);
        }
    }
}
