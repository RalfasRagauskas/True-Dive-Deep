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
    public enum  DivingSuitGender
    {
        Herre,
        Dame
    }
    public class DivingSuit : Product
    {
        public string? Model { get; set; }
        public List<DivingSuitSize> Sizes { get; set; } = new();
        public string? Type { get; set; }
        public List<DivingSuitGender> Gender { get; set; } = new();
        public double Thickness { get; set; }
    }
}
