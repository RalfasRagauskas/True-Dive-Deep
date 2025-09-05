using System;
using System.Collections.Generic;
using True_Dive_Deep.Models;
namespace True_Dive_Deep.Persistence
{
    public static class FinRepo
    {
        private static readonly List<Fin> fins = new List<Fin>
        {
            new Fin 
            {
                FinId = 1,
                Brand = "Scubapro",
                Model = "Jet Fin",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL},
                PricePerDay = 50 
            },
            new Fin 
            { 
                FinId = 2,
                Brand = "Scubapro",
                Model = "GO Travel",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50
            },
            new Fin 
            { 
                FinId = 3,
                Brand = "Scubapro",
                Model = "Seawing Supernova",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 60
            },
            new Fin 
            { 
                FinId = 4,
                Brand = "Seac",
                Model = "Propulsion",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50
            },
            new Fin 
            { 
                FinId = 5,
                Brand = "Seac",
                Model = "ALA",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50
            },
            new Fin 
            { 
                FinId = 6,
                Brand = "Fourth Element",
                Model = "Tech",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 75
            },
            new Fin 
            { 
                FinId = 7,
                Brand = "Fourth Element",
                Model = "Rec Fin",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 80
            }
        };
        public static List<Fin> GetAll()
        {
            return fins;
        }
        public static Fin? GetById(int id) => fins.Find(f => f.FinId == id);
        public static void Add(Fin fin)
        {
            if (fin == null) return;
            fin.FinId = fins.Count > 0 ? fins[^1].FinId + 1 : 1;
            fins.Add(fin);
        }
        public static void Delete(int id) => fins.RemoveAll(f => f.FinId == id);
    }
}
