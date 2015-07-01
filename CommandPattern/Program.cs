using CommandPattern.ConcreteCommand;
using CommandPattern.Invoker;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {


          //  Existing stuff in the house


            Light bedRoomLights = new Light();


            AC acForTheHouse = new AC();


            // CREATE the On cmd

            LightOn trunbedRoomLightsOn = new LightOn(bedRoomLights);


            ACOn trunOnAC = new ACOn(acForTheHouse);


            // CREATE the off cmd

            LightOff trunbedRoomLightsOff = new LightOff(bedRoomLights);


            ACOff trunOffAC = new ACOff(acForTheHouse);



            // add the On  / off to the Remote

            RemoteController remote = new RemoteController();

            remote.InsertNewOnCommand(trunbedRoomLightsOn);
            remote.InsertNewOnCommand(trunOnAC);


            remote.InsertNewOffCommand(trunbedRoomLightsOff);
            remote.InsertNewOffCommand(trunOffAC);


            // turn on the Light and AC

            remote.PressButonOn(0);
            remote.PressButonOn(1);
         
            // turn off both
            remote.PressButonOff(0);
            remote.PressButonOff(1);




        }
    }
}
