using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        Pet testPet;
        Shelter testShelter;//could have used sut for "system under test"
        public ShelterTests()
        {
            testPet = new Pet();
            testShelter = new Shelter();
        }

        //admit pets into shelter and adopt
        //see list of all pets in shelter
        //see current status of all pets in shelter
        //player can choose which pet(s) to interact with
        [Fact]
        public void Shelter_Constructor_Should_Instantiate_Shelter_Object()
        {
            Assert.NotNull(testShelter);
        }

        [Fact]
        public void Should_Instantiate_List()
        {
            Assert.NotNull(testShelter.listOfPets);
        }
        [Fact]
        public void Add_Pet_To_Shelter_Should_Add_Pet_To_List()
        {
            testShelter.AddPetToShelter(testPet);
            Assert.NotNull(testShelter.listOfPets[0]);
        }

        [Fact]
        public void Feed_All_Pets_Should_Decrease_Hunger_Of_All_Pets_By_40()
        {
            Pet testPet1 = new Pet();
            testShelter.listOfPets.Add(testPet1);
            Pet testPet2 = new Pet();
            testShelter.listOfPets.Add(testPet2);
            Pet testPet3 = new Pet();
            testShelter.listOfPets.Add(testPet3);

            testShelter.FeedAllPets();

            Assert.Equal(10, testPet1.Hunger);
            Assert.Equal(10, testPet2.Hunger);
            Assert.Equal(10, testPet3.Hunger);
        }
        
        [Fact]
        public void See_Vet_All_Pets_Should_Increase_Health_Of_All_Pets_By_30()
        {
            Pet testPet1 = new Pet();
            testShelter.listOfPets.Add(testPet1);
            Pet testPet2 = new Pet();
            testShelter.listOfPets.Add(testPet2);
            Pet testPet3 = new Pet();
            testShelter.listOfPets.Add(testPet3);

            testShelter.SeeVetAllPets();

            Assert.Equal(60, testPet1.Health);
            Assert.Equal(60, testPet2.Health);
            Assert.Equal(60, testPet3.Health);
        }

        [Fact]
        public void Play_All_Pets_Should_Decrease_Boredom_Of_All_Pets_By_20()
        {
            Pet testPet1 = new Pet();
            testShelter.listOfPets.Add(testPet1);
            Pet testPet2 = new Pet();
            testShelter.listOfPets.Add(testPet2);
            Pet testPet3 = new Pet();
            testShelter.listOfPets.Add(testPet3);

            testShelter.PlayAllPets();

            Assert.Equal(40, testPet1.Boredom);
            Assert.Equal(40, testPet2.Boredom);
            Assert.Equal(40, testPet3.Boredom);
        }
        
        [Fact]
        public void Play_All_Pets_Should_Increase_Hunger_Of_All_Pets_By_10()
        {
            Pet testPet1 = new Pet();
            testShelter.listOfPets.Add(testPet1);
            Pet testPet2 = new Pet();
            testShelter.listOfPets.Add(testPet2);
            Pet testPet3 = new Pet();
            testShelter.listOfPets.Add(testPet3);

            testShelter.PlayAllPets();

            Assert.Equal(60, testPet1.Hunger);
            Assert.Equal(60, testPet2.Hunger);
            Assert.Equal(60, testPet3.Hunger);
        }
        
        [Fact]
        public void Play_All_Pets_Should_Increase_Health_Of_All_Pets_By_10()
        {
            Pet testPet1 = new Pet();
            testShelter.listOfPets.Add(testPet1);
            Pet testPet2 = new Pet();
            testShelter.listOfPets.Add(testPet2);
            Pet testPet3 = new Pet();
            testShelter.listOfPets.Add(testPet3);

            testShelter.PlayAllPets();

            Assert.Equal(40, testPet1.Health);
            Assert.Equal(40, testPet2.Health);
            Assert.Equal(40, testPet3.Health);
        }

        [Fact]
        public void Tick_All_Pets_Should_Increase_Hunger_Of_All_Pets_By_5()
        {
            Pet testPet1 = new Pet();
            testShelter.listOfPets.Add(testPet1);
            Pet testPet2 = new Pet();
            testShelter.listOfPets.Add(testPet2);
            Pet testPet3 = new Pet();
            testShelter.listOfPets.Add(testPet3);

            testShelter.TickAllPets();

            Assert.Equal(55, testPet1.Hunger);
            Assert.Equal(55, testPet2.Hunger);
            Assert.Equal(55, testPet3.Hunger);
        }
        
        [Fact]
        public void Tick_All_Pets_Should_Increase_Boredom_Of_All_Pets_By_5()
        {
            Pet testPet1 = new Pet();
            testShelter.listOfPets.Add(testPet1);
            Pet testPet2 = new Pet();
            testShelter.listOfPets.Add(testPet2);
            Pet testPet3 = new Pet();
            testShelter.listOfPets.Add(testPet3);

            testShelter.TickAllPets();

            Assert.Equal(65, testPet1.Boredom);
            Assert.Equal(65, testPet2.Boredom);
            Assert.Equal(65, testPet3.Boredom);
        }
        
        [Fact]
        public void Tick_All_Pets_Should_Decrease_Health_Of_All_Pets_By_5()
        {
            Pet testPet1 = new Pet();
            testShelter.listOfPets.Add(testPet1);
            Pet testPet2 = new Pet();
            testShelter.listOfPets.Add(testPet2);
            Pet testPet3 = new Pet();
            testShelter.listOfPets.Add(testPet3);

            testShelter.TickAllPets();

            Assert.Equal(25, testPet1.Health);
            Assert.Equal(25, testPet2.Health);
            Assert.Equal(25, testPet3.Health);
        }
    }
}
