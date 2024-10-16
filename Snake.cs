﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Inheritance
{
    internal class Snake : Animal
    {
        public string Habitat;
        public Snake()
        {
            NumberOfLegs = 0;
            PrimaryColour = "Camoflaged to the environment";
            PrimaryFoodSource = "Frogs";
            NumberOfWings = 0;
            Size = "Small";
            Habitat = "in rocks and crevices";
        }

        public override void MakeSound()
        {
            Console.WriteLine("The snake hisses.");
        }

        public void Hide()
        {
            Console.WriteLine($"The snake hides {Habitat}");
        }
    }
}
