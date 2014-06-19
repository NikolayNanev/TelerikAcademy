namespace FindStudent2
{
    using System;
    using System.Linq;

    class ProgramMain
    {
        //Task 4: Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

        static void Main()
        {
            //Using anonymous type
            var arrayWithStudents = new[] 
            { 
                new  { firstName = "Ivan", secondName = "Fazanov", age=21 },
                new { firstName = "Artin", secondName = "Lechkov", age=20 }, 
                new { firstName = "Georgi", secondName = "Stoqnov", age=12 }, 
                new { firstName = "Slavejko", secondName = "Matev", age=89 }
            };

            //Finds the first name and last name of all students with age between 18 and 24
            dynamic students =
                from student in arrayWithStudents
                where student.age >= 18
                where student.age <= 24
                select student.firstName + " " + student.secondName + " (" + student.age + ")";

            Console.WriteLine("Finds the first name and last name of all students with age between 18 and 24:");
            PrintStudents(students);
        }

        private static void PrintStudents(dynamic students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
