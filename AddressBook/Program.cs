namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome To Address Book System..!");
            ContactPerson contact = new ContactPerson("Garvit","Chugh","gavi.chugh@gmail.com","Chd","Chd","Chd",160047,6283636757);
            Console.WriteLine(contact);
        }
    }
}
