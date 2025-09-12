namespace True_Dive_Deep.Models
{
    public enum BCDSize
    {
        S,
        M,
        L
    }
    public class BCD : Product 
    {
        public string? Model { get; set; }
        public List<BCDSize> Sizes { get; set; } = new();
    }
}
