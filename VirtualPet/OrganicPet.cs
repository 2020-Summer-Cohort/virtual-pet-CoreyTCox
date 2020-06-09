using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class OrganicPet : Pet
    {
        public int Hunger { get; set; }

        public int Boredom { get; set; }

        public int Health { get; set; }

        public OrganicPet() : base()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }
        public int GetBoredom()
        {
            return Boredom;
        }
        public int GetHealth()
        {
            return Health;
        }
        public int GetHunger()
        {
            return Hunger;
        }
        public override void Feed()
        {
            Hunger = Hunger - 40;
            Console.WriteLine($"\nYou fed {Name}\n");
        }

        public override void SeeVet()
        {
            Health = Health + 30;
            Console.WriteLine($"\nYou took {Name} to the Vet\n");
        }

        public override void Play()
        {
            Hunger = Hunger + 10;
            Boredom = Boredom - 20;
            Health = Health + 10;
            Console.WriteLine($"\nYou played with {Name}\n");
        }

        public override void Tick()
        {
            Hunger = Hunger + 5;
            Boredom = Boredom + 5;
            Health = Health - 5;
        }
        public override void CreatePet()
        {
            Console.WriteLine("What is your pet's name?");
            Name = Console.ReadLine();
            Console.WriteLine("What is the species of your pet?");
            Species = Console.ReadLine();
            Console.WriteLine($"\nYou created a {Species} named {Name}\n");
        }
        public override void ShowPetStatus()
        {
            Console.WriteLine($"Status of {Name} the {Species}\n");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Boredom: {Boredom}");
            Console.WriteLine($"Health: {Health}\n");

        }
    }
}
