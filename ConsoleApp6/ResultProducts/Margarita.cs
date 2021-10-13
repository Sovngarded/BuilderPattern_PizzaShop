using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Margarita : PizzaBuilder
    {
        Pizza pizza = new Pizza();
        
        public override void SetTomatoes()
        {
            pizza.Add(new Tomatoes());
        }
        public override void SetOlives()
        {
            pizza.Add(new Olives());
        }
        public override void SetCheese()
        {

            pizza.Add(new Cheese());


        }
        public override void SetMeat()
        {

        }
        public override Pizza GetResult()
        {
            return pizza;
        }
    }
}
