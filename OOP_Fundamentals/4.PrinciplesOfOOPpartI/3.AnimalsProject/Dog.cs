namespace AnimalsProject
{
    using System;

    public class Dog : Animals
    {
        public Dog(string name, byte age, Gender sex)
            : base(name, age, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("{0} said:\"Boy Boy\"", this.Name);
        }
    }
}