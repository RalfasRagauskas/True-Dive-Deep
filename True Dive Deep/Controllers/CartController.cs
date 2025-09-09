using Microsoft.AspNetCore.Mvc;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Controllers
{
    public class CartController : Controller
    {
        // Midlertidig kurv, statisk liste
        private static List<CartItem> CartItems = new List<CartItem>();

        public IActionResult Index()
        {
            return View(CartItems); // Viser nuværende kurv
        }

        [HttpPost]
        public IActionResult Add(string productName, string brand, string imageFileName, decimal price, string size, int quantity = 1)
        {
            var item = new CartItem
            {
                ProductId = CartItems.Count + 1, // bare et midlertidigt ID
                ProductName = productName,
                Brand = brand,
                ImageFileName = imageFileName,
                PricePerDay = price,
                SelectedSize = size,
                Quantity = quantity
            };


            CartItems.Add(item);

            return RedirectToAction("Index");
        }
    }
}
