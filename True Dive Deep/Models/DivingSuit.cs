namespace True_Dive_Deep.Models
{
    public enum DivingSuitSize
    {
        XS,
        S,
        M,
        L,
        XL
    }
    public class DivingSuit
    {
        public int DivingSuitId { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public List<DivingSuitSize> Sizes { get; set; } = new();
        public string Type { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public double Thickness { get; set; }
        public int PricePerDay { get; set; }
    }
}
