using CoffeeStore.StockManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore.StockManagement.App
{
    public class ViewModelLocator
    {
        private static CoffeeOverviewViewModel coffeeOverviewViewModel = new CoffeeOverviewViewModel();
        private static CoffeeDetailViewModel coffeeDetailViewModel = new CoffeeDetailViewModel(); 

        public static CoffeeDetailViewModel CoffeeDetailViewModel
        {
            get
            {
                return coffeeDetailViewModel;
            }
        }

        public static CoffeeOverviewViewModel CoffeeOverviewViewModel
        {
            get
            {
                return coffeeOverviewViewModel;
            }
        }
    }
}
