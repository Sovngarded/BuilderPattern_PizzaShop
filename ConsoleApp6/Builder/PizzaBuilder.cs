using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class PizzaBuilder
    {
       
        public abstract void SetCheese();
        public abstract void SetTomatoes();
        public abstract void SetOlives();
        public abstract void SetMeat();

        public abstract Pizza GetResult();
    }
}
