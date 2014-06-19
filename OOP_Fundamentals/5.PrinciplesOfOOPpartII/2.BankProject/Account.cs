namespace BankProject
{
    //

    using System;

    public abstract class Account : IDeposit
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate) 
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public virtual decimal CalculateInterestAmount(int months)
        {
            if (months <= 0)
            {
                throw new ArgumentException("Months must have a positive value");
            }

            decimal interestAmount = this.Balance * months * this.InterestRate / 100;

            return interestAmount;
        }

        public Customer Customer 
        {
            get { return this.customer; }
            private set { this.customer = value; } 
        }

        public decimal Balance 
        {
            get { return this.balance; }
            protected set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance must a have positive value");
                }

                this.balance = value; 
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set 
            {
                if (value <= 0 || value > 20)
                {
                    throw new ArgumentException("Interest rate must have a value between 0%-20%");
                }

                this.interestRate = value; 
            }
        }

        public void DepositAmount(decimal amountOfDeposit)
        {
            this.Balance += amountOfDeposit;
        }
    }
}