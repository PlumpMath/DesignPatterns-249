using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer.Observer
{
    class Moderator : ISubscriber
    {


        public void Notify ()
        {

            Console.WriteLine("MODERTAT ");


        }


    }
}
