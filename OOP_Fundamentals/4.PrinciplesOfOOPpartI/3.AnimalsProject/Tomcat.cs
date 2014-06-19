namespace AnimalsProject
{
    class Tomcat : Cat
    {
        public Tomcat(string name, byte age, Gender sex)
            : base(name, age,sex) 
        {
            this.Sex = Gender.Male;
        }
    }
}
