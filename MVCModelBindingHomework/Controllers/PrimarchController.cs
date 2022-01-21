using Microsoft.AspNetCore.Mvc;
using MVCModelBindingHomework.Models;

namespace MVCModelBindingHomework.Controllers
{
    public class PrimarchController : Controller
    {
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpGet]
        public IActionResult CreateWithModelBinding()
        {
            return View();
        }
    }
}
