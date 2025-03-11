namespace AddressBook
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            // Enabled unide characters in terminal
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hi! Welcome To Address Book System..!");
            ContactPerson contact = new ContactPerson("Garvit", "Chugh", "gavi.chugh@gmail.com", "Chd", "Chd", "Chd", 160047, 6283636757);
            Console.WriteLine("Contact Created Successfully..!");
            Console.WriteLine(contact);
        }
    }
}
