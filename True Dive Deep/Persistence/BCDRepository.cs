using System.Collections.Generic;
using True_Dive_Deep.Models;

namespace True_Dive_Deep.Persistence
{
    public static class BCDRepository
    {
        private static readonly List<BCD> BCDs = new List<BCD>
        {
            new BCD
            {
                Brand = "Scubapro",
                Model = "Navigator Lite BCD",
                Sizes = new List<BCDSize> { BCDSize.S, BCDSize.M, BCDSize.L },
                PricePerDay = 125,
                ImageFileName = "navigatorliteblue.jpg"
            },
            new BCD
            {
                Brand = "Scubapro",
                Model = "BCD Glide",
                Sizes = new List<BCDSize> { BCDSize.S, BCDSize.M, BCDSize.L },
                PricePerDay = 140,
                ImageFileName = "bcd02.jpg"
            },
            new BCD
            {
                Brand = "Scubapro",
                Model = "BCD Hydros Pro",
                Sizes = new List<BCDSize> { BCDSize.S, BCDSize.M, BCDSize.L },
                PricePerDay = 200,
                ImageFileName = "bcdhydrospro.png"
            },
            new BCD
            {
                Brand = "Seac",
                Model = "BCD Modular",
                Sizes = new List<BCDSize> { BCDSize.S, BCDSize.M, BCDSize.L },
                PricePerDay = 145,
                ImageFileName = "bcdmodular.jpg"
            }
        };

        public static List<BCD> GetAll()
        {
            return BCDs;
        }

        public static BCD? GetById(int id) => BCDs.Find(b => b.ProductId == id);

        public static void Add(BCD bcd)
        {
            if (bcd == null) return;
            bcd.ProductId = BCDs.Count > 0 ? BCDs[^1].ProductId + 1 : 1;
            BCDs.Add(bcd);
        }

        public static void Delete(int id) => BCDs.RemoveAll(b => b.ProductId == id);

        internal static async Task<string?> GetAllASync()
        {
            throw new NotImplementedException();
        }

        internal static async Task<IEnumerable<object>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}