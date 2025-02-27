namespace ShoppingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGoToProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnGoToShoppingListClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingList());
        }
    }
}
