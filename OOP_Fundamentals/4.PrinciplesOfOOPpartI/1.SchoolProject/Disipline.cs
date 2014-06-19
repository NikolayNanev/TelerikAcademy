namespace SchoolProject
{
    public class Disipline
    {
        public Disipline(string name, byte numberOfLectures, byte numberOfExercises) 
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name { get; private set; }
        public byte NumberOfLectures { get; private set; }
        public byte NumberOfExercises { get; private set; }
    }
}
