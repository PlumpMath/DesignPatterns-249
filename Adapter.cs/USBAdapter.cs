using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.cs
{
    class USBAdapter
    {

        Mouse mouse = new Mouse();


        public void ConnectA()
        {
          
        mouse.ConnectB();
            Console.WriteLine("converting signal to USB");

            Console.WriteLine("SENDING new converted signals to PC");




        
        }


    }
}
