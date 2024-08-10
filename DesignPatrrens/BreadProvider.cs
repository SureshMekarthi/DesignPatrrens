using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatrrens
{
    public class BreadProvider : IBread
    {
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
        }

        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }

        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
        }
    }
}
