using System.Text.RegularExpressions;

namespace AddressBook
{
    public class UserInputDetails
    {
        public static ContactPerson TakeDetailsFromUserInput()
        {
            Console.WriteLine("Enter your details:");
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Email: ");
            string email = ValidateEmail();
            Console.Write("Mobile Number: +91 ");
            long phoneNumber = ValidatePhoneNumber();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("Zip Code: ");
            int zip = ValidateZipCode();
            return new ContactPerson(firstName, lastName, email, address, city, state, zip, phoneNumber);
        }

        // Validation Methods
        private static string ValidateEmail()
        {
            while (true)
            {
                string email = Console.ReadLine();
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                if (Regex.IsMatch(email, pattern))
                {
                    return email;
                }
                Console.Write("\u274c Invalid Email Format! Please enter again: ");
            }
        }

        private static long ValidatePhoneNumber()
        {
            while (true)
            {
                string phoneNumber = Console.ReadLine();
                string pattern = @"^[6789]\d{9}$";
                if(Regex.IsMatch(phoneNumber, pattern))
                {
                    return long.Parse(phoneNumber);
                }
                Console.Write("\u274c Invalid Mobile Format! Please enter a valid 10-digit mobile number: ");
            }
        }

        private static int ValidateZipCode()
        {
            while (true)
            {
                string zipCode = Console.ReadLine();
                string pattern = @"^[1-9][0-9]{5}$";

                if (Regex.IsMatch(zipCode, pattern))
                {
                    return int.Parse(zipCode);
                }
                Console.Write("\u274c Invalid ZIP Code! Please enter again: ");
            }
        }

    }
}
