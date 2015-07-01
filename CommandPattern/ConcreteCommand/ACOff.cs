using CommandPattern.AbstractCommand;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
   public class ACOff :ICommand
    {

                       AC ac;


         public ACOff(AC ac)
        {



            this.ac = ac;
        }



          public void Execute()
          {

              ac.TurnOff();
              ac.DecreaseTemp();
          
          }
    }
}
