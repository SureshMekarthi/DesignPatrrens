using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatrrens
{
    public class PizzaProvider : IPizza
    {
        public void GetNonvegPizza()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Pizza.");
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Getting  Veg Pizza.");
        }

        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Pizza Toppings.");
        }
    }
}
