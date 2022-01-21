using Microsoft.AspNetCore.Mvc;
using MVCModelBindingHomework.Models;

namespace MVCModelBindingHomework.Controllers
{
    public class PrimarchController : Controller
    {
        
        [HttpGet]
        public IActionResult CreateWithModelBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWithModelBinding(Primarch p)
        {
            if (ModelState.IsValid)
            {
                // PrimarchDb.Add(p);  Primarch data would be added to database here

                return RedirectToAction("Index", "Home");
            }
            // If model state isn't valid
            // show the page, but with validation errors
            return View(p);
        }
    }
}
