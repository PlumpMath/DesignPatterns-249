using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using observer.Observer;

namespace observer.Subject
{
    class YoutubeChannel
    {

        private IList<ISubscriber> subscribeers = new List<ISubscriber>();


        public void Subscribe(ISubscriber s )
        {


            subscribeers.Add(s);

            Console.WriteLine();

        }

        public void Unsubscribe(ISubscriber s)
        {
            subscribeers.Remove(s);

            Console.WriteLine();
        }




        public void NotifySubscribe()
        {
            foreach (ISubscriber s in subscribeers) 
            
            {

                s.Notify();
            
            }

            Console.WriteLine();
        }

    }
}
