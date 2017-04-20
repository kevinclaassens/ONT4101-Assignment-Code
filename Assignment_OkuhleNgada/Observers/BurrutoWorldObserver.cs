using Assignment_OkuhleNgada.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Models;

namespace Assignment_OkuhleNgada.Observers
{
    public class BurrutoWorldObserver : IObserver
    {

        private ISubject TheSubject;
        private String dishType;

        public BurrutoWorldObserver(ISubject TheSubject, String dishType)
        {
            this.TheSubject = TheSubject;
            this.dishType = dishType;
        }

        public void Update()
        {
            if (dishType == "Burrito")
            {
                Console.WriteLine("Your Burrito is as follows: ");
                if (((Dish)TheSubject).Option == DishOption.Chicken)
                {
                    ((Dish)TheSubject).Price += 15.00;
                    Console.WriteLine("Burrito Type: Chicken");
                    Console.WriteLine();
                    Console.WriteLine($"Your Toppings: {((Dish)TheSubject).Topping.ToppingName}");
                    Console.WriteLine($"Your Bill (USD): {((Dish)TheSubject).Topping.TotalPrice + ((Dish)TheSubject).Price}");
                    Console.ReadLine();
                } else if (((Dish)TheSubject).Option == DishOption.Meat)
                {
                    ((Dish)TheSubject).Price += 20.00;
                    Console.WriteLine("Burrito Type: Meat");
                    Console.WriteLine();
                    Console.WriteLine($"Your Toppings: {((Dish)TheSubject).Topping.ToppingName}");
                    Console.WriteLine($"Your Bill (USD): {((Dish)TheSubject).Topping.TotalPrice + ((Dish)TheSubject).Price}");
                    Console.ReadLine();
                } else
                {
                    ((Dish)TheSubject).Price += 10.00;
                    Console.WriteLine("Burrito Type: Vegitarian");
                    Console.WriteLine();
                    Console.WriteLine($"Your Toppings: {((Dish)TheSubject).Topping.ToppingName}");
                    Console.WriteLine($"Your Bill (USD): {((Dish)TheSubject).Topping.TotalPrice + ((Dish)TheSubject).Price}");
                    Console.ReadLine();
                }
            } else
            {
                Console.WriteLine("Your Taco is as follows: ");
                if (((Dish)TheSubject).Option == DishOption.Chicken)
                {
                    ((Dish)TheSubject).Price += 15.00;
                    Console.WriteLine("Taco Type: Chicken");
                    Console.WriteLine();
                    Console.WriteLine($"Your Toppings: {((Dish)TheSubject).Topping.ToppingName}");
                    Console.WriteLine($"Your Bill (USD): {((Dish)TheSubject).Topping.TotalPrice + ((Dish)TheSubject).Price}");
                    Console.ReadLine();
                }
                else if (((Dish)TheSubject).Option == DishOption.Meat)
                {
                    ((Dish)TheSubject).Price += 20.00;
                    Console.WriteLine("Taco Type: Meat");
                    Console.WriteLine();
                    Console.WriteLine($"Your Toppings: {((Dish)TheSubject).Topping.ToppingName}");
                    Console.WriteLine($"Your Bill (USD): {((Dish)TheSubject).Topping.TotalPrice + ((Dish)TheSubject).Price}");
                    Console.ReadLine();
                }
                else
                {
                    ((Dish)TheSubject).Price += 10.00;
                    Console.WriteLine("Taco Type: Vegitarian");
                    Console.WriteLine();
                    Console.WriteLine($"Your Toppings: {((Dish)TheSubject).Topping.ToppingName}");
                    Console.WriteLine($"Your Bill (USD): {((Dish)TheSubject).Topping.TotalPrice + ((Dish)TheSubject).Price}");
                    Console.ReadLine();
                }
            }
        }
    }
}
