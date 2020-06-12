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
