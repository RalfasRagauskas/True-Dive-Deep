using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Fin()
        {
            var fins = FinRepo.GetAll();
            ViewBag.Action = "Fin";
            return View(fins);
        }
        public IActionResult DivingSuit()
        {
            var divingsuits = DivingSuitRepo.GetAll();
            ViewBag.Action = "DivingSuit";
            return View(divingsuits);
        }
        public IActionResult BCD()
        {
            var bcds = BCDRepository.GetAll();
            ViewBag.Action = "BCD";
            return View(bcds);
        }
        public IActionResult MaskSnorkel()
        {
            var masksnorkels = Mask_SnorkelRepo.GetAll();
            ViewBag.Action = "MaskSnorkel";
            return View(masksnorkels);
        }
        public IActionResult RegulatorSet()
        {
            var regulatorsets = RegulatorSetRepo.GetAll();
            ViewBag.Action = "Regulatorset";
            return View(regulatorsets);
        }
        public IActionResult Tank()
        {
            var tanks = TankRepo.GetAll();
            ViewBag.Action = "Tank";
            return View(tanks);
        }
    }
}

