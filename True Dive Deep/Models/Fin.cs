namespace True_Dive_Deep.Models
{
    public enum FinSize
    {
        XS,
        S,
        M,
        L,
        XL
    }
    public class Fin : Product
    {
        public string Model { get; set; } = string.Empty;
        public List<FinSize> Sizes { get; set; } = new();
    }
}
