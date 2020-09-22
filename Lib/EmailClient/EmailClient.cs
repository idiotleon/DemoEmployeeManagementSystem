using Lib.EmailClient.FakeApi;
using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lib.EmailClient
{
    public class EmailClient : IEmailClient
    {
        private EmailApi emailApi { get; set; }

        public EmailClient(string username, string password)
        {
            this.emailApi = new EmailApi(username, password);
        }

        public async Task sendEmail<T>(T email) where T : Email
        {
            await emailApi.sendEmail(email.EmailAddress, email.EmailSubject, email.EmailBody);
        }

        public async Task batchSendEmails<T>(List<T> emails) where T : Email
        {
            List<Task> allTasks = new List<Task>();
            foreach (var email in emails)
            {
                allTasks.Add(sendEmail(email));
            }

            await Task.WhenAll(allTasks);
        }
    }
}
