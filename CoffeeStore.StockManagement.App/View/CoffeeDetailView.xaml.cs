using System.Windows;

namespace CoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeDetailView.xaml
    /// </summary>
    public partial class CoffeeDetailView
    {
        //public Coffee SelectedCoffee { get; set; }

        public CoffeeDetailView()
        {
            InitializeComponent();

            //this.Loaded += CoffeeDetailView_Loaded;
        }


        //private void LoadData()
        //{
            //CoffeeNameLabel.Content = SelectedCoffee.CoffeeName;
            //CoffeeIdTextBox.Text = SelectedCoffee.CoffeeId.ToString();
            //CoffeeDescriptionTextBox.Text = SelectedCoffee.Description;
            //CoffeePriceTextBox.Text = SelectedCoffee.Price.ToString();
            //StockAmountTextBox.Text = SelectedCoffee.InventoryAmount.ToString();
            //FirstTimeAddedTextBox.Text = SelectedCoffee.DateAdded.ToShortDateString();
            //if (SelectedCoffee is SuperiorCoffee)
            //    ExtraDescriptionTextBox.Text = (SelectedCoffee as SuperiorCoffee).ExtraDescription;
            //else
            //    ExtraDescriptionTextBox.Text = "NA";

            //BitmapImage img = new BitmapImage();
            //img.BeginInit();
            //img.UriSource = new Uri("/JoeCoffeeStore.StockManagement.App;component/Images/coffee" + SelectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
            //img.EndInit();
            //CoffeeImage.Source = img;
        //}
    }
}
