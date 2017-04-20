using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OkuhleNgada.Models
{
    class DefaultTopping : ITopping
    {
        public String ToppingName { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }

        public DefaultTopping(String dishName)
        {
            ToppingName = dishName + "";
            Price = 0;
            TotalPrice = 0;
        }
    }
}
