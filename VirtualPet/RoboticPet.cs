using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboticPet : Pet
    {
        public int Battery { get; set; }

        public int Rust { get; set; }

        public int Oil { get; set; }

        public RoboticPet() : base()
        {
            Battery = 100;
            Rust = 0;
            Oil = 100;
        }
        public int GetBattery()
        {
            return Battery;
        }
        public int GetRust()
        {
            return Rust;
        }
        public int GetOil()
        {
            return Oil;
        }
        public override void Feed()
        {
            Battery = 100;
            Console.WriteLine($"\nYou charged {Name}\n");
        }

        public override void SeeVet()
        {
            Oil = 100;
            Rust = Rust - 15;
            Console.WriteLine($"\nYou took {Name} to the Mechanic\n");
        }

        public override void Play()
        {
            Battery = Battery - 30;
            Rust = Rust - 20;
            Oil = Oil - 25;
            Console.WriteLine($"\nYou played with {Name}\n");
        }

        public override void Tick()
        {
            Battery = Battery - 5;
            Rust = Rust + 5;
            Oil = Oil - 5;
        }
        public override void CreatePet()
        {
            Console.WriteLine("What is your robopet's name?");
            Name = Console.ReadLine();
            Console.WriteLine("What is the species of your robopet?");
            Species = ("Robo" + Console.ReadLine());
            Console.WriteLine($"\nYou created a {Species} named {Name}\n");
        }
        public override void ShowPetStatus()
        {
            Console.WriteLine($"Status of {Name} the {Species}\n");
            Console.WriteLine($"Battery: {Battery}");
            Console.WriteLine($"Rust: {Rust}");
            Console.WriteLine($"Oil: {Oil}\n");

        }
    }
