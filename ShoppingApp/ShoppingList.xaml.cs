using ShoppingApp.Models;

namespace ShoppingApp
{
    public partial class ShoppingList : ContentPage
    {
        public ShoppingList()
        {
            InitializeComponent();
            ShoppingItemsListView.ItemsSource = new List<ShoppingItem>
            {
                new ShoppingItem { Name = "Apple", Price = 1.0m, Quantity = 10 },
                new ShoppingItem { Name = "Banana", Price = 0.5m, Quantity = 20 },
                new ShoppingItem { Name = "Orange", Price = 1.2m, Quantity = 15 }
            };
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ShoppingItem;
            // Add logic for item selection
        }

        private void OnAddToCartClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var shoppingItem = button?.BindingContext as ShoppingItem;
            // Logic to add the item to cart
        }
    }
}
