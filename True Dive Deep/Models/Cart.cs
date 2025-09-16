namespace True_Dive_Deep.Models
{
    public class Cart
    {
        public int CartId { get; set; } //primary key for vores entity framework
        public string UserId { get; set; } //guest carts

        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public void AddToCart(CartItem newItem)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == newItem.ProductId
              && i.SelectedSize == newItem.SelectedSize);


            if (existingItem != null)
            {
                existingItem.Quantity += newItem.Quantity;
            }
            else
            {
                Items.Add(newItem);
            }
        }

        public decimal TotalPrice()
        {
            return Items.Sum(i => i.PricePerDay * i.Quantity);
        }


    }
}
