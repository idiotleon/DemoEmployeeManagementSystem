using Model.Util.Constant.DefaultValue;
using Model.Util.Helper;

namespace Model
{
    public class EmailTemplateGrantVacation : Email
    {
        public EmailTemplateGrantVacation(Employee employee) : base(
            employee.AddressBook.Email,
            EMAIL.EMAIL_SUBJECT,
            EmailTemplateComposer.grantVacationComposer(employee)
        )
        {

        }
    }
}