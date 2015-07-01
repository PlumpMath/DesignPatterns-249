using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            IceCream iceCream = new Vanilla();


            iceCream = new Sprinkle(iceCream);

            iceCream = new Fudge(iceCream);


            Console.WriteLine(iceCream.Cost());

            Console.ReadKey();



        }
    }
}
