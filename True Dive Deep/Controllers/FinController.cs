using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;

namespace True_Dive_Deep.Controllers
{
    public class FinController : Controller
    {
        public IActionResult Index()
        {
            var fins = FinRepo.GetAll();
            return View(fins);
        }
    }
}
