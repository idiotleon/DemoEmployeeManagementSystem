using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace Lib.EmailClient
{
    public interface IEmailClient
    {
        Task sendEmail<T>(T email) where T : Email;

        Task batchSendEmails<T>(List<T> emails) where T : Email;
    }
}