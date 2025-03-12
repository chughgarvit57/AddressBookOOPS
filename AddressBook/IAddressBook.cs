﻿namespace AddressBook
{
    public interface IAddressBook
    {
        public void CreateContact();
        public void AddContact(ContactPerson person);
        public void UpdateContact(string firstName);
        public void Display();
    }
}
