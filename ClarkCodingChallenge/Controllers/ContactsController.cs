using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.BusinessLogic;

namespace ClarkCodingChallenge.Controllers
// Reference: https://www.completecsharptutorial.com/mvc-articles/insert-update-delete-in-asp-net-mvc-5-without-entity-framework.php
// https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/dependency-injection?view=aspnetcore-5.0

{
    public class ContactsController : Controller
    {

        private IContactsService contactsService;
        public ContactsController(IContactsService contactsService)
        {
            this.contactsService = contactsService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel model)
        {
            try
            {
                contactsService.AddContact(model.Email, model.LastName, model.FirstName);
                ViewBag.ResultMessage = "Contact Added";
            }
            catch(ArgumentException exc)
            {
                ViewBag.ResultMessage = "Please correct errors and try again";
            }
            catch(Exception exc)
            {
                ViewBag.ResultMessage = exc.Message;
            }

            
            return View();
        }

        // TODO: Add GetAll controller GET method
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
