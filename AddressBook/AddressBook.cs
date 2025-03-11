namespace AddressBook
{
    public class AddressBook : IAddressBook
    {
        private List<ContactPerson> contacts = new List<ContactPerson>();

        public void CreateContact()
        {
            ContactPerson contact = UserInputDetails.TakeDetailsFromUserInput();
            Console.WriteLine("\u2705 Contact Created Successfully...!");
        }
        public void AddContact(ContactPerson person)
        {
            contacts.Add(person);
            Console.WriteLine("\u2705 Contact Added Successfully...!");
        }

        public void Display()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No Contacts In Address Book!");
                return;
            }
            foreach (ContactPerson person in contacts)
            {
                Console.WriteLine(person);
            }
        }
    }
}
