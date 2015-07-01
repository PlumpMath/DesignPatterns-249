using FacadePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class PizzaFacade
    {
         private Dough dough;

         public Sauce sauceOB;

         public string saucep;

         private  Topping top;

         private Cheese cheese;

         private Oven oven;

         public string sauceps;




 
        public PizzaFacade   (  string  sauce)  //,  Topping top , Cheese cheese)
        {
           // this.dough = dough;  

            this.saucep = sauce;
          //  this.top = top;

       //     this.cheese = cheese;
         //   this.s

         
        

        
        
        
        }

        public void MakePizza()
        {


            Dough dough = new Dough();
            Sauce sauceOB = new Sauce(saucep);
       //     Topping mushroom = new Topping();
         //   Cheese mozzarella = new Cheese("mozzarla");
         //   Oven oven = new Oven();

          //   Console.WriteLine(sauce);

            dough.AddSauce(sauceOB.p);
            
         //  dough.AddSauce(new Sauce(sauce).p);
       //     dough.AddCheese(cheese);
        //    dough.AddTopping(top);
         //   oven.SetTemperature(425);
        //    oven.SetTimer(20);
        //    oven.Cook(dough);
        
        
        
        }

    }
}
