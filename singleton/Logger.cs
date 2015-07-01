using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class Logger
    {

        private static Logger logger;

        private Logger() 
        
        {

          //  logger = null; 
        
        
        }


        public static Logger GetInstance() 
        {

            if (null == logger)
            {
                logger = new Logger();



            }


            return logger;
        
        }



        public void WriteToFile(string msg)
        {

            Console.WriteLine(msg);
        
        }



    }
}
