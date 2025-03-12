using System.Net;

namespace AddressBook
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            // Enabled unicode characters in terminal
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            IAddressBook addressBook = new AddressBook();
            Console.WriteLine("Hi! Welcome To Address Book System..!");
            while (true)
            {
                Console.WriteLine("\n----------- Address Book Menu ----------------");
                Console.WriteLine("1. Create Contact");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Display Contacts");
                Console.WriteLine("5. Exit\n");
                Console.Write("Enter your choice: ");
                int choice;
                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid Input! Please enter a valid number.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        addressBook.CreateContact();
                        break;
                    case 2:
                        ContactPerson person = UserInputDetails.TakeDetailsFromUserInput();
                        addressBook.AddContact(person);
                        break;
                    case 3:
                        Console.Write("Enter the first name of the contact to edit: ");
                        string newFirstName = Console.ReadLine();
                        addressBook.UpdateContact(newFirstName);
                        break;
                    case 4:
                        addressBook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Exiting Menu...");
                        break;
                    default:
                        Console.WriteLine("\u274c Invalid Option! Please select a valid choice...");
                        break;
                }
                Console.WriteLine("Do you wish to continue? (y/n)");
                string confirmation = Console.ReadLine();
                if(confirmation == "n" || confirmation == "no")
                {
                    Console.WriteLine("Exiting Address Book...GoodBye!");
                    break;
                }
            }
        }
    }
}
