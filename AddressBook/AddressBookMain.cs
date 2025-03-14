using System.Net;

namespace AddressBook
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            // Enabled unicode characters in terminal
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<string, IAddressBook> addressBooks = new Dictionary<string, IAddressBook>();
            Console.WriteLine("Hi! Welcome To Address Book System..!");
            while (true)
            {
                Console.WriteLine("\n--------------- Address Book System Menu ---------------");
                Console.WriteLine("1. Create new Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Search in a location");
                Console.WriteLine("4. Exit.");
                Console.Write("Enter your choice: ");
                int mainChoice;
                if (!int.TryParse(Console.ReadLine(), out mainChoice))
                {
                    Console.WriteLine("Invalid Input! Please enter a valid number.");
                    continue;
                }
                switch (mainChoice)
                {
                    case 1:
                        Console.WriteLine("Enter Address Book Name: ");
                        string bookName = Console.ReadLine();
                        if (addressBooks.ContainsKey(bookName))
                        {
                            Console.WriteLine("Address book with name '{0}' already exists!", bookName);
                        }
                        else
                        {
                            addressBooks[bookName] = new AddressBook();
                            Console.WriteLine("\u2705 Address Book '{0}' created successfully..!", bookName);
                        }
                        break;
                    case 2:
                        Console.Write("Enter Address Book Name: ");
                        string selectedBookName = Console.ReadLine();
                        if (addressBooks.TryGetValue(selectedBookName, out IAddressBook selectedAddressBook))
                        {
                            ManageAddressBook(selectedAddressBook);
                        }
                        else
                        {
                            Console.WriteLine("\u274c Address Book '{0}' Not Found!", selectedBookName);
                        }
                        break;
                    case 3:
                        if (addressBooks.Count == 0)
                        {
                            Console.WriteLine("\u274c No Address Books Available! Create one first.");
                            break;
                        }
                        Console.Write("Enter First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Enter City/State: ");
                        string location = Console.ReadLine();

                        bool personFound = false;

                        foreach(var book in addressBooks.Values)
                        {
                            if (book.SearchPersonInCity(firstName, lastName, location))
                            {
                                personFound = true;
                            }
                        }

                        if (!personFound)
                        {
                            Console.WriteLine($"\u274c {firstName} {lastName} not found in \"{location}\".");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exiting Address Book System... GoodBye!");
                        return;
                    default:
                        Console.WriteLine("Invalid Option! Please select a valid choice...");
                        break;
                }
            }
        }

        static void ManageAddressBook(IAddressBook addressBook)
        {
            while (true)
            {
                Console.WriteLine("\n--------------- Address Book Menu ---------------");
                Console.WriteLine("1. Create Contact");
                Console.WriteLine("2. Add Contacts");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Display Contacts");
                Console.WriteLine("6. Back To Main Menu");
                Console.Write("Enter you choice: ");
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
                        Console.WriteLine("Enter the first name of the contact to update: ");
                        string newFirstName = Console.ReadLine();
                        addressBook.UpdateContact(newFirstName);
                        break;
                    case 4:
                        Console.Write("Enter first name of the contact to delete: ");
                        string nameToDelete = Console.ReadLine();
                        addressBook.DeleteContact(nameToDelete);
                        break;
                    case 5:
                        addressBook.Display();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Option! Please select a valid choice...");
                        break;
                }
            }
        }
    }
}
