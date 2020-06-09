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

        public Pet()
        {
            
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

        public virtual void Feed()
        {

        }

        public virtual void SeeVet()
        {

        }

        public virtual void Play()
        {
           
        }

        public virtual void Tick()
        {

        }
        public virtual void CreatePet()
        {

        }
        public virtual void ShowPetStatus()
        {

        }


    }
}
