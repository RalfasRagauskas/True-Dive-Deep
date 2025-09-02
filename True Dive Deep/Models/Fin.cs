namespace True_Dive_Deep.Models
{
    public enum FinSize
    {
        S,
        M,
        L
    }
    public class Fin
    {
        public int FinId { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public List<FinSize> Sizes { get; set; } = new();
        public int PricePerDay { get; set; }
    }
}
