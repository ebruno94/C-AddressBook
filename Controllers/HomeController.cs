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
            return View(contacts);
        }
    }
}
