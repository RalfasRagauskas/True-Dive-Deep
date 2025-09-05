using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;

namespace True_Dive_Deep.Controllers
{
    public class DivingSuitController : Controller
    {
        public IActionResult Index()
        {
            var divingsuits = DivingSuitRepo.GetAll();
            return View(divingsuits);
        }
    }
}
