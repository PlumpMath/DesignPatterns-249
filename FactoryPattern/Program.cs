using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
                                Vehicle    car = Vehicle.create("car", 4);
                       
             Console.WriteLine( car.getType() );



              car = Vehicle.create("truck", 18);
                    
                   
            
            
            Console.WriteLine( car.getType() );


            Console.ReadKey();


        }
    }
}
