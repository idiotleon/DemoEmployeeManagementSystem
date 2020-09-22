using System;

namespace Model
{
    public class Employee
    {
        public string IdEmployee { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public AddressBook AddressBook { get; private set; }
        public Payroll Payroll { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; set; }

        public Employee(string idEmployee, string firstName, string lastName, AddressBook addressBook, Payroll payroll, DateTime startDate)
        {
            this.IdEmployee = idEmployee;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AddressBook = addressBook;
            this.Payroll = payroll;
            this.StartDate = startDate;
            this.EndDate = default(DateTime);
        }

        public int getVacationBalance()
        {
            return this.Payroll.VacationBalance;
        }

        public bool spendVacationBy(int days)
        {
            return this.Payroll.spendVacationsBy(days);
        }

        public void increaseVacationBalance(int days)
        {
            this.Payroll.increaseVacationBalance(days);
        }

        public int getYearsEmployed()
        {
            if (EndDate != default(DateTime))
            {
                return getTimeSpanInYears(StartDate, EndDate);
            }

            return getTimeSpanInYears(StartDate, DateTime.Now);
        }

        private int getTimeSpanInYears(DateTime start, DateTime ends)
        {
            DateTime zero = new DateTime(1, 1, 1);
            TimeSpan span = ends - start;
            return (zero + span).Year - 1;
        }
    }
}
