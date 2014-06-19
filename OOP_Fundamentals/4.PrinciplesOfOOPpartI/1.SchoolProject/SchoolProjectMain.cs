namespace SchoolProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SchoolProjectMain
    {
        public static void Main()
        {
            Disipline[] mathDisiplines = 
            {
                new Disipline("Geometry",75,75),
                new Disipline("Algebra",80,80)
            };

            Disipline[] languageDisiplines = 
            {
                new Disipline("English",40,40),
                new Disipline("German",85,85),
                new Disipline("Russian",25,25),
                new Disipline("Bulgarian",45,45)
            };

            //
            dynamic penevDisiplines = FindDisiplinesByName(languageDisiplines, "German");
            dynamic troshevaDisiplines = FindDisiplinesByName(languageDisiplines, "Russian");
            dynamic ogluDisiplines = FindDisiplinesByName(languageDisiplines, "German", "English");
            dynamic zarevaDisiplines = FindDisiplinesByName(languageDisiplines, "Bulgarian");

            List<Teacher> teachersOf12e = new List<Teacher>()
            {
                new Teacher("Ivan","Qnev",mathDisiplines),
                new Teacher("Marin", "Penev", penevDisiplines),
                new Teacher("Maq", "Trosheva", troshevaDisiplines),
                new Teacher("Hasan", "Oglu", ogluDisiplines),
                new Teacher("Tonka", "Zareva", mathDisiplines),
            };

            List<Student> studentsOf12e = new List<Student>() 
            {
                new Student("Gosho","Mitev",1,Gender.Male),
                new Student("Mira","Miteva",2,Gender.Female),
                new Student("Stoqn","Zarev",3,Gender.Male),
                new Student("Radoslav","Kolev",4,Gender.Male),
                new Student("Gosho","Mitev",5,Gender.Male),
                new Student("Petur","Slavov",6,Gender.Male),
                new Student("Elena","Islivenova",7,Gender.Female),
                new Student("Stanka","Kocheva",8,Gender.Female),
                new Student("Boro","Mitrev",9,Gender.Male),
                new Student("Petq","Toneva",10,Gender.Female)
            };

            SchoolClass class12e = new SchoolClass("12e", teachersOf12e, studentsOf12e);
        }

        private static dynamic FindDisiplinesByName(IEnumerable<Disipline> setWithDisiplines, string disiplineToFind)
        {
            dynamic newDisiplines =
                from disipline in setWithDisiplines
                where disipline.Name == disiplineToFind
                select disipline;

            return newDisiplines;
        }

        private static dynamic FindDisiplinesByName(IEnumerable<Disipline> setWithDisiplines, string disiplineToFind, string nextDisiplineToFind)
        {
            dynamic newDisiplines =
                from disipline in setWithDisiplines
                where disipline.Name == disiplineToFind
                    && disipline.Name == nextDisiplineToFind
                select disipline;

            return newDisiplines;
        }

        
    }
}