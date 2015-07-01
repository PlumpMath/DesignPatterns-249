using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Car : Vehicle 
    {

        public int  wheels  ; 

          public Car ( int wheels)
    
          {
                 this.wheels = wheels ;  
    
           }



    }
}
