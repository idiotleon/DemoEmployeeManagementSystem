namespace Model
{
    public class Email
    {
        public string EmailAddress { get; private set; }
        public string EmailBody { get; private set; }
        public string EmailSubject { get; private set; }

        public Email(string emailAddress, string emailSubject, string emailBody)
        {
            this.EmailAddress = emailAddress;
            this.EmailBody = emailBody;
            this.EmailSubject = emailSubject;
        }
    }
}