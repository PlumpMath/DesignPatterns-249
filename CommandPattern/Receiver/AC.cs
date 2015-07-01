using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
  public  class AC
    {
        public void TurnOn ()
        {


            Console.WriteLine("AC is on");

        }


        public void TurnOff()
        {


            Console.WriteLine("AC is off");

        }


        public void IncreaseTemp()
        {


            Console.WriteLine("AC is increasing");

        }


        public void DecreaseTemp()
        {


            Console.WriteLine("AC is decreasing");

        }



    }
}
