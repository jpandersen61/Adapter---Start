using System;

namespace PizzaApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaOven pizzaOven = new PizzaOven();
            PizzaMan pizzaMan = new PizzaMan(pizzaOven);

            Console.WriteLine("Pizza order: Ham and Bacon");
            string[] order = { "Ham", "Bacon" };
            pizzaMan.TakeOrder(order);

            Console.WriteLine();

            Console.WriteLine("Pizza order: Ham and Pepperoni");
            string[] order2 = { "Ham", "Pepperoni" };
            pizzaMan.TakeOrder(order2);

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
