namespace BankProject
{
    using System;

    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) { }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentException("Months must have a positive value");
            }

            return this.Balance * months * this.InterestRate / 100;
        }
    }
}
