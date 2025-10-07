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

    }
}
