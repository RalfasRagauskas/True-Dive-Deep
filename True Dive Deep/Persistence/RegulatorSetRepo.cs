using True_Dive_Deep.Models;

namespace True_Dive_Deep.Persistence
{
    public static class RegulatorSetRepo
    {
        private static readonly List<RegulatorSet> regulatorSets = new List<RegulatorSet>
        {
            new RegulatorSet
            {
             
                Brand = "Scubapro - R105",
                StepOne = "MK25EVO",
                StepTwo = "S600",
                Octopus = "R105",
                PricePerDay = 125,
                ImageFileName = "Regulator-Set.png"
            },
            new RegulatorSet
            {
               
                Brand = "Scubapro - R095",
                StepOne = "MK17EVO",
                StepTwo = "C370",
                Octopus = "R095",
                PricePerDay = 100,
                ImageFileName = "Regulator-Set.png"
            },
            new RegulatorSet
            {
                
                Brand = "Scubapro - S270",
                StepOne = "MK25EVO BT",
                StepTwo = "A700 Carbon BT",
                Octopus = "S270",
                PricePerDay = 150,
                ImageFileName = "Regulator-Set.png"
            }
        };
        public static List<RegulatorSet> GetAll()
        {
            return regulatorSets;
        }
        public static RegulatorSet? GetById(int id) => regulatorSets.Find(r => r.ProductId == id);
        public static void Add(RegulatorSet regulatorSet)
        {
            if (regulatorSet == null) return;
            regulatorSet.ProductId = regulatorSets.Count > 0 ? regulatorSets[^1].ProductId + 1 : 1;
            regulatorSets.Add(regulatorSet);
        }
        public static void Delete(int id) => regulatorSets.RemoveAll(r => r.ProductId == id);
    }
}
