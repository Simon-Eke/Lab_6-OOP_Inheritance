using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Inheritance
{
    public class Animal
    {
        // Klassen ska ha minst fem egenskaper som alla djur delar med varandra.
        public int NumberOfLegs;
        public string PrimaryColour;
        public string PrimaryFoodSource;
        public int NumberOfWings;
        public string Size;

        // Klassen ska också ha minst tre metoder som alla djur delar med varandra.
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal is not declared yet");
        }
        public static void Eat()
        {
            Console.WriteLine("Nam, nam");
        }
        public static void Sleep()
        {
            Console.WriteLine("ZZZzzz... zz.. z..");
        }

    }
}
