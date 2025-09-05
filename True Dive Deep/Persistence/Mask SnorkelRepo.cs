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
                Mask_SnorkelId = 1,
                Brand = "Scubapro",
                Model = "Ghost",
                PricePerDay = 50
            },
            new Mask_Snorkel 
            { 
                Mask_SnorkelId = 2,
                Brand = "Scubapro",
                Model = "D-Mask",
                PricePerDay = 60
            },
            new Mask_Snorkel 
            { 
                Mask_SnorkelId = 3,
                Brand = "Scubapro",
                Model = "Spectra Mini",
                PricePerDay = 50
            },
            new Mask_Snorkel 
            { 
                Mask_SnorkelId = 4,
                Brand = "Scubapro",
                Model = "Crystal VU",
                PricePerDay = 75
            },
            new Mask_Snorkel 
            { 
                Mask_SnorkelId = 5,
                Brand = "Fourth Element",
                Model = "Scout Kontrast",
                PricePerDay = 75
            },
            new Mask_Snorkel 
            { 
                Mask_SnorkelId = 6,
                Brand = "Fourth Element",
                Model = "Scout Enhance",
                PricePerDay = 75
            },
            new Mask_Snorkel 
            { 
                Mask_SnorkelId = 7,
                Brand = "Tusa",
                Model = "Element",
                PricePerDay = 75
            }
        };
        public static List<Mask_Snorkel> GetAll()
        {
            return Mask_Snorkels;
        }
        public static Mask_Snorkel? GetById(int id) => Mask_Snorkels.Find(m => m.Mask_SnorkelId == id);
        public static void Add(Mask_Snorkel mask_Snorkel)
        {
            if (mask_Snorkel == null) return;
            mask_Snorkel.Mask_SnorkelId = Mask_Snorkels.Count > 0 ? Mask_Snorkels[^1].Mask_SnorkelId + 1 : 1;
            Mask_Snorkels.Add(mask_Snorkel);
        }
        public static void Delete(int id) => Mask_Snorkels.RemoveAll(m => m.Mask_SnorkelId == id);

    }
}
