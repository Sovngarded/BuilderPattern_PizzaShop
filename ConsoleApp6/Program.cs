using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What pizza do you want? (A) - Margarita (B) - Carbonara (C) - Italian (D) - Pepperoni");
            char input = Console.ReadKey().KeyChar;
            bool flag = true;

            PizzaBuilder pizzaBuilder;
            switch (input)
            {
                case 'A':
                    pizzaBuilder = new Margarita();
                    break;

                case 'B':
                    pizzaBuilder = new Carbonara();
                    break;

                case 'C':
                    pizzaBuilder = new Italian();
                    break;

                case 'D':
                    pizzaBuilder = new Pepperoni();
                    break;


                default:
                    throw new NotImplementedException();

            }


            
            PizzaMaker pizzaMaker = new PizzaMaker(pizzaBuilder);
            pizzaMaker.Bake();
            Pizza pizza = pizzaBuilder.GetResult();
            
           
            

            Console.WriteLine("Whant to add exta Cheese? Y or N");

            
            while (flag == true)
            {
                char inputnext = Console.ReadKey().KeyChar;
                switch (inputnext)
                {
                    case 'Y':
                        pizza.Add(new Cheese()); 
                        break;

                    case 'N':
                        flag = false;
                        break;
                        

                    default:
                        throw new NotImplementedException();
                }
            }
            flag = true;
            Console.WriteLine("Whant to add exta Olives? Y or N");
            while (flag == true)
            {
                char inputnext = Console.ReadKey().KeyChar;
                switch (inputnext)
                {
                    case 'Y':
                        pizza.Add(new Olives());
                        break;

                    case 'N':
                        flag = false;
                        break;


                    default:
                        throw new NotImplementedException();
                }
            }
            flag = true;
            Console.WriteLine("Whant to add exta Tomatoes? Y or N");
            while (flag == true)
            {
                char inputnext = Console.ReadKey().KeyChar;
                switch (inputnext)
                {
                    case 'Y':
                        pizza.Add(new Tomatoes());
                        break;

                    case 'N':
                        flag = false;
                        break;


                    default:
                        throw new NotImplementedException();
                }
            }
            flag = true;
            Console.WriteLine("Whant to add exta Meat? Y or N");
            while (flag == true)
            {
                char inputnext = Console.ReadKey().KeyChar;
                switch (inputnext)
                {
                    case 'Y':
                        pizza.Add(new Meat());
                        break;

                    case 'N':
                        flag = false;
                        break;


                    default:
                        throw new NotImplementedException();
                }
            }


           

            




        }

        

    }
}
