using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatrrens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Cleint orders pizaa---");

            var serviceProvider = new ServiceCollection()
                .AddScoped<IBread, BreadProvider>().AddSingleton<IPizza, PizzaProvider>()
                .AddSingleton<RestaurantFacade>().BuildServiceProvider();

            var facadeForCleint = serviceProvider.GetService<RestaurantFacade>();

            facadeForCleint.GetVegPizza();
            Console.WriteLine("--- Cleint orders pizaa complted---");
        }
    }
}
