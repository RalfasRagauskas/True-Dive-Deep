namespace True_Dive_Deep.Models
{
    
    public class BCD 
    {
        public int BCDID { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Sizes { get; set; } = string.Empty;
        public int PricePerDay { get; set; }
    }
}
