using System;
using System.Dynamic;

namespace RobotsVsDinosProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();
            battlefield.FullBattleMethod(battlefield.robotFleet, battlefield.dinoHerd);

            //dino herd and robot fleet have been instantiated

                //attacking will be member methods of dinos/robots respectively (we will somehow translate attack power into how much HP opponent loses)
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
