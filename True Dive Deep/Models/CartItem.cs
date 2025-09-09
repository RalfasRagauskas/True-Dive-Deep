namespace True_Dive_Deep.Models
{
    public class CartItem

    {
        public int ProductId { get; set; }        
        public string ProductName { get; set; }   
        public string Brand { get; set; }        
        public string ImageFileName { get; set; } 
        public decimal PricePerDay { get; set; }  
        public string SelectedSize { get; set; }  
        public int Quantity { get; set; }
    }
}
