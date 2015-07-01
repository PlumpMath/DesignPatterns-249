using CommandPattern.AbstractCommand;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
    public class LightOff : ICommand
    {


        Light light;


        public LightOff(Light light)
        {



            this.light = light;
        }



          public void Execute()
          {

              light.Off();
          
          }




    }
}
