using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Decorators;
using Assignment_OkuhleNgada.Observers;

namespace Assignment_OkuhleNgada.Models
{
    public class Burrito : ISubject, Dish
    {
        public string Name { get; set; } = "Burrito Dish";
        public DishOption Option { get; set; }
        public Locale Country { get; set; }
        public double Price { get; set; } = 45.00;
        public ITopping Topping { get; set; }

        private List<IObserver> ObserverList;

        public Burrito ()
        {
            ObserverList = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (IObserver Observer in ObserverList)
            {
                Observer.Update();
            }
        }

        public void Register(IObserver observer)
        {
            ObserverList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            ObserverList.Remove(observer);
        }
    }
}
