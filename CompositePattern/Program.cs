using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployeeComposite mark = new EmployeeComposite("Mark");
                    Employee catherine = new Employee("catherine");
                    Employee david = new Employee("david");

          
            EmployeeComposite kathy = new EmployeeComposite("Kathy");
               EmployeeComposite mike = new EmployeeComposite("Mike");
                   Employee gage = new Employee("Gage");
                   Employee reg = new Employee("Reggie ");



            // lori is the boss of Mark and Kathy 

           EmployeeComposite lori = new EmployeeComposite("Lori");

           lori.AddEmployee(mark);

           lori.AddEmployee(kathy);



            // mark is the boss of catherine and david 

           mark.AddEmployee(catherine);
           mark.AddEmployee(david); 


            // kathy is the boss of mike

           kathy.AddEmployee(mike);


            // mike is the boss of gage and reg


           mike.AddEmployee(gage);
          mike.AddEmployee(reg);


            // print , bny calling the top

          lori.PrintSupervisorOf(0);

          Console.ReadKey();











          







        }
    }
}
