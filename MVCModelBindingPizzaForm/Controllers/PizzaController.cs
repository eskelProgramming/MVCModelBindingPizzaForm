using Microsoft.AspNetCore.Mvc;

namespace MVCModelBindingPizzaForm.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Pizza()
        {
            return View();
        }
    }
}
