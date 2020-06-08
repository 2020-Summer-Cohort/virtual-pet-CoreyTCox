using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            int count = 1;
            foreach (Pet pet in listOfPets)
            {
                Console.WriteLine($"{count}. {pet.GetName()} the {pet.GetSpecies()}\n");
                count++;
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
        public Pet SelectPet(int petSelection)
            //SeeListOfPets();
            //Console.Write("Select a Pet");
            //petSelection = Convert.ToInt32(Console.ReadLine());
        {
            int petIndex = petSelection - 1;
            return listOfPets[petIndex];
        }
    }
}

