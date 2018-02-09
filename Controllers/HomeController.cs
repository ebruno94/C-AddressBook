using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBookProject.Models;

namespace AddressBookProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> contacts = Contact.GetAllContacts();
            if (contacts.Count == 0)
            {
                return View();
            }
            else
            {
                return View(contacts);
            }
        }
    }
}
