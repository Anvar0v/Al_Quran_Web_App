using Microsoft.AspNetCore.Mvc;

namespace Al_Quran_Web_App.Controllers
{
    public class RecitersController : Controller
    {
        public IActionResult Index(string NameOfReciter)
        {
            if (NameOfReciter == "Mishary")
            {
                return RedirectToAction("MisharyReciter");
            }
            return View();
        }

        public IActionResult MisharyReciter()
        {
            return View();
        }
    }
}
