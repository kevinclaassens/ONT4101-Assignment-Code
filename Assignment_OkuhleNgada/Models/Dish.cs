using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Decorators;
using Assignment_OkuhleNgada.Observers;

namespace Assignment_OkuhleNgada.Models
{
    public interface Dish : ISubject
    {
        
        String Name { get; set; }
        DishOption Option { get; set; }
        Locale Country { get; set; }
        double Price { get; set; }
        ITopping Topping { get; set; }
    }
}
