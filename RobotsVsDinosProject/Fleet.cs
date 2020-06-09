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
        public void RobotFleetAttack()
        {
            //this will create our loop for every robot attacking
            for (int i = 0; i < robotFleet.Count; i++)
            {
                //select dino to attack
                //Attack that dino
            } 
        }
        public void RobotDeath(Robot robot)
        {
            robotFleet.Remove(robot);
            Console.WriteLine($"Oh no, it looks like {robot.robotName} has died!!  RIP in pieces");
        }
    }
}
