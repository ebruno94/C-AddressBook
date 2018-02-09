using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBookProject.Models;

namespace AddressBookProject.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost("/contact/new-contact")]
        public ActionResult Form()
        {
            Contact newContact = new Contact(Request.Form["firstName"], Request.Form["lastName"], Request.Form["number"]);
            Address newAddress = new Address(Request.Form["streetAdd"], Request.Form["city"], Request.Form["state"], Request.Form["zip"]);
            newContact.SetAddress(newAddress);
            return View("/Home/Index.html", Contact.GetAllContacts());
        }
    }
}
