namespace BankProject
{
    using System;

    //Loan accounts have no interest for the first 3 months if are held by individuals 
    //and for the first 2 months if are held by a company.

    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) { }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentException("Months must have a positive value");
            }

            if (this.Customer == Customer.Individual)
            {
                if (months >= 3)
                {
                    return this.Balance * (months - 3) * this.InterestRate / 100;
                }
                else
                {
                    return 0;
                }
                           
            }
            else
            {
                if (months >= 2)
                {
                    return this.Balance * (months - 2) * this.InterestRate / 100;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
