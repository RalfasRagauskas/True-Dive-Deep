using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;

namespace True_Dive_Deep.Controllers
{
    public class Mask_SnorkelController : Controller
    {
        public IActionResult Index()
        {
            var masksnorkels = Mask_SnorkelRepo.GetAll();
            return View(masksnorkels);
        }
    }
}
