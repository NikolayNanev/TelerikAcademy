namespace FindStudent3
{
    using System;
    using System.Linq;

    class ProgramMain
    {
        //Task 5:Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
        //by first name and last name in descending order. 
        //  Rewrite the same with LINQ.

        static void Main()
        {
            //Using anonymous type
            var arrayWithStudents = new[] 
            { 
                new { firstName = "Ivan", secondName = "Fazanov", age=21 },
                new { firstName = "Artin", secondName = "Lechkov", age=20 }, 
                new { firstName = "Georgi", secondName = "Stoqnov", age=12 }, 
                new { firstName = "Slavejko", secondName = "Matev", age=89 }
            };

            //Sorting with Lambda expression
            dynamic studentsLambda = arrayWithStudents.OrderByDescending(x=>x.firstName).ThenByDescending(x=>x.secondName);

            Console.WriteLine("Sortby first name and last name in descending order with Lambda expression:");
            PrintStudentsLambdaExpr(studentsLambda);

            //Sorting with LINQ
            dynamic studentsLINQ =
                from student in arrayWithStudents
                orderby student.firstName descending, student.secondName descending
                select student.firstName + " " + student.secondName;

            Console.WriteLine("Sortby first name and last name in descending order with with LINQ:");
            PrintStudentsLINQ(studentsLINQ);
        }

        private static void PrintStudentsLambdaExpr(dynamic students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.secondName);
            }
            Console.WriteLine();
        }

        private static void PrintStudentsLINQ(dynamic students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}