using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.cs
{
    class Program
    {   // thie is the PC@!
        static void Main(string[] args)
        {
            USBAdapter usb = new USBAdapter();

            usb.ConnectA();

            Console.WriteLine("got the signal!");

            Console.ReadKey();


        }
    }
}
