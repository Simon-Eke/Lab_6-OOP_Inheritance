using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Inheritance
{
    internal class Animal
    {
        // Klassen ska ha minst fem egenskaper som alla djur delar med varandra.
        public int NumberOfLegs { get; set; }
        public required string PrimaryColour { get; set; }
        public required string PrimaryFoodSource { get; set; }
        public int NumberOfWings { get; set; }
        public int Size { get; set; }

        // Det ska finnas en konstruktor som kan användas för att skapa nya djur.

        public Animal()
        {
            
        }

        // Klassen ska också ha minst tre metoder som alla djur delar med varandra.
        public void MakeSound()
        {

        }
        public void Eat()
        {

        }
        public void Sleep()
        {

        }

    }
}
