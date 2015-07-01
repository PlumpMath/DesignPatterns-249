using CommandPattern.AbstractCommand;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
    public class LightOn : ICommand
    {

        Light light;


        public LightOn(Light light)
        {



            this.light = light;
        }



          public void Execute()
          {

              light.On();
          
          }



    }
}
