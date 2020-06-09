using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosProject
{
    class Dinosaur
    {
        //member variables(has a...)
        public string dinoType;
        //what other type could we make this
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;
        public Random random = new Random();

        //constructor (spawner)
        public Dinosaur(string dinoType)
        {
            //all dinos/robots will have same base creation

            this.dinoType = dinoType;
            dinoHealth = 100;
            dinoEnergy = 50;
            dinoAttackPower = random.Next(10,30);
        }
        //member methods(can do...)
        public Robot SelectRobotToAttack(List<Robot> robotFleet)
        {
            int index = random.Next(0, robotFleet.Count);
            Robot robotToAttack = robotFleet[index];
            return robotToAttack;
        }
        //OR do we return the int, then make parameter for dinosaur attack robotFleet[index]?
   
        public void DinosaurAttack(Robot robot)
        //this will take in parameter from select robot to attack method
        {
            robot.robotHealth -= dinoAttackPower;
            Console.WriteLine($"{robot.robotName} took {dinoAttackPower} damage and has {robot.robotHealth} health remaining!");
        }
        //Could create list of string they can select from.  We can create a new DinosaurAttack class for this array (and assign attack powers to each attack)

        //could create separate methods for different types of attack, each would require different energy and would do a different amount of damage
            //we can replicate this setup for robots & weapons as well.  These should be pre-established lists & options, with user option to select which method
    }
}
