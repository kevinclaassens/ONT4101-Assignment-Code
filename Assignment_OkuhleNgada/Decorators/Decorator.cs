using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Models;

namespace Assignment_OkuhleNgada.Decorators
{
    public abstract class Decorator : Dish
    {
        public Dish Dish { get; set; }
        public string Name { get; set; }
        public DishOption Option { get; set; }
        public Locale Country { get; set; }
        public double Price { get; set; }
        public List<IObserver> ObserverList = new List<IObserver>();
        

        public Decorator(Dish MyDish)
        {
            Dish = MyDish;
        }
        public virtual String GetDescription() {

            return Dish.Name;
        }
        public virtual double GetCost()
        {
            return Dish.Price;
        }

        public void Register(IObserver observer)
        {
            ObserverList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            ObserverList.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver Observer in ObserverList)
            {
                Observer.Update();
            }
        }

        public ITopping Topping { get; set; }
        Models.ITopping Dish.Topping { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
