using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;

namespace True_Dive_Deep.Controllers
{
    public class RegulatorSetController : Controller
    {
        public IActionResult Index()
        {
            var regulatorsets = RegulatorSetRepo.GetAll();
            return View(regulatorsets);
        }
    }
}
