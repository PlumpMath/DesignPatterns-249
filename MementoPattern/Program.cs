using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            IList<Memento> undos = new List<Memento>();

            Notepad notepad = new Notepad();


            Memento undo;


            // frist revision

             undo =   notepad.SetText("cool");

             undos.Add(undo);

             Console.WriteLine("curretly in the notepade   ");
             Console.WriteLine(notepad.GetText());



             // sec revision

             undo = notepad.SetText("hello,  i ma m, if youare reidng  cool ");

             undos.Add(undo);


             Console.WriteLine("currenlty in the notepad ++  ");

                Console.WriteLine(notepad.GetText());

                Console.WriteLine("issue undo cmd   ");

                notepad.Undo(undos[1]);




                Console.WriteLine("curretly in the notepade (after undo   ");  
                Console.WriteLine(notepad.GetText());


                Console.WriteLine("issue undo cmd   ");

                notepad.Undo(undos[0]);

                Console.WriteLine("curretly in the notepade (after undo   ");
                Console.WriteLine(notepad.GetText());


                Console.ReadKey();
        }
    }
}
