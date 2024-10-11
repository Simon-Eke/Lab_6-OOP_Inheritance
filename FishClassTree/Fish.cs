using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Inheritance
{
    internal class Fish : Animal
    {
        public string Habitat;
        public Fish()
        {
            NumberOfLegs = 0;
            PrimaryColour = "Colourful";
            PrimaryFoodSource = "Smaller fish or plants";
            NumberOfWings = 0;
            Size = "Small";
            Habitat = "sea";
        }

        public override void MakeSound()
        {
            Console.WriteLine("The fish blubs.");
        }

        public void Move()
        {
            Console.WriteLine($"The fish swims in the {Habitat}");
        }
    }
}
