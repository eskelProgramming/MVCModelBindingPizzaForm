using Microsoft.AspNetCore.Mvc;
using MVCModelBindingPizzaForm.Models;

namespace MVCModelBindingPizzaForm.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Pizza()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pizza(Pizza p)
        {
            if (ModelState.IsValid)
            {
                // Add to database
                // PizzaDatabase.Add(p);

                return RedirectToAction("Index", "Home");
            }
            return View(p);
        }
    }
}
