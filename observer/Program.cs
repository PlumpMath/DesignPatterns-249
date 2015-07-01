using observer.Observer;
using observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {

            YoutubeChannel adrian = new YoutubeChannel();
            ISubscriber A = new User();
            ISubscriber B = new User();
            ISubscriber C = new Moderator();


            adrian.Subscribe(A);
            adrian.Subscribe(B);
            adrian.Subscribe(C);


            adrian.NotifySubscribe();

            Console.WriteLine("unsbu");

            adrian.Unsubscribe(B);
            adrian.NotifySubscribe();

            Console.ReadKey();
        }
    }
}
