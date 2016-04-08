using CoffeeStore.StockManagement.App.Services;
using CoffeeStore.StockManagement.App.View;
using CoffeeStore.StockManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoffeeStore.StockManagement.App.View
{
    /// <summary>
    /// Interaction logic for CoffeeOverviewView.xaml
    /// </summary>
    public partial class CoffeeOverviewView
    {
        private Coffee selectedCoffee;
        public CoffeeOverviewView()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            CoffeeDataService coffeeDataService = new CoffeeDataService();
            CoffeeListView.ItemsSource = coffeeDataService.GetAllCoffees();
        }

        private void EditCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            CoffeeDetailView coffeeDetailView = new CoffeeDetailView();
            coffeeDetailView.SelectedCoffee = selectedCoffee;
            coffeeDetailView.ShowDialog();
        }

        private void CoffeeListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCoffee = e.AddedItems[0] as Coffee;

            if (e != null)
            {
                CoffeeIdLabel.Content = selectedCoffee.CoffeeId;
                CoffeeNameLabel.Content = selectedCoffee.CoffeeName;
                DescriptionLabel.Content = selectedCoffee.Description;
                PriceLabel.Content = selectedCoffee.Price;
                StockAmountLabel.Content = selectedCoffee.InventoryAmount.ToString();
                FirstTimeAddedLabel.Content = selectedCoffee.DateAdded.ToShortDateString();

                //BitmapImage img = new BitmapImage();
                //img.BeginInit();
                //img.UriSource = new Uri("/JoeCoffeeStore.StockManagement.App;component/Images/coffee" + selectedCoffee.CoffeeId + ".jpg", UriKind.Relative);
                //img.EndInit();
                //CoffeeImage.Source = img;
            }
        }

        private void AddFakeCoffeeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
