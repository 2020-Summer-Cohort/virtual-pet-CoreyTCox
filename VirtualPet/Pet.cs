using System;
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
        public void Feed()
        {
            Hunger = Hunger - 40;
        }

        // add a method named SeeDoctor that has no parameters, has no return value, and increases Health by 30
        public void SeeVet()
        {
            Health = Health + 30;
        }

        // add a method named Play that has no parameters, has no return value, and increases Hunger by 10,
        // decreases Boredom by 20, and increases Health by 10
        public void Play()
        {
            Hunger = Hunger + 10;
            Boredom = Boredom - 20;
            Health = Health + 10;
        }

        // add a method named Tick that has no parameters, has no return value, and increases Hunger by 5, increases
        // Boredom by 5, and decreases Health by 5
        public void Tick()
        {
            Hunger = Hunger + 5;
            Boredom = Boredom + 5;
            Health = Health - 5;
        }

    }
}
