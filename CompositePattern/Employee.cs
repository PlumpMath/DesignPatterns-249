using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Employee  : EmployeeComponent // leaf
    {


        public Employee (string name)  : base (name )
        {




        }


        public virtual void PrintSupervisorOf(int spacing)
        {

            base.PrintSupervisorOf(spacing);
          

        }


    }
}
