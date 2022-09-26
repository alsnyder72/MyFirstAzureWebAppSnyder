using ContactsAppSnyder.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactsAppSnyder.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContactContext context;

        public ContactController(ILogger<HomeController> logger, ContactContext dbcontext)
        {
            _logger = logger;
            context = dbcontext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var contacts = context.Contact.OrderBy(c => c.Name).ToList();
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
            var contact = context.Contact.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if(ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                    context.Contact.Add(contact);
                else
                    context.Contact.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Contact");
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add": "Edit";
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contact.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contact.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Contact");
        }
    }
}
