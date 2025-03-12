namespace AddressBook
{
    public class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }

        public ContactPerson(string firstName, string lastName, string email, string address, string city, string state, int zip, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $@"
Name    : {FirstName} {LastName}
Email   : {Email}
Address : {Address}, {City}, {State} - {Zip}
Phone   : {PhoneNumber}
--------------------------------";
        }

        public override bool Equals(object obj)
        {
            if(obj is ContactPerson other)
            {
                return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase) && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }
    }
}
