using True_Dive_Deep.Models;
using True_Dive_Deep.Persistence;

namespace True_Dive_Deep.Persistence
{
    public static class ProductRepository
    {
        private static readonly List<Product> Products = new List<Product>();

        static ProductRepository()
        {
            Products.AddRange(BCDRepository.GetAll());
            Products.AddRange(DivingSuitRepo.GetAll());
            Products.AddRange(RegulatorSetRepo.GetAll());
            Products.AddRange(FinRepo.GetAll());
            Products.AddRange(TankRepo.GetAll());
            Products.AddRange(Mask_SnorkelRepo.GetAll());
        }
        public static List<Product> GetAll()
        {
            return Products;
        }

        public static Product? GetById(int id) => Products.Find(b => b.ProductId == id);

        public static void Add(BCD bcd)
        {
            if (bcd == null) return;
            bcd.ProductId = Products.Count > 0 ? Products[^1].ProductId + 1 : 1;
            Products.Add(bcd);
        }

        public static void Delete(int id) => Products.RemoveAll(b => b.ProductId == id);
    }
}
