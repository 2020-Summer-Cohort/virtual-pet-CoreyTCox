using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Shelter shelter = new Shelter();

            bool keepThinking = true;
            while (keepThinking)
           {

                Console.WriteLine("Hello! Welcome to Virtual Pets");

                Console.WriteLine("1. Feed your pet");
                Console.WriteLine("2. Take your pet to the vet");
                Console.WriteLine("3. Play with your pet");
                Console.WriteLine("4. Add a pet");
                Console.WriteLine("5. Show Pet Status");
                Console.WriteLine("6. Feed all pets");
                Console.WriteLine("7. Take all pets to the vet");
                Console.WriteLine("8. Play with all pets");
                Console.WriteLine("9. See all pets in shelter");
                Console.WriteLine("10. Show status of all pets");
                Console.WriteLine("11. Select A Pet");
                Console.WriteLine("12. Exit");

                string userSelection = Console.ReadLine();
                shelter.TickAllPets();
                Console.Clear();

                switch (userSelection)
                {
                    case "1":
                        pet.Feed();                        
                        break;
                    case "2":
                        pet.SeeVet();
                        break;
                    case "3":
                        pet.Play();
                        break;
                    case "4":
                        pet = new Pet();
                        pet.CreatePet();
                        shelter.AddPetToShelter(pet);
                        break;
                    case "5":
                        pet.ShowPetStatus();
                        break;
                    case "6":
                        shelter.FeedAllPets();
                        break;
                    case "7":
                        shelter.SeeVetAllPets();
                        break;
                    case "8":
                        shelter.PlayAllPets();
                        break;
                    case "9":
                        shelter.SeeListOfPets();
                        break;
                    case "10":
                        shelter.SeeStatusOfPets();
                        break;
                    case "11":
                        shelter.SeeListOfPets();
                        Console.WriteLine("Select a pet(#)");
                        int petSelection = Convert.ToInt32(Console.ReadLine());
                        pet = shelter.SelectPet(petSelection);
                        Console.WriteLine($"You selected {pet.Name} the {pet.Species}");
                        break;
                    case "12":                  
                        keepThinking = false;
                        break;
                }    
            }
        }
    }
}
