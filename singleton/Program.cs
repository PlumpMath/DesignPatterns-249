using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creat object

            //  




         //   Logger log = new Logger();

            Logger log = Logger.GetInstance();

            log.WriteToFile("tttt");

            Console.ReadKey();




        }
    }
}
