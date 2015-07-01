using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
   public   abstract class EmployeeComponent
    {


       public string Name { private set; get; }

       public EmployeeComponent(string name)
       
       {
           this.Name = name;       
       }

        public virtual void PrintSupervisorOf (int spacing)
        {


            for (int i = 0; i < spacing; i++)
            {
                Console.Write(" ");
            }


            Console.WriteLine(Name);

        }


    }
}
