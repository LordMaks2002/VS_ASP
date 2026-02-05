using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index() // Contacts
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Feedback feedback)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }
    }
}
