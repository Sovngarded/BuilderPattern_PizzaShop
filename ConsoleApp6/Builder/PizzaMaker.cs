using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class PizzaMaker
    {
        PizzaBuilder pizzaBuilder;
        public PizzaMaker(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public void Bake()
        {   
            pizzaBuilder.SetCheese();
            pizzaBuilder.SetTomatoes();
            pizzaBuilder.SetOlives();           
            pizzaBuilder.SetMeat();
        }


    }
}
