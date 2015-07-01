using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
  public abstract  class Pizza
    {

      // template method 
      public void MakePizza()
      {

          MakeDough();

          AddTomatoSauce();

          AddCheese();

          AddToppings();




      }

        public void MakeDough()
        {

            Console.WriteLine("worked the dought");


        }


        public void AddCheese()
        {

            Console.WriteLine("adding cheese");

        }


        public void AddTomatoSauce()
        {

            Console.WriteLine("adding TomatoSauce");

        }


        public abstract void AddToppings();


    }
}
