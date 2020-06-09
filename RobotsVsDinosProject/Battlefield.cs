using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace RobotsVsDinosProject
{
    class Battlefield
    {
        //member variables
        public Fleet fleet;
        public Herd herd;

        //constructor
        public Battlefield()
        {
            fleet = new Fleet();
            herd = new Herd();
        }
        //member methods
        public void FullBattleMethod()

        {
            Console.WriteLine("Welcome to Robots VS Dinosaurs!\nOur current teams are as follows: ");
            DisplayCurrentStats(herd.dinosaurHerd, fleet.robotFleet);
            Console.WriteLine("Press any key to begin the battle!");
            Console.ReadLine();

            while (fleet.robotFleet.Count > 0 && herd.dinosaurHerd.Count > 0)
            {
                DinoAttackRound(herd.dinosaurHerd, fleet.robotFleet);
                if (fleet.robotFleet.Count == 0)
                {
                    break;
                }
                RobotAttackRound(herd.dinosaurHerd, fleet.robotFleet);
                DisplayCurrentStats(herd.dinosaurHerd, fleet.robotFleet);
                Console.WriteLine("Press any key to begin the next round!");
                Console.ReadLine();
            }
            DisplayWinners();
         
        }
        public void DisplayWinners()
        {
            if (herd.dinosaurHerd.Count > fleet.robotFleet.Count)
            {
                Console.WriteLine("Sorry robots, looks like the dinosaurs win!");
            }
            else
            {
                Console.WriteLine("Sorry dinosaurs, looks like the robots win!");
            }
        }
        public void DinoAttackRound(List<Dinosaur> dinoHerd, List<Robot> robotFleet)
        {
            dinoHerd[0].DinosaurAttack(dinoHerd[0], robotFleet[0]);
            if (robotFleet[0].robotHealth <= 0)
            {
               Console.WriteLine($"Oh no, it looks like {robotFleet[0].robotName} has died!!  RIP in pieces");
               robotFleet.Remove(robotFleet[0]);
            }
        }    
        
        public void RobotAttackRound(List<Dinosaur> dinoHerd, List<Robot> robotFleet)
        {
            robotFleet[0].RobotAttack(robotFleet[0], dinoHerd[0]);
            if (dinoHerd[0].dinoHealth <= 0)
            {
                Console.WriteLine($"Uh oh!  Looks like {dinoHerd[0].dinoType} has died!  That sucks");
                dinoHerd.Remove(dinoHerd[0]);
            }
        }
       
        public void DisplayCurrentStats(List<Dinosaur> dinoHerd, List<Robot> robotFleet)
        {
            Console.WriteLine("Current Dinosaur Stats:");
            for (int i = 0; i < dinoHerd.Count; i++)
            {
                Dinosaur currentDino = dinoHerd[i];
                Console.WriteLine($"{currentDino.dinoType} has {currentDino.dinoHealth} health remaining and {currentDino.dinoEnergy} energy remaining!");
            }

            Console.WriteLine("Current Robot Stats");
            for (int i = 0; i < robotFleet.Count; i++)
            {
                Robot currentRobot = robotFleet[i];
                Console.WriteLine($"{ currentRobot.robotName} has {currentRobot.robotHealth} health remaining and {currentRobot.robotPowerLevel} power remaining!");
            }
        } 
    }
}
