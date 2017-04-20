using Assignment_OkuhleNgada.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Decorators;

namespace Assignment_OkuhleNgada.Models
{
    public class Taco : Dish, ISubject
    {
        public string Name { get; set; } = "Taco Dish";
        public DishOption Option { get; set; }
        public Locale Country { get; set; }
        public double Price { get; set; } = 40.00;
        public ITopping Topping { get; set; }

        private List<IObserver> ObserverList;

        public Taco()
        {
            ObserverList = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in ObserverList)
            {
                observer.Update();
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
