using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosProject
{
    class Fleet
    {
        //member variables(has a...)
        public List<Robot> robotFleet;
        //constructor (spawner)
        public Fleet()
        {
            robotFleet = new List<Robot>();
            List<string> robotTypes = new List<string>() {"BB-8", "WALL-E", "Bender" };
            for (int i = 0; i < 3; i++)
            {
                Robot robot = new Robot(robotTypes[i]);
                robotFleet.Add(robot);
            }
        }
        //member methods(can do...)
      

    }
}
