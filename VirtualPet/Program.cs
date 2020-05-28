using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();

            Console.WriteLine("Hello! Welcome to Virtual Pets");

            Console.WriteLine("1. Feed your pet");
            Console.WriteLine("2. Take your pet to the vet");
            Console.WriteLine("3. Play with your pet");
            Console.WriteLine("4. Exit");

            string userSelection = Console.ReadLine();
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
                    break;
                    
            }
            


        }
    }
}
