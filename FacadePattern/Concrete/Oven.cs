using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Concrete
{
   public class Oven
    {
       public void SetTemperature (int temp)
       {

           Console.WriteLine("temp is : "+ temp);

       }

       public void SetTimer(double min)
       {

           Console.WriteLine("tim er is : " + min);

       }


     //  public void Cook(Dough dough)
   //    {

           // makie the pizza 



    //   }




    }
}
