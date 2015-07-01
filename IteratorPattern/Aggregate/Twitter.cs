using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Aggregate
{
    public class Twitter : ISocialNetworking
    {

        private string[] Users;

        public Twitter()
        {


            Users = new[] { "t1", "t2", "t3", "t4" };

        }

        public IIterator CreateIterator()
        {


            return new TwitterIterator(Users); 

        }



    }
}
