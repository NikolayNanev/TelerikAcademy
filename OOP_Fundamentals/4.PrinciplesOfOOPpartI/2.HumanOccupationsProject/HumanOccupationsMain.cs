namespace HumanOccupations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class HumanOccupationsMain
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order 

            //Initialize a list of 10 students
            List<Student> listOfStudents= new List<Student>() 
            {
                new Student("Gosho","Mitev",6),
                new Student("Mira","Miteva",2),
                new Student("Stoqn","Zarev",1),
                new Student("Radoslav","Kolev",4),
                new Student("Gosho","Mitev",2),
                new Student("Petur","Slavov",3),
                new Student("Elena","Islivenova",6),
                new Student("Stanka","Kocheva",3),
                new Student("Boro","Mitrev",2),
                new Student("Petq","Toneva",1)
            };

            //Sorting list with Student by grade in ascending order
            var newListWithStudents =
                from stud in listOfStudents
                orderby stud.Grade
                select stud + " " + stud.Grade;

            //Printing list with Student
            PrintListWithHumans(newListWithStudents);


            //Initialize a list of 10 workers
            List<Worker> listOfWorkers = new List<Worker>() 
            {
                new Worker("Gosho","Mitev",123,8),
                new Worker("Mira","Miteva",1500,8),
                new Worker("Stoqn","Zarev",400,23),
                new Worker("Radoslav","Kolev",200,13),
                new Worker("Gosho","Mitev",200,2),
                new Worker("Petur","Slavov",300,4),
                new Worker("Elena","Islivenova",60,6),
                new Worker("Stanka","Kocheva",120,3),
                new Worker("Boro","Mitrev",20000,10),
                new Worker("Petq","Toneva",1000,8)
            };

            //Sorting the Workers by money per hour in descending order
            var newListWithWorkers =
               from work in listOfWorkers
               orderby work.MoneyPerHour() descending
               select work + " " + String.Format("{0:0.00}",work.MoneyPerHour());

            //Printing list with Workers
            PrintListWithHumans(newListWithWorkers);

            //Merge the lists and sort them by first name and last name
            List<Human> listWithPeople = new List<Human>();
            
            listWithPeople.AddRange(listOfStudents);
            listWithPeople.AddRange(listOfWorkers);

            //Sorting the Workers by money per hour in descending order
            var newListWithPeople =
               from people in listWithPeople
               orderby people.FirstName, people.LastName
               select people + "";

            PrintListWithHumans(newListWithPeople);
        }

        private static void PrintListWithHumans(IEnumerable<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
