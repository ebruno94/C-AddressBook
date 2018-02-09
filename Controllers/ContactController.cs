using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBookProject.Models;

namespace AddressBookProject.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet("/contact/create-form")]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost("/contact/new-contact")]
        public ActionResult Create()
        {
            Contact newContact = new Contact(Request.Form["firstName"], Request.Form["lastName"], Request.Form["number"]);
            Address newAddress = new Address(Request.Form["streetAdd"], Request.Form["city"], Request.Form["state"], Request.Form["zip"]);
            newContact.SetAddress(newAddress);
            return View("../Home/Index", Contact.GetAllContacts());
        }

        [HttpGet("/contact/{id}")]
        public ActionResult Detail(int id)
        {
            Contact newContact = Contact.Find(id);
            return View(newContact);
        }

        [HttpGet("/contact/{id}/delete")]
        public ActionResult DeleteContact(int id)
        {
            Contact.RemoveContact(id);
            return View("../Home/Index");
        }
    }
}
