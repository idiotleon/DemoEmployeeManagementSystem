namespace Model
{
    public class AddressBook
    {
        public string IdEmployee { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public AddressBook(string idEmployee, string firstName, string lastName, string email)
        {
            this.IdEmployee = idEmployee;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }
    }
}