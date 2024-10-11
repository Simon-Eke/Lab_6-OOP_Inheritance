using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Inheritance
{
    internal class FlyingFish : Fish
    {
        public bool SharpTeeth;
        public FlyingFish()
        {
            NumberOfLegs = 0;
            PrimaryColour = "Light Blue";
            PrimaryFoodSource = "Plankton";
            NumberOfWings = 2;
            Size = "Small";
            Habitat = "Sea or Ocean";
            SharpTeeth = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The flying fish flaps its fins and blubs.");
        }

        public void Fly()
        {
            if (NumberOfWings > 1)
            {
                Console.WriteLine("The flying fish soars above the waves.");
            }
        }
    }
}
