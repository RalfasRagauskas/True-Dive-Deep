using System.Collections.Generic;
using True_Dive_Deep.Models;
    namespace True_Dive_Deep.Persistence
{
    public static class DivingSuitRepo
    {
        private static readonly List<DivingSuit> divingSuits = new List<DivingSuit>
        {
            new DivingSuit
            {
                DivingSuitId = 1,
                Brand = "Scubapro",
                Model = "Definition",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = "Herre/Dame",
                Thickness = 3,
                PricePerDay = 100
            },
            new DivingSuit
            {
                DivingSuitId = 2,
                Brand = "Scubapro",
                Model = "Definition",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = "Herre/Dame",
                Thickness = 5,
                PricePerDay = 100
            },
            new DivingSuit
            {
                DivingSuitId = 3,
                Brand = "Scubapro",
                Model = "Definition",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = "Herre/Dame",
                Thickness = 7,
                PricePerDay = 100
            },
            new DivingSuit
            {
                DivingSuitId = 4,
                Brand = "Waterproof",
                Model = "W5",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = "Herre/Dame",
                Thickness = 3.5,
                PricePerDay = 100
            },
            new DivingSuit
            {
                DivingSuitId = 5,
                Brand = "Fourth Element",
                Model = "Proteus",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Våddragt",
                Gender = "Herre/Dame",
                Thickness = 5,
                PricePerDay = 120
            },
            new DivingSuit
            {
                DivingSuitId = 6,
                Brand = "Scubapro",
                Model = "Exodry 4.0",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Tørdragt",
                Gender = "Herre/Dame",
                PricePerDay = 300
            },
            new DivingSuit
            {
                DivingSuitId = 7,
                Brand = "Waterproof",
                Model = "D7 Evo",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Tørdragt",
                Gender = "Herre/Dame",
                PricePerDay = 320
            },
            new DivingSuit
            {
                DivingSuitId = 8,
                Brand = "Santi",
                Model = "E.Lite Plus",
                Sizes = new List<DivingSuitSize> { DivingSuitSize.XS, DivingSuitSize.S, DivingSuitSize.M, DivingSuitSize.L, DivingSuitSize.XL },
                Type = "Tørdragt",
                Gender = "Herre/Dame",
                PricePerDay = 350
            }
        };
            public static List<DivingSuit> GetAll()
        {
            return divingSuits;
        }

        public static DivingSuit? GetById(int id) => divingSuits.Find(d => d.DivingSuitId == id);

        public static void Add(DivingSuit divingsuit)
        {
            if (divingsuit == null) return;
            divingsuit.DivingSuitId = divingSuits.Count > 0 ? divingSuits[^1].DivingSuitId + 1 : 1;
            divingSuits.Add(divingsuit);
        }

        public static void Delete(int id) => divingSuits.RemoveAll(d => d.DivingSuitId == id);
    }
}
