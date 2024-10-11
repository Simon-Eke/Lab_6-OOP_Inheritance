using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Inheritance
{
    internal class Tiger : Animal
    {
        public string Habitat;
        public Tiger()
        {
            NumberOfLegs = 4;
            PrimaryColour = "Orange, White & Black";
            PrimaryFoodSource = "meat";
            NumberOfWings = 0;
            Size = "Big";
            Habitat = "savannah";
        }

        public override void MakeSound()
        {
            Console.WriteLine("The tiger roars.");
        }

        public void Hunt()
        {
            Console.WriteLine($"The Tiger is on the hunt for some {PrimaryFoodSource} on the {Habitat}");
        }
    }
}
