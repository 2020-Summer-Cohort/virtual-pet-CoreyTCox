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
    }
}

