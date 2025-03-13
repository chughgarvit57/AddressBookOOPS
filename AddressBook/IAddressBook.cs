namespace AddressBook
{
    public interface IAddressBook
    {
        public void CreateContact();
        public void AddContact(ContactPerson person);
        public void UpdateContact(string firstName);
        public void DeleteContact(string firstName);
        public bool SearchPersonInCity(string firstName, string lastName, string location);
        public void Display();
    }
}
