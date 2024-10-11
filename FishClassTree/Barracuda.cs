using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Inheritance
{
    internal class Barracuda : Fish
    {
        public bool SharpTeeth;
        public Barracuda()
        {
            NumberOfLegs = 0;
            PrimaryColour = "grey";
            PrimaryFoodSource = "smaller fish";
            NumberOfWings = 0;
            Size = "Medium";
            Habitat = "Sea or Ocean";
            SharpTeeth = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The barracuda gnaws and blubs.");
        }
        public void Gnaw()
        {
            if (SharpTeeth)
            {
                Console.WriteLine($"The barracuda eats a {PrimaryFoodSource}");
            }
        }
    }
}
