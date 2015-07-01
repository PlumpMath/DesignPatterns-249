using CommandPattern.AbstractCommand;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
   public class ACOn :ICommand

    {

               AC ac;


         public ACOn(AC ac)
        {



            this.ac = ac;
        }



          public void Execute()
          {

              ac.TurnOn();
              ac.IncreaseTemp();
          
          }



    }
}
