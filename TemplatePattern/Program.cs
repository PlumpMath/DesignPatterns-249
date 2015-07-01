using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizza pizza = new MeatLoverPizza();

            pizza.MakePizza();


            Pizza pizza2 = new VeggiePizza();
            pizza2.MakePizza();


            Console.WriteLine("");
            Console.ReadKey();

        }
    }
}
