namespace BankProject
{
    using System;

    public class Deposit : Account,IDraw
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) { }

        public void DrawAmount(decimal drawAmount)
        {
            if (this.Balance < drawAmount)
            {
                throw new InvalidOperationException("Not enough amount of money to DrawAmount()");
            }
            this.Balance -= drawAmount;
        }

        public override decimal CalculateInterestAmount(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentException("Months must have a positive value");
            }

            if (this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return this.Balance * months * this.InterestRate / 100;
            }         
        }
    }
}