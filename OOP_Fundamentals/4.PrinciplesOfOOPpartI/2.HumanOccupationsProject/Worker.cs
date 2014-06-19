namespace HumanOccupations
{
    using System;

    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double hoursPerDay) 
            :base(firstName,lastName)
        { 
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = hoursPerDay;
        }

        public double MoneyPerHour() 
        {
            double money = this.WeekSalary / this.WorkHoursPerDay;

            return money;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid week's salary");
                }

                this.weekSalary = value;
            } 
        }

        public double WorkHoursPerDay 
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new ArgumentException("Invalid work hours");
                }

                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
