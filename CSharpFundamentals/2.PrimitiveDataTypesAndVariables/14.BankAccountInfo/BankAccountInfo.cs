using System;

public class BankAccount 
{
    public string firstName { get; set; }
    public string middleName { get; set; }
    public string lastName { get; set; }
    public decimal balance { get; set; }
    public string bankName { get; set; }
    public string IBAN { get; set; }
    public string BICcode { get; set; }
    public string CreditCardNumber { get; set; }
    public string secondCreditCardNumber { get; set; }
    public string thirdCreditCardNumber { get; set; }
}

class BankAccountInfo
{
    static void Main()
    {
        BankAccount myBankAccount= new BankAccount
        {
            firstName = "Nadejda",
            middleName = "Vasileva",
            lastName = "Stoqnova",
            balance = 1023.56m,
            bankName = "The Bank",
            IBAN = "BG80STSA93000019668856",
            BICcode = "STSABGSF",
            CreditCardNumber = "1235 6541 4552 8883",
            secondCreditCardNumber = "1235 5288 8565 4143",
            thirdCreditCardNumber = "3552 8812 8565 4143"
        };

        Console.WriteLine("Holder name:{0} {1} {2}", myBankAccount.firstName, myBankAccount.middleName, myBankAccount.lastName);
        Console.WriteLine("Balance:{0}BGN", myBankAccount.balance);
        Console.WriteLine("Bank name:{0}", myBankAccount.bankName);
        Console.WriteLine("BIC code:{0}", myBankAccount.BICcode);
        Console.WriteLine("IBAN:{0}", myBankAccount.IBAN);
        Console.WriteLine("Credit card number:{0}\n", myBankAccount.CreditCardNumber);
    }
}