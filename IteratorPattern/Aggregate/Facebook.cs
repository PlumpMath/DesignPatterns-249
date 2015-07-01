using IteratorPattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Aggregate
{
    public class Facebook : ISocialNetworking
    {
        private LinkedList<string> Users;

        public Facebook() 
        
        {    Users = new LinkedList<string> ();
            Users.AddLast("f1");
            Users.AddLast("f2");
            Users.AddLast("f3");
            Users.AddLast("f4");
   

        
        
        
        
        
        }



        public IIterator CreateIterator()
        {


            return new FacebookIterator(Users); 

        }








    }
}
