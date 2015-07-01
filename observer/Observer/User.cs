using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.Observer
{
    public class User : ISubscriber
    {
        public void Notify()
        {

            Console.WriteLine("USER HAS BEEN UNPDATEDE ");


        }


    }
}
