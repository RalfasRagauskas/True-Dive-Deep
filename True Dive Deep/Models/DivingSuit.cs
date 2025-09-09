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
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public List<DivingSuitSize> Sizes { get; set; } = new();
        public string? Type { get; set; }
        public string? Gender { get; set; }
        public double Thickness { get; set; }
        public int PricePerDay { get; set; }
        public string? ImageFileName { get; set; }
    }
}
