using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        Shelter testShelter;//could have used sut for "system under test"
        public ShelterTests()
        {
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
        public void _Should_Instantiate_List()
        {
            Assert.NotNull(testShelter.ListOfPets);
        }

        [Fact]
        public void Admit_Should_Add_Pet_To_Shelter()
        {

        }

        [Fact]
        public void Adopt_Should_Remove_Pet_From_Shelter()
        {

        }
        
        [Fact]
        public void ListOfPets_Should_Print_List_Of_Pets_In_Shelter()
        {

        }

        [Fact]
        public void CurrentStatus_Should_Print_Status_Of_Each_Pet_In_Shelter()
        {

        }
    }
}
