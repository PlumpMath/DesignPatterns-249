using FacadePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacadePattern
{
    class Program
    {  // the client
        static void Main(string[] args)
        {


           Client1();
            Client2();



        }

        static public void Client1()
        {

           

            PizzaFacade pf1 = new PizzaFacade( "Tomonate");

            pf1.MakePizza();

          //  Console.ReadKey();
     
        
        }


        static public void Client2()
        {

        
            PizzaFacade pf2 = new PizzaFacade("Tomonate2 "); //dough, sauce, greenPeppers, mozzarella);

            pf2.MakePizza();

            Console.ReadKey();
        }




    }
}
