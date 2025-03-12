﻿namespace AddressBook
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

        public void UpdateContact(string firstName)
        {
            ContactPerson contact = contacts.Find(x => x.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
            if (contact == null)
            {
                Console.WriteLine("\u274c Contact not found!");
                return;
            }

            Console.WriteLine($"Editing Contact: {contact.FirstName} {contact.LastName}");

            while (true)
            {
                Console.WriteLine("\n------ Update Contact Menu ------");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Email");
                Console.WriteLine("4. Address");
                Console.WriteLine("5. City");
                Console.WriteLine("6. State");
                Console.WriteLine("7. Zip Code");
                Console.WriteLine("8. Phone Number");
                Console.WriteLine("9. Done\n");

                Console.Write("Select an option to update: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter New First Name: ");
                        contact.FirstName = Console.ReadLine();
                        break;
                    case "2":
                        Console.Write("Enter New Last Name: ");
                        contact.LastName = Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Enter New Email: ");
                        contact.Email = UserInputDetails.ValidateEmail();
                        break;
                    case "4":
                        Console.Write("Enter New Address: ");
                        contact.Address = Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("Enter New City: ");
                        contact.City = Console.ReadLine();
                        break;
                    case "6":
                        Console.Write("Enter New State: ");
                        contact.State = Console.ReadLine();
                        break;
                    case "7":
                        Console.Write("Enter New Zip Code: ");
                        contact.Zip = UserInputDetails.ValidateZipCode();
                        break;
                    case "8":
                        Console.Write("Enter New Phone Number: ");
                        contact.PhoneNumber = UserInputDetails.ValidatePhoneNumber();
                        break;
                    case "9":
                        Console.WriteLine("\u2705 Contact Updated Successfully...");
                        return;
                    default:
                        Console.WriteLine("\u274c Invalid Choice! Please try again...");
                        break;
                }
            }
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
