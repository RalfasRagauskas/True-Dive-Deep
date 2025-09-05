using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;

namespace True_Dive_Deep.Controllers
{
    public class TankController : Controller
    {
        public IActionResult Index()
        {
            var tanks = TankRepo.GetAll();
            return View(tanks);
        }
    }
}
