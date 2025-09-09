namespace True_Dive_Deep.Models
{
    public class Mask_Snorkel
    {
        public int Mask_SnorkelId {  get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int PricePerDay { get; set; }
        public string? ImageFileName { get; set; }
    }
}
