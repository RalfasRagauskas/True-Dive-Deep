using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Controllers
{
    public class CartController : Controller
    {
        // Midlertidig kurv, statisk liste
        private static List<CartItem> CartItems = new List<CartItem>();

        public IActionResult Index()
        {
            return View(CartItems);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, string productName, string brand, string imageFileName, decimal price, string size = null, string gender = null, int quantity = 1)
        {
            // Tjek om item allerede findes
            var existingItem = CartItems.FirstOrDefault(c => c.ProductId == productId && c.SelectedSize == size && c.SelectedGender == gender);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                CartItems.Add(new CartItem
                {
                    ProductId = productId,
                    ProductName = productName,
                    Brand = brand,
                    ImageFileName = imageFileName,
                    PricePerDay = price,
                    SelectedSize = size,
                    SelectedGender = gender,
                    Quantity = quantity
                });
            }

            return RedirectToAction("Index"); // Sender brugeren til Cart View
        }
    }
}
