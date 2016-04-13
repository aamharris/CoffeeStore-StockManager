using CoffeeStore.StockManagement.Extensions;
using CoffeeStore.StockManagement.Model;
using CoffeeStore.StockManagement.Services;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Windows.Input;

namespace CoffeeStore.StockManagement.ViewModel
{
    public class CoffeeOverviewViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Coffee> coffees;
        private CoffeeDataService coffeeDataService;
        private Coffee selectedCoffee;

        public ICommand EditCommand { get; set; }

        public ObservableCollection<Coffee> Coffees
        {
            get
            {
                return coffees;            
            }
            set
            {
                coffees = value;
                RaisePropertyChanged(GetPropertyName(() => this.coffees));
            }

        }

        public Coffee SelectedCoffee
        {
            get
            {
                return selectedCoffee;
            }
            set
            {
                selectedCoffee = value;
                RaisePropertyChanged(GetPropertyName(() => this.selectedCoffee));
            }

        }

        public CoffeeOverviewViewModel()
        {
            coffeeDataService = new CoffeeDataService();
            LoadData();
            LoadCommands();
        }

        private void LoadCommands()
        {
            //EditCommand = new CustomCommand()
        }

        private void LoadData()
        {
            Coffees = coffeeDataService.GetAllCoffees().ToObservableCollection(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string GetPropertyName<T>(Expression<Func<T>> propertyLambda)
        {
            var me = propertyLambda.Body as MemberExpression;

            if (me == null)
            {
                throw new ArgumentException("You must pass a lambda of the form: '() => Class.Property' or '() => object.Property'");
            }

            return me.Member.Name;
        }
    }
}
