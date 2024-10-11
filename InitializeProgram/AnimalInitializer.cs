using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Inheritance
{
    public static class AnimalInitializer
    {
        public static void MakeSounds()
        {
            // 5 different animals are created 
            Snake snek = new Snake();
            Tiger tigrrrr = new Tiger();
            Fish grönis = new Fish();
            Barracuda queen = new Barracuda();
            FlyingFish prettyFlyForAWhiteGuy = new FlyingFish();


            // I wanted to incorporate list<T> to try and work with it.
            List<Animal> Animals = new List<Animal>();
            Animals.Add(snek);
            Animals.Add(tigrrrr);
            Animals.Add(grönis);
            Animals.Add(queen);
            Animals.Add(prettyFlyForAWhiteGuy);


            // Every animal will now make a sound
            foreach (var animal in Animals)
            {
                animal.MakeSound();
            }

            Console.WriteLine();
            tigrrrr.Hunt();
            snek.Hide();
            Console.WriteLine();
            grönis.Move();
            queen.Gnaw();
            prettyFlyForAWhiteGuy.Fly();
        }


    }
}
