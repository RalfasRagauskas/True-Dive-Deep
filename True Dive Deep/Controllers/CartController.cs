using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var bcds = BCDRepository.GetAll();
            var divingsuits = DivingSuitRepo.GetAll();
            var fins = FinRepo.GetAll();
            var masks = Mask_SnorkelRepo.GetAll();
            var regulators = RegulatorSetRepo.GetAll();
            var tanks = TankRepo.GetAll();

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
   //   public IActionResult Add(BCD bcd)
   //    {
 //      BCDRepository.Add(bcd)
        }
    }
//}
