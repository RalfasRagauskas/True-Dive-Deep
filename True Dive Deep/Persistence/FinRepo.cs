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
                Brand = "Scubapro",
                Model = "Jet Fin",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL},
                PricePerDay = 50,
                ImageFileName = "finjetfn.jpg"
            },
            new Fin 
            { 
                Brand = "Scubapro",
                Model = "GO Travel",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50,
                ImageFileName = "fingofin.jpg"
            },
            new Fin 
            { 
         
                Brand = "Scubapro",
                Model = "Seawing Supernova",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 60,
                ImageFileName = "finjetfn.jpg"
            },
            new Fin 
            { 
              
                Brand = "Seac",
                Model = "Propulsion",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50,
                ImageFileName = "fingofin.jpg"
            },
            new Fin 
            { 
              
                Brand = "Seac",
                Model = "ALA",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 50,
                ImageFileName = "fingofin.jpg"
            },
            new Fin 
            { 
               
                Brand = "Fourth Element",
                Model = "Tech",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 75,
                ImageFileName = "finjetfn.jpg"
            },
            new Fin 
            { 
                
                Brand = "Fourth Element",
                Model = "Rec Fin",
                Sizes = new List<FinSize>{ FinSize.XS, FinSize.S, FinSize.M, FinSize.L, FinSize.XL },
                PricePerDay = 80,
                ImageFileName = "finjetfn.jpg"
            }
        };
        public static List<Fin> GetAll()
        {
            return fins;
        }
        public static Fin? GetById(int id) => fins.Find(f => f.ProductId == id);
        public static void Add(Fin fin)
        {
            if (fin == null) return;
            fin.ProductId = fins.Count > 0 ? fins[^1].ProductId + 1 : 1;
            fins.Add(fin);
        }
        public static void Delete(int id) => fins.RemoveAll(f => f.ProductId == id);
    }
}
