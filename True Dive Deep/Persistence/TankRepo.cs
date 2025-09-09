using True_Dive_Deep.Models;

namespace True_Dive_Deep.Persistence
{
    public static class TankRepo
    {
        private static readonly List<Tank> Tanks = new List<Tank>
        {
            new Tank 
            {
                TankId = 1,
                Brand = "Scubapro",
                Volume = 5,
                PricePerDay = 150,
                ImageFileName = ""
            },
    
            new Tank 
            { 
                TankId = 2,
                Brand = "Scubapro",
                Volume = 10,
                PricePerDay = 160,
                ImageFileName = ""
            },
    
            new Tank 
            { 
                TankId = 3,
                Brand = "Scubapro",
                Volume = 12,
                PricePerDay = 170,
                ImageFileName = ""
            },
    
            new Tank 
            { 
                TankId = 4,
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
        public static Tank? GetById(int id) => Tanks.Find(t => t.TankId == id);
        public static void Add(Tank tank)
        {
            if (tank == null) return;
            tank.TankId = Tanks.Count > 0 ? Tanks[^1].TankId + 1 : 1;
            Tanks.Add(tank);
        }
        public static void Delete(int id) => Tanks.RemoveAll(t => t.TankId == id);
    }
}
