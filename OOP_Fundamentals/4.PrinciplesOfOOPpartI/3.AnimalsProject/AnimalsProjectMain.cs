namespace AnimalsProject
{
    using System;
    public class AnimalsProjectMain
    {
        static void Main()
        {
            Dog kaka = new Dog("Kaka", 8, Gender.Male);
            kaka.MakeSound();

            Frog marto = new Frog("Marin", 3, Gender.Female);
            marto.MakeSound();

            Cat eli = new Cat("Elena", 3, Gender.Female);
            eli.MakeSound();

            Kitten zimbi = new Kitten("Zimbara", 3, Gender.Male);
            zimbi.MakeSound();
            Console.WriteLine(zimbi.Sex);

            Tomcat gosho = new Tomcat("Georgi",12,Gender.Female);
            gosho.MakeSound();
            Console.WriteLine(gosho.Sex);

            //Create arrays of different kinds of animals.
            //Calculate the average age of each kind of animal using.
        }
    }
}
