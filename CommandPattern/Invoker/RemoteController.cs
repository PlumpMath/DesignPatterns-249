using CommandPattern.AbstractCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Invoker
{
   public class RemoteController
    {

      private IList<ICommand>  turnOnCommands = new List<ICommand>  ();

        private IList<ICommand>  turnOffCommands = new List<ICommand>();   // ac offf, light off


        public void InsertNewOnCommand(ICommand Command)
        {
            turnOnCommands.Add(Command);
        }


        public void InsertNewOffCommand(ICommand Command)
        {
            turnOffCommands.Add(Command);
        }




        public void PressButonOn(int buttonNumber )
        {
            turnOnCommands[buttonNumber].Execute();
        }

        public void PressButonOff(int buttonNumber)
        {
            turnOffCommands[buttonNumber].Execute();
        }

    }
}
