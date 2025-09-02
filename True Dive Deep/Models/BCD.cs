namespace True_Dive_Deep.Models
{
    public enum BCDSize
    {
        S,
        M,
        L
    }


    public class BCD 
    {
        public int BCDId { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public List<BCDSize> Sizes { get; set; } = new();
        public int PricePerDay { get; set; }
    }
}
