using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;

namespace True_Dive_Deep.Controllers
{
    public class BCDcontroller : Controller
    {
        public IActionResult Index()
        {
            var bcds = BCDRepository.GetAll();
            return View(bcds);
        }

    }   
}

