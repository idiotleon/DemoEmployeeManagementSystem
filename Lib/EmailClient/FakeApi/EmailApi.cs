using System.Threading.Tasks;
using System;

namespace Lib.EmailClient.FakeApi
{
    public class EmailApi
    {
        private string username { get; set; }
        private string password { get; set; }

        public EmailApi(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public async Task sendEmail(string emailAddress, string subject, string emailBody)
        {
            // to assume the `USERNAME` and `PASSWORD` have been applied here

            // to mimic/fake the `sendEmail()` functionality
            string email = emailAddress + "," + subject + "," + emailBody;
            await Task.Run(() =>
            {
                Console.WriteLine("Sending an email");
            });
        }
    }
}
