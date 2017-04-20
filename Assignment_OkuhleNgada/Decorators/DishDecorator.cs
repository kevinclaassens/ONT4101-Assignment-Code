using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_OkuhleNgada.Models;

namespace Assignment_OkuhleNgada.Decorators
{
    public interface ITopping : Dish
    {
        string GetDescription();
        double GetCost();
    }
}
