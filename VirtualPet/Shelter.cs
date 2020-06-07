using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Shelter
    {
        public List<Pet> listOfPets = new List<Pet>();

        public void AddPetToShelter(Pet pet)
        {
            listOfPets.Add(pet);
            Console.WriteLine("You added a pet to Shelter");
        }
        public void SeeListOfPets()
        {
            foreach (Pet pet in listOfPets)
            {
                Console.WriteLine($"{pet.GetName()} the {pet.GetSpecies()}");
            }
        }
        public void SeeStatusOfPets()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.ShowPetStatus();
            }

        }
        public void FeedAllPets()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.Feed();
            }
        }
        public void PlayAllPets()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.Play();
            }
        }
        public void SeeVetAllPets()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.SeeVet();
            }
        }
        public void TickAllPets()
        {
            foreach (Pet pet in listOfPets)
            {
                pet.Tick();
            }
        }

    }
}

