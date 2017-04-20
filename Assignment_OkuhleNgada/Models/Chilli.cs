using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Decorators;

namespace Assignment_OkuhleNgada.Models
{
    public class Chilli : ITopping
    {
        private Dish Dish;
        public String ToppingName { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }

        public Chilli(Dish newDish, String Name, double Price) 
        {
            Dish = newDish;
            ToppingName = $"{newDish.Topping.ToppingName} , with {Name}";
            this.Price = Price;
            TotalPrice = newDish.Topping.Price + Price;
        }
    }
}
