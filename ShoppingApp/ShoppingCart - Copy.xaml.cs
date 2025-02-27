using ShoppingApp.Models;

namespace ShoppingApp
{
    public partial class ShoppingCart : ContentPage
    {
        public ShoppingCart()
        {
            InitializeComponent();
            CartItemsListView.ItemsSource = new List<ShoppingItem>
            {
                new ShoppingItem { Name = "Apple", Price = 1.0m, Quantity = 1 },
                new ShoppingItem { Name = "Banana", Price = 0.5m, Quantity = 2 }
            };
        }

        private void OnRemoveFromCartClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var shoppingItem = button?.BindingContext as ShoppingItem;
            // Logic to remove the item from cart
        }
    }
}
