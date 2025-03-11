namespace AddressBook
{
    public interface IAddressBook
    {
        public void CreateContact();
        public void AddContact(ContactPerson person);
        public void Display();
    }
}
