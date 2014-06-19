namespace StudentQuerys
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentsMain
    {
        public static void Main()
        {
            List<Mark[]> marksOfStudents = new List<Mark[]>
            {
                new Mark[] { (Mark)2, (Mark)2, (Mark)6, (Mark)5, (Mark)4 },
                new Mark[] { (Mark)6, (Mark)6, (Mark)6, (Mark)5, (Mark)6 },
                new Mark[] { (Mark)3, (Mark)6, (Mark)6, (Mark)5, (Mark)4 },
                new Mark[] { (Mark)2, (Mark)2, (Mark)4, (Mark)4, (Mark)4 },
                new Mark[] { (Mark)3, (Mark)6, (Mark)6, (Mark)5, (Mark)4 },
            };

            List<Student> listWithStudents = new List<Student>() 
            {
                new Student("Ivan","Ivanov",4155,"545454545","asasasa@abv.bg",marksOfStudents[0],1),
                new Student("Mihail","Marinov",7896,"020854567457","sasa@abv.bg",marksOfStudents[1],2),
                new Student("Martin","Stoqnov",4155,"02457457","sasa@outlook.com",marksOfStudents[2],2),
                new Student("Aleks","Ivanov",1234,"085467457","dasasadada@gmail.com",marksOfStudents[3],3),
                new Student("Acho","Paskalev",4523,"08545557","sa@abv.bg",marksOfStudents[4],4)
            };

            //Task 9: Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.

            dynamic task9 =
                from student in listWithStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student.FirstName + " " + student.LastName + " " + student.GroupNumber;

            Console.WriteLine("Task 9:");
            Print(task9);

            //Task 10:Implement the previous using the same query expressed with extension methods.

            //Task 11:Extract all students that have email in abv.bg. Use string methods and LINQ.

            dynamic task11 =
                from student in listWithStudents
                where student.Email.EndsWith("abv.bg")
                select student.FirstName + " " + student.LastName + " " + student.Email;

            Console.WriteLine("Task 11:");
            Print(task11);

            //Task 12:Extract all students with phones in Sofia. Use LINQ.

            dynamic task12 =
                from student in listWithStudents
                where student.Tel.StartsWith("02")
                select student.FirstName + " " + student.LastName + " " + student.Tel;

            Console.WriteLine("Task 12:");
            Print(task12);

            //Task 13:Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.

            var task13 = 
                from student in listWithStudents
                where student.Marks.Contains((Mark)6)
                select new { firstName = student.FirstName, Marks = student.GetMarks() };

            Console.WriteLine("Task 13:");
            Print(task13);
        }

        private static void Print(dynamic students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}