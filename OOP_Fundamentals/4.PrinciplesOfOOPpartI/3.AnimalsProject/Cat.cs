namespace AnimalsProject
{
    using System;

    public class Cat : Animals
    {
        public Cat(string name, byte age, Gender sex)
            : base(name, age, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("{0} said:\"Miay Miay\"",this.Name);
        }
    }
}
