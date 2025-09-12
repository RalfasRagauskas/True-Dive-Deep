using System.Threading.Tasks;
using System.Collections.Generic;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Persistence
{
    public static class Mask_SnorkelRepo
    {
        private static readonly List<Mask_Snorkel> Mask_Snorkels = new List<Mask_Snorkel>
        {
            new Mask_Snorkel 
            { 
                
                Brand = "Scubapro",
                Model = "Ghost",
                PricePerDay = 50,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel 
            { 
              
                Brand = "Scubapro",
                Model = "D-Mask",
                PricePerDay = 60,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel 
            { 
              
                Brand = "Scubapro",
                Model = "Spectra Mini",
                PricePerDay = 50,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel 
            { 
             
                Brand = "Scubapro",
                Model = "Crystal VU",
                PricePerDay = 75,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel 
            { 
               
                Brand = "Fourth Element",
                Model = "Scout Kontrast",
                PricePerDay = 75,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel 
            { 
             
                Brand = "Fourth Element",
                Model = "Scout Enhance",
                PricePerDay = 75,
                ImageFileName = "Maske&Snorkel.png"
            },
            new Mask_Snorkel 
            { 
          
                Brand = "Tusa",
                Model = "Element",
                PricePerDay = 75,
                ImageFileName = "Maske&Snorkel.png"
            }
        };
        public static List<Mask_Snorkel> GetAll()
        {
            return Mask_Snorkels;
        }
        public static Mask_Snorkel? GetById(int id) => Mask_Snorkels.Find(m => m.ProductId == id);
        public static void Add(Mask_Snorkel mask_Snorkel)
        {
            if (mask_Snorkel == null) return;
            mask_Snorkel.ProductId = Mask_Snorkels.Count > 0 ? Mask_Snorkels[^1].ProductId + 1 : 1;
            Mask_Snorkels.Add(mask_Snorkel);
        }
        public static void Delete(int id) => Mask_Snorkels.RemoveAll(m => m.ProductId == id);

    }
}
