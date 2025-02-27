namespace ShoppingApp.Models  // Ensure this matches other files
{
    public class ShoppingCart
    {
        public List<ShoppingItem> Items { get; set; } = new List<ShoppingItem>();

        public decimal TotalPrice
        {
            get { return Items.Sum(item => item.Price * item.Quantity); }
        }

        public void AddItem(ShoppingItem item)
        {
            Items.Add(item);
        }
    }
}
