using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OkuhleNgada.Models
{
    public interface ITopping
    {
        String ToppingName { get; set; }
        double Price { get; set; }
        double TotalPrice { get; set; }
    }
}
