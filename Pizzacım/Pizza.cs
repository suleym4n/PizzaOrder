using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzacım
{
    public class Pizza
    {
        public string PizzaName { get; set; }
        public int DefaultPrice { get; set; }
        
        public Pizza(string pizzaName, int defaultPrice)
        {
            PizzaName = pizzaName;
            DefaultPrice = defaultPrice;

        }
        public override string ToString()
        {
            return this.PizzaName;
        }




    }
}

