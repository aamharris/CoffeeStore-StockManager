using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeStore.StockManagement.Model
{
    public class Coffee : INotifyPropertyChanged
    {
        private int coffeeId;
        private string coffeeName;
        private int price;

        public int CoffeeId
        {
            get
            {
                return coffeeId;
            }
            set
            {
                coffeeId = value;
                RaisePropertyChanged( GetPropertyName(() => this.CoffeeId));
            }
        }

        public string CoffeeName
        {
            get
            {
                return coffeeName;
            }
            set
            {
                coffeeName = value;
                RaisePropertyChanged( GetPropertyName(() => this.coffeeName));
            }
        }
        public int Price { get; set; }
        public string Description { get; set; }
        public Country OriginCountry { get; set; }
        public bool InStock { get; set; }
        public int InventoryAmount { get; set; }
        public DateTime DateAdded { get; set; }
        public int ImageId { get; set; }

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
