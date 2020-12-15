using System;
using System.Reflection;

namespace KassaSysteem
{
    class Program
    {
        static Register register;

        static void Main(string[] args)
        {
            Console.WriteLine($"Register system.");

            // Entry into program.
            register = new Register(500);

            // TODO create test register
            var milk = new Product(0, "LekkerMelk", 5.0, 0.0);
            var eggs = new Product(1, "Eieren in doos", 3.0, 5.0);
            var meatballs = new Product(2, "Gehaktbal voorgebakken", 6.0, 1.0);
            var candycanes = new Product(3, "Kerst candy canes", 2.0, 0.0);
            var chocolatemilk = new Product(4, "Chocolademelk", 5.0, 0.0);
            var tacoshells = new Product(5, "Tacoschelpen", 3.0, 0.0);
            var tacobeef = new Product(6, "Taco vlees", 6.0, 1.0);
            var tacospices = new Product(7, "Taco kruiden", 1.0, 0.0);
            var creamcheese = new Product(8, "Roomkaas", 5.0, 0.0);

            var stock = new Stock();
            stock.AddItem(milk);
            stock.AddItem(eggs);
            stock.AddItem(meatballs);
            stock.AddItem(candycanes);
            stock.AddItem(chocolatemilk);
            stock.AddItem(tacoshells);
            stock.AddItem(tacobeef);
            stock.AddItem(tacospices);
            stock.AddItem(creamcheese);
            register.stock = stock;
        }
    }
}
