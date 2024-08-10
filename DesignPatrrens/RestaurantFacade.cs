using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatrrens
{
    public class RestaurantFacade
    {
        private IPizza _pizzaProvider;
        private IBread _BreadProvider;

        public RestaurantFacade(IPizza pizza, IBread bread)
        {
            _pizzaProvider = pizza;
            _BreadProvider = bread;
        }

        public void GetNonVegPizza()
        {
            _pizzaProvider.GetNonvegPizza();
        }

        public void GetVegPizza()
        {
            _pizzaProvider.GetVegPizza();
        }

        public void GetGarlicBread()
        {
            _BreadProvider.GetGarlicBread();
        }

        public void GetCheesyGarlicBread()
        {
            _BreadProvider.GetCheesyGarlicBread();
        }
    }
}
