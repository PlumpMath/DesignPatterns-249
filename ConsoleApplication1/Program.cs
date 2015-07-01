using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            IWeapon weapon ;

            Character MikeA = new Character();


            while (true) {


                Console.WriteLine("1 s, 2 a , 3 c");
                string input = Console.ReadLine();

                switch (input) { 
                
                    case "1" :

                        weapon = new Sword();
                        break;

                    case "2":

                        weapon = new Axe();
                        break;

                    case "3":

                        weapon = new Club();
                        break;

                    default :

                        weapon = new Null();
                        break;
                
                
                
                
                }


                MikeA.SetWeapon(weapon);
                MikeA.Attack();


            
            }


        }
    }
}
