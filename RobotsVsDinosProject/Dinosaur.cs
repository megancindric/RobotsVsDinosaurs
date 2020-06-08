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
        public Random random;

        //constructor (spawner)
        public Dinosaur()
        {
            //all dinos/robots will have same base creation
            //can pass in type through parameters of each unique dinosaur.  Can hard code health, 
            //could create random variable to use here to randomly generate energy and attack power
            //here we set random to = a new random class
            //look into .Next method for random
        }
        //member methods(can do...)
      public void DinosaurAttack(Robot robot)
        {
            //can attack one specific robot
            //will take into account attack power of attack selected by dino, translate this into health lost on robot
                //robot.health -= dino attack power
        }
        //Could create list of string they can select from.  We can create a new DinosaurAttack class for this array (and assign attack powers to each attack)

        //could create separate methods for different types of attack, each would require different energy and would do a different amount of damage
            //we can replicate this setup for robots & weapons as well.  These should be pre-established lists & options, with user option to select which method
    }
}
