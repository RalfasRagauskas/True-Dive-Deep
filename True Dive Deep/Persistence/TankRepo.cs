using True_Dive_Deep.Models;

namespace True_Dive_Deep.Persistence
{
    public static class TankRepo
    {
        private static readonly List<Tank> Tanks = new List<Tank>
        {
            new Tank 
            {
                Brand = "Scubapro",
                Volume = 5,
                PricePerDay = 150,
                ImageFileName = ""
            },
    
            new Tank 
            { 
                Brand = "Scubapro",
                Volume = 10,
                PricePerDay = 160,
                ImageFileName = ""
            },
    
            new Tank 
            { 
                Brand = "Scubapro",
                Volume = 12,
                PricePerDay = 170,
                ImageFileName = ""
            },
    
            new Tank 
            { 
                Brand = "Scubapro",
                Volume = 15,
                PricePerDay = 180,
                ImageFileName = ""
            }
        };
        public static List<Tank> GetAll()
        {
            return Tanks;
        }
        public static Tank? GetById(int id) => Tanks.Find(t => t.ProductId == id);
        public static void Add(Tank tank)
        {
            if (tank == null) return;
            tank.ProductId = Tanks.Count > 0 ? Tanks[^1].ProductId + 1 : 1;
            Tanks.Add(tank);
        }
        public static void Delete(int id) => Tanks.RemoveAll(t => t.ProductId == id);
    }
}
