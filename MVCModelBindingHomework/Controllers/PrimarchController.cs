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
    }
}
