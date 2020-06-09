using System;
using System.Dynamic;

namespace RobotsVsDinosProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            //things to ask David:
                    //focus on "watching the battle go down"
                    //weapons/attack selection can be via random number OR user input

            //There is a dinosaur herd and a robot fleet each with 3 members
            //randomizer to select which will attack first
                //can we potentially loop through all 3 objects (dinos/robots) and allow each a separate instance of attacking?
                //attacking will be member methods of dinos/robots respectively (we will somehow translate attack power into how much HP opponent loses)
                        //attack methods can have parameter of robot/dino that is being attacked
                //After each round display health/energy of everyone

            //if statements for when a particular member is knocked out
                //will no longer be able to attack, will display a message to inform player
                    //Remove from herd/fleet list
                    //can treat this as iterating through a for loop.  Then when members are removed we can adjust(Herd.length) and keep attacking
                //when all members are knocked out, (ie Herd.Dinosaurs.count == 0) [herd is the class, with a list of dinosaurs within it.] 
            //announce victory of opponent
        }   
    }
}
