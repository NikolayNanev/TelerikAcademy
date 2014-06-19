namespace AnimalsProject
{
    public abstract class Animals : ISound
    {
        public Animals(string name, byte age, Gender sex) 
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; set; }
        public byte Age { get; set; }
        public Gender Sex { get; set; }

        public abstract void MakeSound();
    }
}