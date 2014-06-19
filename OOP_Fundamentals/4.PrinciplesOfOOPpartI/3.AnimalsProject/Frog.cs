namespace AnimalsProject
{
    using System;

    public class Frog : Animals
    {
        public Frog(string name, byte age, Gender sex)
            : base(name, age, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("{0} said:\"Croak Croak\"",this.Name);
        }
    }
}
