namespace Model
{
    public class Payroll
    {
        public string IdEmployee { get; private set; }
        public int VacationBalance { get; private set; }

        public Payroll(string idEmployee)
        {
            this.IdEmployee = idEmployee;
        }

        public void increaseVacationBalance(int days)
        {
            this.VacationBalance += days;
        }

        public bool spendVacationsBy(int days)
        {
            if (VacationBalance >= days)
            {
                VacationBalance -= days;
                return true;
            }

            return false;
        }
    }
}