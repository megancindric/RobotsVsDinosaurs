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
            //battlefield creates a new fleet and new herd, which means 3 dinos & 3 robots have been created
        }

        //member methods

        //Battle Fight
        public void DinoRobotFight()
        {
          //  do (dinosaur attack sequence)
            // do (robot attack sequence
            //while (dinoHerd.Count > 0 && robotFleet.Count > 0)
            {
                //for (int i = 0; i < dinoHerd.length; i++)
                {

                }
            }
           //first dinosaur will attack

           //then robots will attack
           //then we will display current standings
           //then we will repeat
        }
            //Will continue as long as Count of dinoHerd && robotFleet >= 0
            //Will first run for all dinosaurs, then run for all robots
            //Dinosaurs = for all Dinosaurs in dinoHerd
                //will select attack (randomly), then will select robot to attack (randomly)
                //if a robot health reaches 0 we will run RobotDeath method (this should display a message)
                //repeat this for robots
            //this continues as long as both sides have attackers.  When one hits 0 it will trigger DinosaurVictory boolean which will display winner

        //method for displaying current stats?
        
        //one "round" of fighting = iterating over entire dino herd & iterating over entire robot fleet
        //each will randomly select a value which corresponds to which index we attack of opponent
            //this random value will need to shrink in response to death 
        public bool DinosaurVictory()
        {
            dinosaurVictory = false;

            //refers to length of dino herd and length of dino fleet.  As they are defeated, count gets closer to 0.  When count is 0, they lose
            //can use this to create bool for if dinosaurs win or lose, then use this bool as parameter for victory statement
            return dinosaurVictory;
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
