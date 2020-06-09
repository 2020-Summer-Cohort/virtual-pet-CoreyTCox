using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        OrganicPet testOrganicPet1;
        OrganicPet testOrganicPet2;
        OrganicPet testOrganicPet3;

        RoboticPet testRoboticPet1;
        RoboticPet testRoboticPet2;
        RoboticPet testRoboticPet3;

        Shelter testShelter;//could have used sut for "system under test"
        public ShelterTests()
        {
            testOrganicPet1 = new OrganicPet();
            testOrganicPet2 = new OrganicPet();
            testOrganicPet3 = new OrganicPet();

            testRoboticPet1 = new RoboticPet();
            testRoboticPet2 = new RoboticPet();
            testRoboticPet3 = new RoboticPet();

            testShelter = new Shelter();
        }

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
            testShelter.AddPetToShelter(testOrganicPet1);
            Assert.NotNull(testShelter.listOfPets[0]);
        }

        [Fact]
        public void Feed_All_Pets_Should_Decrease_Hunger_Of_All_Pets_By_40()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);            
            testShelter.listOfPets.Add(testOrganicPet3);

            testShelter.FeedAllPets();

            Assert.Equal(10, testOrganicPet1.Hunger);
            Assert.Equal(10, testOrganicPet2.Hunger);
            Assert.Equal(10, testOrganicPet3.Hunger);
        }
        
        [Fact]
        public void Feed_All_Pets_Should_Increase_Battery_Of_All_Robotics_Pets_To_100()
        {
            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.FeedAllPets();

            Assert.Equal(100, testRoboticPet1.Battery);
            Assert.Equal(100, testRoboticPet2.Battery);
            Assert.Equal(100, testRoboticPet3.Battery);
        }
        
        [Fact]
        public void See_Vet_All_Pets_Should_Increase_Health_Of_All_Pets_By_30()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);
            testShelter.listOfPets.Add(testOrganicPet3);

            testShelter.SeeVetAllPets();

            Assert.Equal(60, testOrganicPet1.Health);
            Assert.Equal(60, testOrganicPet2.Health);
            Assert.Equal(60, testOrganicPet3.Health);
        }
        
        [Fact]
        public void See_Vet_All_Pets_Should_Increase_Oil_Of_All_Robotic_Pets_To_100()
        {
            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.SeeVetAllPets();

            Assert.Equal(100, testRoboticPet1.Oil);
            Assert.Equal(100, testRoboticPet2.Oil);
            Assert.Equal(100, testRoboticPet3.Oil);
        }
        
        [Fact]
        public void See_Vet_All_Pets_Should_Decrease_Rust_Of_All_Robotic_Pets_By_15()
        {
            testRoboticPet1.Rust = 15;
            testRoboticPet2.Rust = 15;
            testRoboticPet3.Rust = 15;

            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.SeeVetAllPets();

            Assert.Equal(0, testRoboticPet1.Rust);
            Assert.Equal(0, testRoboticPet2.Rust);
            Assert.Equal(0, testRoboticPet3.Rust);
        }

        [Fact]
        public void Play_All_Pets_Should_Decrease_Boredom_Of_All_Pets_By_20()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);
            testShelter.listOfPets.Add(testOrganicPet3);

            testShelter.PlayAllPets();

            Assert.Equal(40, testOrganicPet1.Boredom);
            Assert.Equal(40, testOrganicPet2.Boredom);
            Assert.Equal(40, testOrganicPet3.Boredom);
        }
        
        [Fact]
        public void Play_All_Pets_Should_Increase_Hunger_Of_All_Pets_By_10()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);
            testShelter.listOfPets.Add(testOrganicPet3);

            testShelter.PlayAllPets();

            Assert.Equal(60, testOrganicPet1.Hunger);
            Assert.Equal(60, testOrganicPet2.Hunger);
            Assert.Equal(60, testOrganicPet3.Hunger);
        }
        
        [Fact]
        public void Play_All_Pets_Should_Increase_Health_Of_All_Pets_By_10()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);
            testShelter.listOfPets.Add(testOrganicPet3);

            testShelter.PlayAllPets();

            Assert.Equal(40, testOrganicPet1.Health);
            Assert.Equal(40, testOrganicPet2.Health);
            Assert.Equal(40, testOrganicPet3.Health);
        }
        
        [Fact]
        public void Play_All_Pets_Should_Decrease_Rust_Of_All_Robotic_Pets_By_25()
        {
            testRoboticPet1.Rust = 25;
            testRoboticPet2.Rust = 25;
            testRoboticPet3.Rust = 25;

            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.PlayAllPets();

            Assert.Equal(0, testRoboticPet1.Rust);
            Assert.Equal(0, testRoboticPet2.Rust);
            Assert.Equal(0, testRoboticPet3.Rust);
        }
        
        [Fact]
        public void Play_All_Pets_Should_Decrease_Battery_Of_All_Robotic_Pets_By_30()
        {
            testRoboticPet1.Battery = 30;
            testRoboticPet2.Battery = 30;
            testRoboticPet3.Battery = 30;

            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.PlayAllPets();

            Assert.Equal(0, testRoboticPet1.Battery);
            Assert.Equal(0, testRoboticPet2.Battery);
            Assert.Equal(0, testRoboticPet3.Battery);
        }
        
        [Fact]
        public void Play_All_Pets_Should_Decrease_Oil_Of_All_Robotic_Pets_By_20()
        {
            testRoboticPet1.Oil = 20;
            testRoboticPet2.Oil = 20;
            testRoboticPet3.Oil = 20;

            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.PlayAllPets();

            Assert.Equal(0, testRoboticPet1.Oil);
            Assert.Equal(0, testRoboticPet2.Oil);
            Assert.Equal(0, testRoboticPet3.Oil);
        }

        [Fact]
        public void Tick_All_Pets_Should_Increase_Hunger_Of_All_Pets_By_5()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);
            testShelter.listOfPets.Add(testOrganicPet3);

            testShelter.TickAllPets();

            Assert.Equal(55, testOrganicPet1.Hunger);
            Assert.Equal(55, testOrganicPet2.Hunger);
            Assert.Equal(55, testOrganicPet3.Hunger);
        }
        
        [Fact]
        public void Tick_All_Pets_Should_Increase_Boredom_Of_All_Pets_By_5()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);
            testShelter.listOfPets.Add(testOrganicPet3);

            testShelter.TickAllPets();

            Assert.Equal(25, testOrganicPet1.Health);
            Assert.Equal(25, testOrganicPet2.Health);
            Assert.Equal(25, testOrganicPet3.Health);
        }

        [Fact]
        public void Tick_All_Pets_Should_Decrease_Health_Of_All_Pets_By_5()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);
            testShelter.listOfPets.Add(testOrganicPet3);

            testShelter.TickAllPets();

            Assert.Equal(25, testOrganicPet1.Health);
            Assert.Equal(25, testOrganicPet2.Health);
            Assert.Equal(25, testOrganicPet3.Health);
        }
        
        [Fact]
        public void Tick_All_Pets_Should_Increase_Rust_Of_All_Robotic_Pets_By_5()
        {
            testRoboticPet1.Rust = 0;
            testRoboticPet2.Rust = 0;
            testRoboticPet3.Rust = 0;
            
            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.TickAllPets();

            Assert.Equal(5, testRoboticPet1.Rust);
            Assert.Equal(5, testRoboticPet2.Rust);
            Assert.Equal(5, testRoboticPet3.Rust);
        }
        
        [Fact]
        public void Tick_All_Pets_Should_Decerease_Battery_Of_All_Robotic_Pets_By_5()
        {
            testRoboticPet1.Battery = 5;
            testRoboticPet2.Battery = 5;
            testRoboticPet3.Battery = 5;

            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.TickAllPets();

            Assert.Equal(0, testRoboticPet1.Battery);
            Assert.Equal(0, testRoboticPet2.Battery);
            Assert.Equal(0, testRoboticPet3.Battery);
        }
        
        [Fact]
        public void Tick_All_Pets_Should_Decrease_Oil_Of_All_Robotic_Pets_By_5()
        {
            testRoboticPet1.Oil = 5;
            testRoboticPet2.Oil = 5;
            testRoboticPet3.Oil = 5;

            testShelter.listOfPets.Add(testRoboticPet1);
            testShelter.listOfPets.Add(testRoboticPet2);
            testShelter.listOfPets.Add(testRoboticPet3);

            testShelter.TickAllPets();

            Assert.Equal(0, testRoboticPet1.Oil);
            Assert.Equal(0, testRoboticPet2.Oil);
            Assert.Equal(0, testRoboticPet3.Oil);
        }

        [Fact]
        public void Select_Pet_Should_Return_Pet_In_Related_Index_In_List()
        {
            testShelter.listOfPets.Add(testOrganicPet1);
            testShelter.listOfPets.Add(testOrganicPet2);
            testShelter.listOfPets.Add(testOrganicPet3);
            
            testShelter.SelectPet(1);

            Assert.Equal(testShelter.listOfPets[0], testOrganicPet1);
        }
    }
}
