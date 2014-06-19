using System;

public enum gender { Male, Female }

public class Employee
{
    public string firstName { get; set; }
    public string familyName { get; set; }
    public byte age { get; set; }
    public gender genderOfEmployee { get; set; }
    public int IDnumber { get; set; }
    private int _uniqueEmployeeNumber; 
    public int uniqueEmployeeNumber
    {
        get
        {return _uniqueEmployeeNumber;}
        set
        {
            if (value >= 27560000 && value <= 27569999)
            {
                _uniqueEmployeeNumber = value;
            }    
            else
            {
                Console.WriteLine("\n The unique employee's number is not in the set range\n");
            }
        }
    }
    public override string ToString()
    {
        return firstName + " " + familyName + " " + age + " " + genderOfEmployee + " " + IDnumber + " " + uniqueEmployeeNumber;
    }
}
class MarketingFirmEmployeesInfo
{
    static void Main()
    {
        Employee firstEmployee = new Employee
        {
            firstName = "Bratan",
            familyName = "Bratanov",
            age = 36,
            genderOfEmployee = gender.Male,
            IDnumber = 12345,
            uniqueEmployeeNumber = 27569999
        };

        Console.WriteLine(firstEmployee.ToString());    
    }
}