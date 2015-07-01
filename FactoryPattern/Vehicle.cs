using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Vehicle
    {

             public static Vehicle create(string type, int  wheels)
                {
                    switch(type) {
                        case "car":
                            return new Car(wheels);
                        case "truck":
                            return new Truck(wheels);
                        default:
                            return new Vehicle();
                    }
                }


                public string getType()
                {
                    return this.GetType().Name;
                }



    }
}
