using Microsoft.AspNetCore.Mvc;

namespace True_Dive_Deep.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
