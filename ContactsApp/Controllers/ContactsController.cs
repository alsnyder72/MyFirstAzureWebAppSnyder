using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstAzureWebAppSnyder.Models;

namespace MyFirstAzureWebAppSnyder.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ILogger<ContactsController> _logger;
        private ContactContext context { get; set; }

        public ContactsController(ILogger<ContactsController> logger, ContactContext dbcontext)
        {
            _logger = logger;
            context = dbcontext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            // var contacts = context.Contacts.OrderBy(m => m.Name).ToList();

            var contacts = context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                    context.Contacts.Add(contact);
                else
                    context.Contacts.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Contact");
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Contacts = context.Contacts.OrderBy(g => g.Name).ToList();
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact); context.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
    }
}