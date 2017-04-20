using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Models;

namespace Assignment_OkuhleNgada.Factories
{
    public class BurritoWorldZA : AbstractFactory
    {
        public override Dish CreateDish(DishType Type, DishOption Option)
        {
            Dish resultDish;

            if (Type == DishType.Burrito)
            {
                resultDish = new Burrito();
                resultDish.Topping = new DefaultTopping("Burrito");
                resultDish.Country = Locale.ZA;
                resultDish.Price = 45.00;
                if (Option == DishOption.Chicken)
                {
                    resultDish.Option = DishOption.Chicken;
                }
                else if (Option == DishOption.Meat)
                {
                    resultDish.Option = DishOption.Meat;
                }
                else
                {
                    resultDish.Option = DishOption.Vegitarian;
                }
                return resultDish;
            }
            else
            {
                resultDish = new Taco();
                resultDish.Topping = new DefaultTopping("Taco");
                resultDish.Country = Locale.ZA;
                resultDish.Price = 40.00;
                if (Option == DishOption.Chicken)
                {
                    resultDish.Option = DishOption.Chicken;
                }
                else if (Option == DishOption.Meat)
                {
                    resultDish.Option = DishOption.Meat;
                }
                else
                {
                    resultDish.Option = DishOption.Vegitarian;
                }

                return resultDish;
            }
        }

       
    }
}
