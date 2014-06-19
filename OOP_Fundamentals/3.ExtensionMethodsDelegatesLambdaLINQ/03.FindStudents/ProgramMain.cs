namespace FindStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ProgramMain
    {
        //Task 3: Write a method that from a given array of students finds all students 
        //whose first name is before its last name alphabetically. Use LINQ query operators.
        
        static void Main()
        {
            //Using anonymous type
            var arrayWithStudents = new[] 
            { 
                new { firstName = "Ivan", secondName = "Fazanov", age=25 },
                new { firstName = "Artin", secondName = "Lechkov", age=31 }, 
                new { firstName = "Georgi", secondName = "Stoqnov", age=12 }, 
                new { firstName = "Slavejko", secondName = "Matev", age=89 }
            };

            //findind students whose first name is before its last name alphabetically
            dynamic students =
                from student in arrayWithStudents
                where student.firstName.CompareTo(student.secondName) == -1
                select student.firstName + " " + student.secondName;

            Console.WriteLine("Printing all students whose first name is before its last name alphabetically:");
            PrintStudents(students);
        }

        private static void PrintStudents(IEnumerable<dynamic> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}