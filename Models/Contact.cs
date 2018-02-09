using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookProject.Models
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private string _number;
        private Address _address;
        private int _id;
        private static List<Contact> _contacts;

        public Contact(string firstName, string lastName, string number)
        {
            _firstName = firstName;
            _lastName = lastName;
            _number = number;
            _address = new Address();
            _contacts.Add(this);
            _id = _contacts.Count;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        public void SetNumber(string newNumber)
        {
            _number = newNumber;
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetNumber()
        {
            return _number;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public void SetAddress(Address newAddress)
        {
            _address = newAddress;
        }

        public static List<Contact> GetAllContacts()
        {
            return _contacts;
        }

        public static Contact Find(int id)
        {
            return _contacts[id - 1];
        }

        public static void RemoveContact(int id)
        {
            _contacts.RemoveAt(id - 1);
        }
    }
}
