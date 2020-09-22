using System;

namespace Model.Util.Helper
{
    public class EmailTemplateComposer
    {
        public static string grantVacationComposer(Employee employee)
        {
            string employeeFirstName = employee.FirstName;
            string employeLastName = employee.LastName;
            int yearsEmployed = employee.getYearsEmployed();
            int employeVacationBalance = employee.getVacationBalance();

            string emailBody = $"Dear {employeeFirstName} {employeLastName}\nbased on your {yearsEmployed} years of employment"
                    + $"you have been granted {yearsEmployed} days of vacation, bringing your total to {employeVacationBalance}";

            return emailBody;
        }
    }
}