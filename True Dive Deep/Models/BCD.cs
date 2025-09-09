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
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public List<BCDSize> Sizes { get; set; } = new();
        public int PricePerDay { get; set; }
        public string? ImageFileName { get; set; }
    }
}
