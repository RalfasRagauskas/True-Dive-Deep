namespace True_Dive_Deep.Models
{
    public class RegulatorSet
    {
        public int RegulatorSetId { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string StepOne { get; set; } = string.Empty;
        public string StepTwo { get; set; } = string.Empty;
        public string Octopus {  get; set; } = string.Empty;
        public int PricePerDay { get; set; }
        public string? ImageFileName { get; set; }
    }
}
