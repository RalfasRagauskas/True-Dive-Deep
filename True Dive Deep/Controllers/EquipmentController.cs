using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Persistence;
using True_Dive_Deep.Models;
using System.Diagnostics;

namespace True_Dive_Deep.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult BCD(string sortOrder) // <--- Vigtigt! Modtag parameter
        {
            var bcds = BCDRepository.GetAll();

            // Disse to linjer er kritiske for layoutet!
            ViewBag.Action = "BCD";             // Fortæl layoutet, at det skal poste tilbage til BCD
            ViewBag.CurrentSort = sortOrder;    // Fortæl layoutet, hvad der er valgt

            // ... [Din sorteringslogik med switch-case] ...

            switch (sortOrder)
            {
                case "price_desc":
                    bcds = bcds.OrderByDescending(b => b.PricePerDay).ToList();
                    break;
                case "price_asc":
                    bcds = bcds.OrderBy(b => b.PricePerDay).ToList();
                    break;
                default:
                    // Standardvisning
                    bcds = bcds.OrderBy(b => b.ProductId).ToList();
                    break;
            }

            return View(bcds);
        }

        public IActionResult DivingSuit(string sortOrder)
        {
            var divingsuits = DivingSuitRepo.GetAll();

            ViewBag.Action = "DivingSuit";
            ViewBag.CurrentSort = sortOrder;


            switch (sortOrder)
            {
                case "price_desc":
                    divingsuits = divingsuits.OrderByDescending(b => b.PricePerDay).ToList();
                    break;
                case "price_asc":
                    divingsuits = divingsuits.OrderBy(b => b.PricePerDay).ToList();
                    break;
                default:
                    divingsuits = divingsuits.OrderBy(b => b.ProductId).ToList();
                    break;
            }


            return View(divingsuits);
        }

        public IActionResult Fin(string sortOrder)
        {
            var fins = FinRepo.GetAll();

            ViewBag.Action = "Fin";
            ViewBag.CurrentSort = sortOrder;


            switch (sortOrder)
            {
                case "price_desc":
                    fins = fins.OrderByDescending(b => b.PricePerDay).ToList();
                    break;
                case "price_asc":
                    fins = fins.OrderBy(b => b.PricePerDay).ToList();
                    break;
                default:
                    fins = fins.OrderBy(b => b.ProductId).ToList();
                    break;
            }
            return View(fins);
        }

        public IActionResult MaskSnorkel(string sortOrder)
        {
            var masksnorkels = Mask_SnorkelRepo.GetAll();
            ViewBag.Action = "MaskSnorkel";
            ViewBag.CurrentSort = sortOrder;

            switch (sortOrder)
            {
                case "price_desc":
                    masksnorkels = masksnorkels.OrderByDescending(b => b.PricePerDay).ToList();
                    break;
                case "price_asc":
                    masksnorkels = masksnorkels.OrderBy(b => b.PricePerDay).ToList();
                    break;
                default:
                    masksnorkels = masksnorkels.OrderBy(b => b.PricePerDay).ToList();
                    break;
            }
            return View(masksnorkels);
        }


        public IActionResult RegulatorSet(string sortOrder)
        {
            var regulatorsets = RegulatorSetRepo.GetAll();
            ViewBag.Action = "Regulatorset";
            ViewBag.CurrentSort = sortOrder;
            
            switch (sortOrder)
            {
                case "price_desc":
                    regulatorsets = regulatorsets.OrderByDescending(b => b.PricePerDay).ToList();
                    break;
                case "price_asc":
                    regulatorsets = regulatorsets.OrderBy(b => b.PricePerDay).ToList();
                    break;
                default:
                    regulatorsets = regulatorsets.OrderBy(b => b.PricePerDay).ToList();
                    break;
            }
            return View(regulatorsets);
        }

        public IActionResult Tank(string sortOrder)
        {
            var tanks = TankRepo.GetAll();
            ViewBag.Action = "Tank";
            ViewBag.CurrenSort = sortOrder;

            switch (sortOrder)
            {
                case "price_desc":
                    tanks = tanks.OrderByDescending(b => b.PricePerDay).ToList();
                    break;
                case "price_asc":
                    tanks = tanks.OrderBy(b => b.PricePerDay).ToList();
                    break;
                default:
                    tanks = tanks.OrderBy(b => b.PricePerDay).ToList();
                    break;
            }
            return View(tanks);
        }
    }
}

