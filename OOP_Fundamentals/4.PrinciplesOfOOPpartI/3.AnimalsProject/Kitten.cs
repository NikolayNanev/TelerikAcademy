namespace AnimalsProject
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, byte age, Gender sex)
            : base(name, age,sex) 
        {
            this.Sex = Gender.Female;
        }
    }
}
