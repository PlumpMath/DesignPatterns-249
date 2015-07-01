using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterator
{
    class TwitterIterator : IIterator
    {


        private string[] Users;
        private int position;

        public TwitterIterator(string[] users) 
        
        
        
        {

            this.Users = users;
            position = 0;
           
        }



        public void First()
        {

            position = 0;
           // throw new NotImplementedException();
        }

        public string Next()
        {


            return Users[position++];
          //  throw new NotImplementedException();
        }

        public bool IsDone()
        {

            return position >= Users.Length; 
            //throw new NotImplementedException();
        }

        public string CurrentItem()
        {
            return Users[position];


           // throw new NotImplementedException();
        }
    }
}
