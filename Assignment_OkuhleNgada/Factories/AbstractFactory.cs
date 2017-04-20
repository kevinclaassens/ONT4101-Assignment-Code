using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Models;

namespace Assignment_OkuhleNgada.Factories
{
    public abstract class AbstractFactory
    {
        public abstract Dish CreateDish(DishType Type, DishOption Option);
    }
}
