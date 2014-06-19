namespace StudentProject
{
    //Task 1:
    //Define a class Student, which contains data about a student – first, middle and last name, 
    //SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
    //Use an enumeration for the specialties, universities and faculties. 
    //Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

    //Task 2: 
    //Add implementations of the ICloneable interface. 
    //The Clone() method should deeply copy all object's fields into a new object of type Student.

    //Task 3: 
    //Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
    //and by social security number (as second criteria, in increasing order).


    using System;
    using System.Collections.Generic;
    
    public class MainProgram
    {
        static void Main()
        {
            var myFirstStudent = new Student("Nikolay", "Stoqnov", "Georgiev", "0123456789", 
                "CodeStreet 1", "+359883570042", "myMail@mail.com", "Sociology", 
                Specialty.Sociology, Faculty.Faculty_of_Sociology, University.Sofia_university);
            
            var mySecondStudent = new Student("Petur", "Stoqnov", "Georgiev", "9876543210");
            var myThirdStudent = new Student("Nikolay", "Stoqnov", "Georgiev", "0123456789");

            #region Testing_ClassStudent

            Console.WriteLine(myFirstStudent);

            bool myVar1 = myFirstStudent.Equals(mySecondStudent);
            bool myVar2 = myFirstStudent.Equals(myFirstStudent);

            Console.WriteLine("\n" + myVar1);
            Console.WriteLine(myVar2);

            #endregion

            #region TestingOperators(== and !=)

            if (myFirstStudent == myThirdStudent)
            {
                Console.WriteLine("\nEqual");
            }

            if (myFirstStudent != mySecondStudent)
            {
                Console.WriteLine("Not equal");
            }

            #endregion

            #region Testing_Colone()

            Student clonedFirstStudent = myFirstStudent.Clone();

            clonedFirstStudent.FirstName = "MARIO";

            Console.WriteLine("\n" + myFirstStudent.FirstName);
            Console.WriteLine(clonedFirstStudent.FirstName + "\n");

            #endregion

            #region Testing_ComperTo(other Student)

            int valueOfComperTo1 = myFirstStudent.CompareTo(mySecondStudent);
            Console.WriteLine(valueOfComperTo1); // -1 myFirstStudent is before mySecondStudent  

            int valueOfComperTo2 = mySecondStudent.CompareTo(myFirstStudent);
            Console.WriteLine(valueOfComperTo2); // 1 mySecondStudent is after myFirstStudent 

            int valueOfComperTo3 = myFirstStudent.CompareTo(myFirstStudent);
            Console.WriteLine(valueOfComperTo3); // 0 The two Students are the same

            #endregion
        }
    }
}