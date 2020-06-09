using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace RobotsVsDinosProject
{
    class Battlefield
    {
        //member variables
        public Fleet robotFleet;
        public Herd dinoHerd;
        public bool dinosaurVictory;

        //constructor
        public Battlefield()
        {
            robotFleet = new Fleet();
            dinoHerd = new Herd();
        }
        //member methods
        public void FullBattleMethod(Fleet Fleet, Herd Herd)
        {
            Console.WriteLine("Welcome to Robots VS Dinosaurs!\nOur current teams are as follows: ");
            DisplayCurrentStats(dinoHerd.dinosaurHerd, robotFleet.robotFleet);
            Console.WriteLine("Press any key to begin the battle!");
            Console.ReadLine();

            while(Fleet.robotFleet.Count > 0 && Herd.dinosaurHerd.Count > 0)
            {
                BattleRound(Herd.dinosaurHerd, Fleet.robotFleet);
                DisplayCurrentStats(Herd.dinosaurHerd, Fleet.robotFleet);
                Console.WriteLine("Press any key to begin the next round!");
                Console.ReadLine();
            }

            if (Herd.dinosaurHerd.Count > Fleet.robotFleet.Count)
                {
                    Console.WriteLine("Sorry robots, looks like the dinosaurs win!");
                }
                else Console.WriteLine("Sorry dinosaurs, looks like the robots win!");
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
            //Will continue as long as Count of dinoHerd && robotFleet >= 0
     
        public bool DinosaurVictory()
        {
            dinosaurVictory = false;
            //refers to length of dino herd and length of dino fleet.  As they are defeated, count gets closer to 0.  When count is 0, they lose
            return dinosaurVictory;
        }
        public void DisplayCurrentStats(List<Dinosaur> dinoHerd, List<Robot> robotFleet)
        {
            //before instantiating this we will need to check if game is still running
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
            //this will be final step, outside of all other battlefield loops
        {
            if (dinosaurVictory == true)
            {
                Console.WriteLine("Sorry robots, looks like the dinosaurs win!");
            }
            else Console.WriteLine("Sorry dinosaurs, looks like the robots win!");
        }

    }
}
