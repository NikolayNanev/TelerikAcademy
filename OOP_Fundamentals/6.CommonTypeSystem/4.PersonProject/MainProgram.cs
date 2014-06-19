namespace PersonProject
{
    using System;

    //Create a class Person with two fields – name and age. 
    //Age can be left unspecified (may contain null value. Override ToString() to display the information of a person 
    //and if age is not specified – to say so. Write a program to test this functionality.

    class MainProgram
    {
        static void Main()
        {
            Person gosho = new Person("Gosho");
            Person mariq = new Person("Mariq",null);
            Person vasil = new Person("Vasil",16);

            Console.WriteLine(gosho);
            Console.WriteLine(mariq);
            Console.WriteLine(vasil);
        }
    }
}