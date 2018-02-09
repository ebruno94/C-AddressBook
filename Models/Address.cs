using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AddressBookProject
{
    public class Address
    {
        private string _streetAdd;
        private string _city;
        private string _state;
        private string _zip;

        public Address(string streetAdd, string city, string state, string zip)
        {
            _streetAdd = streetAdd;
            _city = city;
            _state = state;
            _zip = zip;
        }

        public void SetStreetAdd(string newStreetAdd)
        {
            _streetAdd = newStreetAdd;
        }
        public void SetCity(string newCity)
        {
            _city = newCity;
        }
        public void SetState(string newState)
        {
            _state = newState;
        }
        public void SetZip(string newZip)
        {
            _zip = newZip;
        }

    }
}
