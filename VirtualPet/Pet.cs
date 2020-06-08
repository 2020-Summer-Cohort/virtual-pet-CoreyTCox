﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }

        public string Species { get; set; }

        public int Hunger { get; set; }

        public int Boredom { get; set; }

        public int Health { get; set; }

        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            Name = name;
        }

        // add a method named SetSpecies that takes in a string parameter, has no return value, and sets the 
        // Species property to the value passed in as a parameter
        public string GetSpecies()
        {
            return Species;
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }

        // add a method named Feed that has no parameters, has no return value, and decreases Hunger by 40
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
        public void Feed()
        {
            Hunger = Hunger - 40;
            Console.WriteLine($"\nYou fed {Name}\n");
        }

        public void SeeVet()
        {
            Health = Health + 30;
            Console.WriteLine($"\nYou took {Name} to the Vet\n");
        }

        public void Play()
        {
            Hunger = Hunger + 10;
            Boredom = Boredom - 20;
            Health = Health + 10;
            Console.WriteLine($"\nYou played with {Name}\n");
        }

        public void Tick()
        {
            Hunger = Hunger + 5;
            Boredom = Boredom + 5;
            Health = Health - 5;
        }
        public void CreatePet()
        {
            Console.WriteLine("What is your pet's name?");
            Name = Console.ReadLine();
            Console.WriteLine("What is the species of your pet?");
            Species = Console.ReadLine();
            Console.WriteLine($"\nYou created a {Species} named {Name}\n");
        }
        public void ShowPetStatus()
        {
            Console.WriteLine($"Status of {Name} the {Species}\n");
            Console.WriteLine($"Hunger: {Hunger}");
            Console.WriteLine($"Boredom: {Boredom}");
            Console.WriteLine($"Health: {Health}\n");

        }


    }
}
