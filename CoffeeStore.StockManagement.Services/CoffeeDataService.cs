using CoffeeStore.StockManagement.Data;
using CoffeeStore.StockManagement.Model;
using System.Collections.Generic;

namespace CoffeeStore.StockManagement.Services
{
    public interface ICoffeeDataService
    {
        void DeleteCoffee(Coffee coffee);
        List<Coffee> GetAllCoffees();
        Coffee GetCoffeeDetail(int coffeeId);
        void UpdateCoffee(Coffee coffee);
    }

    public class CoffeeDataService : ICoffeeDataService
    {
        ICoffeeRepository repository = new CoffeeRepository();
        public CoffeeDataService()
        {
            this.repository = repository;
        }

        public Coffee GetCoffeeDetail(int coffeeId)
        {
            return repository.GetCoffeeById(coffeeId);
        }

        public List<Coffee> GetAllCoffees()
        {
            return repository.GetCoffees();
        }

        public void UpdateCoffee(Coffee coffee)
        {
            repository.UpdateCoffee(coffee);
        }

        public void DeleteCoffee(Coffee coffee)
        {
            repository.DeleteCoffee(coffee);
        }
    }
}
