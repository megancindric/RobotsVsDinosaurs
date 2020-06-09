using System;
using System.Collections.Generic;
using System.Reflection.Emit;
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
            //doesn't need to take in parameters because robotFleet & dinoHerd will be accessible at all levels (global variable)
            //ONLY METHODS USE PASCAL CASING, OTHERWISE USE CAMEL CASE
            //Can split this into multiple functions.  (See below)
        {
            Console.WriteLine("Welcome to Robots VS Dinosaurs!\nOur current teams are as follows: ");
            DisplayCurrentStats(herd.dinosaurHerd, fleet.robotFleet);
            Console.WriteLine("Press any key to begin the battle!");
            Console.ReadLine();

            while (fleet.robotFleet.Count > 0 && herd.dinosaurHerd.Count > 0)
            {
                BattleRound(herd.dinosaurHerd, fleet.robotFleet);
                DisplayCurrentStats(herd.dinosaurHerd, fleet.robotFleet);
                Console.WriteLine("Press any key to begin the next round!");
                Console.ReadLine();
            }
            DisplayWinners();
            //Let's turn this if statement into a DisplayWinners method! (then we will call it here)
         
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
        public void BattleRound(List<Dinosaur> dinoHerd, List<Robot> robotFleet)
        {
            Dinosaur dinosaur = dinoHerd[0];
            Robot robot = robotFleet[0];
            dinosaur.DinosaurAttack(dinosaur, robot);
            if (robot.robotHealth <= 0)
            {
               robotFleet.Remove(robot);
               Console.WriteLine($"Oh no, it looks like {robot.robotName} has died!!  RIP in pieces");
            }
            robot.RobotAttack(robot, dinosaur);
            if (dinosaur.dinoHealth <= 0)
            {
                dinoHerd.Remove(dinosaur);
                Console.WriteLine($"Uh oh!  Looks like {dinosaur.dinoType} has died!  That sucks");
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
        public void DeclareWinner(bool dinosaurVictory)
        {
            if (dinosaurVictory == true)
            {
                Console.WriteLine("Sorry robots, looks like the dinosaurs win!");
            }
            else Console.WriteLine("Sorry dinosaurs, looks like the robots win!");
        }

    }
}
