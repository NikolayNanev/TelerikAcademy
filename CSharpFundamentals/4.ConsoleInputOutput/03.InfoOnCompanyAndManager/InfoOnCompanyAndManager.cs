using System;

//company has name, address, phone number, fax number, web site 


class InfoOnCompanyAndManager
{
    static void Main()
    {
        Console.WriteLine("Please input the following information of the company.:");
        Console.Write("Name of company: ");
        string nameOfCompany = Console.ReadLine();

        Console.Write("Address of company: ");
        string addressOfCompany = Console.ReadLine();

        Console.Write("Phone number of company: ");
        string phoneNumberOfCompany = Console.ReadLine();

        Console.Write("Fax number of company: ");
        string faxNumberOfCompany = Console.ReadLine();

        Console.Write("Web site of company: ");
        string webSiteOfCompany = Console.ReadLine();

        Console.WriteLine("\nPlease input the following information of the manager.:");
        Console.Write("First name of manager: ");
        string firstNameOfManager = Console.ReadLine();

        Console.Write("Last name of manager: ");
        string lastNameOfManager = Console.ReadLine();

        Console.Write("Age of manager: ");
        string ageOfManager = Console.ReadLine();

        Console.Write("Phone number of manager: ");
        string phoneNumberOfManager = Console.ReadLine();


        Console.WriteLine("\nInformation about the company \"{0}\":\nName:{0}\nAddress:{1}\nPhone number:{2}\nFax number:{3}\nWeb site:{4}\n",nameOfCompany, addressOfCompany, phoneNumberOfCompany, faxNumberOfCompany, webSiteOfCompany);
        Console.WriteLine("\nInformation about the manager {0} {1}:\nFirst name:{0}\nSecond name:{1}\nAge:{2}\nPhone number:{3}", firstNameOfManager, lastNameOfManager, ageOfManager, phoneNumberOfManager);
    }
}