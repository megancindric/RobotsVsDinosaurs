using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosProject
{
    class Dinosaur
    {
        //member variables(has a...)
        public string dinoType;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;
        public Attack dinoAttack;
        public Random random = new Random();
        public AttackArray attackArray = new AttackArray();

        //constructor (spawner)
        public Dinosaur(string dinoType)
        {
            this.dinoType = dinoType;
            dinoHealth = 100;
            dinoEnergy = 50;
            dinoAttack = SelectAttack(attackArray);
            dinoAttackPower = random.Next(10,30) + dinoAttack.attackPower;
        }
        //member methods(can do...)

        public Attack SelectAttack(AttackArray attackArray)
        {
            int index = random.Next(0, 4);
            Attack currentAttack = attackArray.attackArray[index];
            return currentAttack;
        }
        public void DinosaurAttack(Dinosaur dinosaur, Robot robot)
        {
            robot.robotHealth -= dinoAttackPower;
            dinosaur.dinoEnergy -= 10;
            Console.WriteLine($"{dinosaur.dinoType} attacks {robot.robotName} with {dinosaur.dinoAttack.attackType} and did {dinoAttackPower} damage. {robot.robotName} has {robot.robotHealth} health remaining!");
        }
        //Could create list of string they can select from.  We can create a new DinosaurAttack class for this array (and assign attack powers to each attack)

        //could create separate methods for different types of attack, each would require different energy and would do a different amount of damage
            //we can replicate this setup for robots & weapons as well.  These should be pre-established lists & options, with user option to select which method
    }
}
